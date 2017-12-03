using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace comic
{
    interface geter
    {
        string[] getImageURLs(string detail_context);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="main_context">main website URL</param>
        /// <returns>detail_urls</returns>
        List<List<string>> getAllUnitURLs(string main_context);
        string getImageURL(string detail_context);
        string getNextURL(string detail_context, string nowURL);
    }
    public class fzdm : geter
    {
        public List<List<string>> getAllUnitURLs(string main_context)
        {
            //<li class="pure-u-1-2 pure-u-lg-1-4"><a href="([^\"]*)" title="([^\"]*)">.*</a></li>
            //PGxpIGNsYXNzPSJwdXJlLXUtMS0yIHB1cmUtdS1sZy0xLTQiPjxhIGhyZWY9IihbXlwiXSopIiB0aXRsZT0iKFteXCJdKikiPi4qPC9hPjwvbGk+
            List<List<string>> re = new List<List<string>>();
            MatchCollection ps = Regex.Matches(main_context, Encoding.UTF8.GetString(Convert.FromBase64String("PGxpIGNsYXNzPSJwdXJlLXUtMS0yIHB1cmUtdS1sZy0xLTQiPjxhIGhyZWY9IihbXlwiXSopIiB0aXRsZT0iKFteXCJdKikiPi4qPC9hPjwvbGk+")));
            foreach(Match p in ps)
            {
                List<string> o = new List<string>();
                o.Add(p.Groups[1].ToString());
                o.Add(p.Groups[2].ToString());
                re.Add(o);
            }
            return re;
        }

        public string[] getImageURLs(string detail_context)
        {
            throw new NotImplementedException();
        }
        public string getImageURL(string detail_context)
        {
            //MessageBox.Show(@"mhurl\s\=\s\" + "\"" + @"([^\n] *\" + @".jpg)\" + "\"" + ";");
            //MatchCollection mc = Regex.Matches(detail_context, @"mhurl\s\=\s\"+"\""+@"([^\n] *\"+@".jpg)\"+"\""+";");
            string reg = Encoding.UTF8.GetString(Convert.FromBase64String("bWh1cmxcc1w9XHNcIihbXlxuXSpcLmpwZylcIjs="));
            Match m = Regex.Match(detail_context,reg);
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
    }
}
