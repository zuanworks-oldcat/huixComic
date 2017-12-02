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
            switch (listView1.Items[0].Text)
            {
                case "章>址":
                    //MessageBox.Show(string.Format("章节名称：“{0}”,网站：“{1}”", listView1.Items[0].SubItems[2].Text, listView1.Items[0].SubItems[1].Text));
                    to.type = 2;
                    to.value = listView1.Items[0].SubItems[1].Text;
                    to.zName = listView1.Items[0].SubItems[2].Text;
                    break;
                case "址>值":
                    to.type = 3;
                    to.value = listView1.Items[0].SubItems[1].Text;
                    to.pName = string.Format(textBox_path.Text,listView1.Items[0].SubItems[2].Text, listView1.Items[0].SubItems[3].Text);
                    break;
            }
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
            new_call();
        }

        private void bgReportProcess(object sender, ProgressChangedEventArgs e)
        {
            reportMessage repo = (reportMessage)e.UserState;
            ListViewItem add = new ListViewItem();
            switch (repo.type)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    add.Text = "址>值";
                    add.SubItems.Add(repo.value);
                    add.SubItems.Add(repo.zName);
                    add.SubItems.Add(repo.tName);
                    listView1.Items.Add(add);
                    break;
            }
            new_call();
        }

        #endregion

        private void bgDowork(object sender, DoWorkEventArgs e)
        {
            pushMessage get = (pushMessage)e.Argument;
            switch (get.type)
            {
                case 1:
                    break;
                case 2:
                    #region 章>址
                    //MessageBox.Show(string.Format(
                    //        "章节转图片详情\n章节名称：“{0}”\n网址：“{1}”",
                    //        get.zName,
                    //        get.value
                    //        ));
                    string URL = get.value;
                    bool failed = false;
                    string source = "";
                    int i = 0;
                    do
                    {
                        try
                        {
                            source = GetHttpWebRequest(URL);
                        }
                        catch
                        {
                            failed = true;
                        }
                        if (!failed)
                        {
                            //Regex.Matches(webs,"")
                            //MessageBox.Show(index.Count.ToString());
                            fzdm imageGeter = new fzdm();
                            reportMessage repo = new reportMessage();
                            repo.type = 3;
                            repo.value = imageGeter.getImageURL(source);
                            repo.zName = get.zName;
                            i++;
                            repo.tName = i.ToString();
                            BackgroundWorker bgw = (BackgroundWorker)sender;
                            if (!bgw.CancellationPending)
                            {
                                bgw.ReportProgress(1,repo);
                            }
                            URL = imageGeter.getNextURL(source, URL);
                        }
                        else
                        {
                            break;
                        }
                    } while (URL != "");
                    completeMessage r = new completeMessage();
                    r.bgNum = get.bgNum;
                    e.Result = r;
                    #endregion
                    break;
                case 3:
                    #region 图>址
                    get.pName = get.pName.Replace("/", "\\");
                    string dir = get.pName.Substring(0,get.pName.LastIndexOf("\\") + 1);
                    if (Directory.Exists(dir) == false)//如果不存在就创建file文件夹
                    {
                        Directory.CreateDirectory(dir);
                    }
                    WebClient myw = new WebClient();
                    try
                    {
                        myw.DownloadFile(get.value, get.pName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(string.Format("下载网站{0}下载到{1}失败：{2}", get.value, get.pName, ex.Message));
                    }
                    completeMessage q = new completeMessage();
                    q.bgNum = get.bgNum;
                    e.Result = q;
                    #endregion
                    break;
            }
        }
    }

    public struct pushMessage
    {
        /// <summary>
        /// 1.全>章,2.章>址,3.址>值
        /// </summary>
        public int type;
        public string value;
        public string zName;
        public string tName;
        public string pName;
        public int bgNum;
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
    }
}
