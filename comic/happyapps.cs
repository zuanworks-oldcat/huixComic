using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace comic
{
    public static class happyapps
    {
        public static string GetHttpWebRequest(object urll)
        {
            string strHTML = "";
            try
            {
                string url = urll as string;

                WebClient myWebClient = new WebClient();
                Stream myStream = myWebClient.OpenRead(url);
                StreamReader sr = new StreamReader(myStream, Encoding.GetEncoding("utf-8"));
                strHTML = sr.ReadToEnd();
                myStream.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("发生了个错误：无法读取网页，一般是服务器挂了\n错误信息\n" + e.ToString() + "\n如果一直出现这个错误，当我（这个信息框）在显示的时候，直接按下Ctrl+c就可以复制错误信息给我咯！");
            }
            //in:websource
            return strHTML;
        }
    }
}
