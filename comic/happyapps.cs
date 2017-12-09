using System;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;

namespace comic
{
    public static class happyapps
    {
        public static T DeepCopy<T>(T obj)
        {
            object retval;
            using (MemoryStream ms = new MemoryStream())
            {
                BinaryFormatter bf = new BinaryFormatter();
                //序列化成流
                bf.Serialize(ms, obj);
                ms.Seek(0, SeekOrigin.Begin);
                //反序列化成对象
                retval = bf.Deserialize(ms);
                ms.Close();
            }
            return (T)retval;
        }
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
            catch (WebException e)
            {
                throw new DownloadFailException(urll as string, e);
            }
            //in:websource
            return strHTML;
        }
    }
}
