using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;
namespace comic
{
    public partial class Form1
    {
        private bool[] bgStatus = new bool[3];

        #region 主线程方法/委托方法

        private void new_call()
        {
            if (listView1.Items.Count == 0) return;
            pushMessage to = new pushMessage();
            to.item = listView1.Items[0];
            to.path = textBox_path.Text;
            if (!bgStatus[0])
            {
                bgStatus[0] = true;
                to.bgNum = 1;
                bgWorker1.RunWorkerAsync(to);
            }
            else if (!bgStatus[1])
            {
                bgStatus[1] = true;
                to.bgNum = 2;
                bgWorker2.RunWorkerAsync(to);
            }
            else if (!bgStatus[2])
            {
                bgStatus[2] = true;
                to.bgNum = 3;
                bgWorker3.RunWorkerAsync(to);
            }
            else return;
            setTipLabel(to);
            listView1.Items.Remove(listView1.Items[0]);
        }

        private void setTipLabel(pushMessage p)
        {
            Label wait;
            switch (p.bgNum)
            {
                case 1:
                    wait = label_bg_1;
                    break;
                case 2:
                    wait = label_bg_2;
                    break;
                case 3:
                    wait = label_bg_3;
                    break;
                default:
                    throw new Exception("No certain backgroundWorker");
            }
            switch (p.type)
            {
                case 1:
                    break;
                case 2:
                    wait.Text =
                        string.Format(
                            "章节转图片详情\n章节名称：“{0}”\n网址：“{1}”",
                            p.zName,
                            p.value
                            );
                    break;
                case 3:
                    wait.Text =
                        string.Format(
                            "下载图片\n网址：“{0}”\n到：\n“{1}”",
                            p.value,
                            p.pName
                            );
                    break;
            }
        }

        private void bgComplete(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                if (((BackgroundWorkerException)e.Error).e is DownloadFailException)
                {
                    textBox_out.Text += "----下载出错----" + "\r\n";
                    textBox_out.Text += ((DownloadFailException)((BackgroundWorkerException)e.Error).e).URL + "\r\n";
                    textBox_out.Text += ((DownloadFailException)((BackgroundWorkerException)e.Error).e).WebInfo.Message + "\r\n";
                    textBox_out.Text += "----------------" + "\r\n";
                }
                else if (((BackgroundWorkerException)e.Error).e is NoSupportExplainerException)
                {
                    textBox_out.Text += "--不支持的链接--" + "\r\n";
                    textBox_out.Text += ((NoSupportExplainerException)((BackgroundWorkerException)e.Error).e).url + "\r\n";
                    textBox_out.Text += "----------------" + "\r\n";
                }
                else
                {
                    textBox_out.Text += "!!!!未知错误!!!!" + "\r\n";
                    textBox_out.Text += ((BackgroundWorkerException)e.Error).e.Message + "\r\n";
                    textBox_out.Text += ((BackgroundWorkerException)e.Error).e.StackTrace + "\r\n";
                    textBox_out.Text += ((BackgroundWorkerException)e.Error).e.Source + "\r\n";
                }
                listView2.Items.Add(((BackgroundWorkerException)e.Error).push.i.i);
                switch (((BackgroundWorkerException)e.Error).push.bgNum)
                {
                    case 1:
                        label_bg_1.Text = "就绪\n欢迎使用";
                        bgStatus[0] = false;
                        break;
                    case 2:
                        label_bg_2.Text = "就绪\n欢迎使用";
                        bgStatus[1] = false;
                        break;
                    case 3:
                        label_bg_3.Text = "就绪\n欢迎使用";
                        bgStatus[2] = false;
                        break;
                }
            }
            else
            {
                switch (((completeMessage)e.Result).bgNum)
                {
                    case 1:
                        label_bg_1.Text = "就绪\n欢迎使用";
                        bgStatus[0] = false;
                        break;
                    case 2:
                        label_bg_2.Text = "就绪\n欢迎使用";
                        bgStatus[1] = false;
                        break;
                    case 3:
                        label_bg_3.Text = "就绪\n欢迎使用";
                        bgStatus[2] = false;
                        break;
                }
            }
            if (checkBox_auto.Checked)
                new_call();

        }

