using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace comic.matches
{
    public class fzdm : explainer
    {
        private string nowUrl;
        private string source;
        private BackgroundWorker sender;
        private pushMessage p;
        public void getAllUnits()
        {
            //<li class="pure-u-1-2 pure-u-lg-1-4"><a href="([^\"]*)" title="([^\"]*)">.*</a></li>
            //PGxpIGNsYXNzPSJwdXJlLXUtMS0yIHB1cmUtdS1sZy0xLTQiPjxhIGhyZWY9IihbXlwiXSopIiB0aXRsZT0iKFteXCJdKikiPi4qPC9hPjwvbGk+
            MatchCollection ps = Regex.Matches(source, Encoding.UTF8.GetString(Convert.FromBase64String("PGxpIGNsYXNzPSJwdXJlLXUtMS0yIHB1cmUtdS1sZy0xLTQiPjxhIGhyZWY9IihbXlwiXSopIiB0aXRsZT0iKFteXCJdKikiPi4qPC9hPjwvbGk+")));
            foreach (Match p in ps)
            {
                sender.ReportProgress(1, new messageMaker().report(2, nowUrl + p.Groups[1].ToString(), p.Groups[2].ToString()));
            }
        }

        public void getImageURLs()
        {
            //MessageBox.Show(string.Format(
            //        "章节转图片详情\n章节名称：“{0}”\n网址：“{1}”",
            //        get.zName,
            //        get.value
            //        ));
            string URL = nowUrl;
            bool failed = false;
            string s = "";
            int i = 0;
            do
            {
                try
                {
                    s = happyapps.GetHttpWebRequest(URL);
                }
                catch
                {
                    failed = true;
                }
                if (!failed)
                {
                    i++;
                    sender.ReportProgress(1, new messageMaker().report(3, getImageURL(s), p.zName, i.ToString()));
                    URL = getNextURL(s, URL);
                }
                else
                {
                    break;
                }
            } while (URL != "");
        }
        public string getImageURL(string detail_context)
        {
            //MessageBox.Show(@"mhurl\s\=\s\" + "\"" + @"([^\n] *\" + @".jpg)\" + "\"" + ";");
            //MatchCollection mc = Regex.Matches(detail_context, @"mhurl\s\=\s\"+"\""+@"([^\n] *\"+@".jpg)\"+"\""+";");
            string reg = Encoding.UTF8.GetString(Convert.FromBase64String("bWh1cmxcc1w9XHNcIihbXlxuXSpcLmpwZylcIjs="));
            Match m = Regex.Match(detail_context, reg);
            return "http://p1.xiaoshidi.net/" + m.Groups[1];
        }

        public string getNextURL(string detail_context, string nowURL)
        {
            //匹配下一页URL
            Match m = Regex.Match(detail_context, Encoding.UTF8.GetString(Convert.FromBase64String("PGEgaHJlZj0nKGluZGV4X1xkKlwuaHRtbCknIGlkPSJtaG9uYSI+5LiL5LiA6aG1PC9hPg==")));
            if (m.Groups[1].ToString() != "")
            {
                //匹配主链接
                Match n = Regex.Match(nowURL, @"http://manhua\.fzdm\.com/[^/]*/[^/]*/");
                return n.ToString() + m.Groups[1]; ;
            }
            else
            {
                return "";
            }
        }

        public void init(BackgroundWorker tsender, string s, string url, pushMessage get)
        {
            nowUrl = url;
            source = s;
            sender = tsender;
            p = get;
        }
    }
}
