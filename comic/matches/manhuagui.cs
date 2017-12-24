using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace comic
{
    class manhuagui : explainer
    {
        private string nowUrl;
        private string source;
        private BackgroundWorker sender;
        private pushMessage p;

        public void getAllUnits()
        {
            Regex r = new Regex(@"<li><a href=""[^""]+"" title=""([^""]+)"" class=""status0"" target=""_blank""><span>[^<]+<i>[^<]+</i></span></a></li>");
            MatchCollection ps = r.Matches(source);
            foreach (Match p in ps)
            {
                sender.ReportProgress(1, new messageMaker().report(2, "http://www.manhuagui.com" + p.Groups[1].ToString(), p.Groups[2].ToString()));
            }
        }

        public void getImageURLs()
        {
            Regex r = new Regex(@"([\\/a-zA-Z0-9]+\.jpg)");
            MatchCollection ps = r.Matches(source);
            int i = 0;
            foreach (Match p in ps)
            {
                i++;
                sender.ReportProgress(1, new messageMaker().report(3, "http://ccmhimg.ufo001.com" + p.Groups[1].ToString().Replace("\\", ""), this.p.zName, i.ToString()));
            }
        }

        private string getImageURL(string ip, int ia, int ic, string ik, int ie)
        {
            manhuagui_EXP u = new manhuagui_EXP(ip, ia, ic, ik, ie);
            return u.URL;
        }



        public void init(BackgroundWorker tsender, string s, string url, pushMessage get)
        {
            nowUrl = url;
            source = s;
            sender = tsender;
            p = get;
        }
    }
    public class manhuagui_EXP
    {
        private string p;
        private int a;
        private int c;
        private string k;
        private int e;
        private Dictionary<string, string> d = new Dictionary<string, string>();

        public manhuagui_EXP(string ip, int ia, int ic, string ik, int ie)
        {
            p = ip;
            a = ic;
            c = ic;
            k = ik;
            e = ie;
            while (c--==0)
            {
                d[ee(c)] = k[c].ToString();
            }
            foreach(var u in d)
            {
                p.Replace(u.Key, u.Value);
            }
            url = p;
        }

        string ee(int c)
        {
            return (c < a ? "" : ee(c / a)) + ((c = c % a) > 35 ? ((char)(c + 29)).ToString() : Jin36(c));
        }

        private string url;
        public string URL
        {
            get
            {
                return url;
            }
        }

        public static string Jin36(int i)
        {
            string s = "";
            while (i > 36)
            {
                int j = i % 36;
                s += ((j <= 9) ? Convert.ToChar(j + '0') : Convert.ToChar(j - 10 + 'a'));
                i = i / 36;
            }
            s += ((i <= 9) ? Convert.ToChar(i + '0') : Convert.ToChar(i - 10 + 'a'));

            char[] c = s.ToCharArray();
            Array.Reverse(c);
            return new string(c);
        }


    }
}