        private void bgReportProcess(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                reportMessage repo = (reportMessage)e.UserState;
                ListViewItem add = new ListViewItem();
                switch (repo.type)
                {
                    case 1:
                        break;
                    case 2:
                        add.Text = "章>址";
                        add.SubItems.Add(repo.value);
                        add.SubItems.Add(repo.zName);
                        add.SubItems.Add("---");
                        listView1.Items.Add(add);
                        break;
                    case 3:
                        add.Text = "址>值";
                        add.SubItems.Add(repo.value);
                        add.SubItems.Add(repo.zName);
                        add.SubItems.Add(repo.tName);
                        listView1.Items.Add(add);
                        break;
                }
                if (checkBox_auto.Checked)
                    new_call();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        private void bgDowork(object sender, DoWorkEventArgs e)
        {
            pushMessage get = (pushMessage)e.Argument;
            completeMessage r = new completeMessage();
            r.bgNum = get.bgNum;
            e.Result = r;
            try
            {

                #region 初始化explainer
                explainer imageGeter = _select(get.value);
                string mURL = get.value;
                string msource = "";
                msource = happyapps.GetHttpWebRequest(mURL);
                imageGeter.init((BackgroundWorker)sender, msource, get.value, get);
                #endregion
                switch (get.type)
                {
                    case 1:
                        #region 全>章
                        imageGeter.getAllUnits();
                        #endregion
                        break;
                    case 2:
                        #region 章>址
                        imageGeter.getImageURLs();
                        #endregion
                        break;
                    case 3:
                        #region 图>址
                        get.pName = get.pName.Replace("/", "\\");
                        string dir = get.pName.Substring(0, get.pName.LastIndexOf("\\") + 1);
                        if (Directory.Exists(dir) == false)//如果不存在就创建file文件夹
                        {
                            Directory.CreateDirectory(dir);
                        }
                        WebClient myw = new WebClient();
                        try
                        {
                            myw.DownloadFile(get.value, get.pName);
                        }
                        catch (WebException ex)
                        {
                            throw new DownloadFailException(get.value, ex);
                        }
                        #endregion
                        break;
                }
            }
            catch(Exception exx)
            {
                r.item = get;
                throw new BackgroundWorkerException(exx, r);
            }
        }
    }

    public class messageMaker
    {
        public reportMessage report(int type, string value, string zname = "", string tname = "")
        {
            reportMessage repo = new reportMessage();
            repo.type = type;
            repo.value = value;
            repo.zName = zname;
            repo.tName = tname;
            return repo;
        }
    }

    public struct pushMessage
    {
        /*
         
            if (!bgStatus[0])
            {
                bgStatus[0] = true;
                to.bgNum = 1;
                bgWorker1.RunWorkerAsync(to);
            }
            else if (!bgStatus[1])
            {
                bgStatus[1] = true;
                to.bgNum = 2;
                bgWorker2.RunWorkerAsync(to);
            }
            else if (!bgStatus[2])
            {
                bgStatus[2] = true;
                to.bgNum = 3;
                bgWorker3.RunWorkerAsync(to);
            }
            else return;
            setTipLabel(to);
            listView1.Items.Remove(listView1.Items[0]);*/
        /// <summary>
        /// 1.全>章,2.章>址,3.址>值
        /// </summary>
        public int type;
        private string cache;
        public string value;
        public string zName;
        public string tName;
        public string pName;
        public int bgNum;
        public ListViewItem i;
        public ListViewItem item
        {
            set
            {
                i = value;
                switch (value.Text)
                {
                    case "全>章":
                        //MessageBox.Show(string.Format("网站：“{0}”", listView1.Items[0].SubItems[1].Text));
                        type = 1;
                        this.value = value.SubItems[1].Text;
                        break;
                    case "章>址":
                        //MessageBox.Show(string.Format("章节名称：“{0}”,网站：“{1}”", listView1.Items[0].SubItems[2].Text, listView1.Items[0].SubItems[1].Text));
                        type = 2;
                        this.value = value.SubItems[1].Text;
                        zName = value.SubItems[2].Text;
                        break;
                    case "址>值":
                        type = 3;
                        this.value = value.SubItems[1].Text;
                        //pName = string.Format(textBox_path.Text, listView1.Items[0].SubItems[2].Text, listView1.Items[0].SubItems[3].Text);
                        zName = value.SubItems[2].Text;
                        cache = value.SubItems[3].Text;
                        break;
                }
            }
        }
        public string path
        {
            get
            {
                return pName;
            }
            set
            {
                pName = string.Format(value, zName, cache);
            }
        }
    }

    public struct reportMessage
    {
        public int type;
        public string value;
        public string zName;
        public string tName;
    }

    public struct completeMessage
    {
        public int bgNum;
        public pushMessage i
        {
            private set;
            get;
        }
        public pushMessage item
        {
            set
            {
                bgNum = value.bgNum;
                i = value;
            }
        }
    }

    public class DownloadFailException : Exception
    {
        public DownloadFailException(string url, WebException webi)
        {
            URL = url;
            WebInfo = webi;
        }
        private string uRL;
        private WebException webInfo;

        public string URL
        {
            get
            {
                return uRL;
            }

            private set
            {
                uRL = value;
            }
        }

        public WebException WebInfo
        {
            get
            {
                return webInfo;
            }

            private set
            {
                webInfo = value;
            }
        }
    }

    public class ExplainFailException : Exception
    {
        public ExplainFailException()
        {

        }
    }

    public class NoSupportExplainerException : Exception
    {
        public NoSupportExplainerException(string URL)
        {
            url = URL;
        }

        public string url { get; private set; }
    }

    public class BackgroundWorkerException : Exception
    {
        public Exception e
        {
            private set;
            get;
        }
        public completeMessage push
        {
            get;
            private set;
        }

        public BackgroundWorkerException(Exception ex, completeMessage pu)
        {
            e = ex;
            push = pu;
        }
    }
}
