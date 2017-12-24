using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace comic.matches
{
    public class manhuatai : explainer
    {
        private string nowUrl;
        private string source;
        private BackgroundWorker sender;
        private pushMessage p;

        public void getAllUnits()
        {
            Regex r = new Regex(@"<li><a title=""([^""]+)"" href=""([^""]+)""><span>[^<]+</span></a></li>");
            MatchCollection ps = r.Matches(source);
            foreach (Match p in ps)
            {
                sender.ReportProgress(1, new messageMaker().report(2, nowUrl + p.Groups[2].ToString(), p.Groups[1].ToString()));
            }

        }

        public void getImageURLs()
        {
            Regex r = new Regex(@"mh_info\=\{imgpath:""([^""]+)"",[^,]+,totalimg:(\d+),[^,]+,[^,]+,pageid:(\d+)");
            Match p = r.Match(source);
            int i = int.Parse(p.Groups[2].Value);
            string real = realURL(p.Groups[1].Value, int.Parse(p.Groups[3].Value));
            while (i > 0)
            {
                //http://mhpic.samanlehua.com/comic/
                sender.ReportProgress(1, new messageMaker().report(3, "http://mhpic.samanlehua.com/comic/" + real+i.ToString()+".jpg", this.p.zName, i.ToString()));
                i--;
            }
            //foreach (Match p in ps)
            //{
            //    i++;
            //    sender.ReportProgress(1, new messageMaker().report(3, "http://ccmhimg.ufo001.com" + p.Groups[1].ToString().Replace("\\", ""), this.p.zName, i.ToString()));
            //}
        }

        private string realURL(string m, int pageid)
        {
            Dictionary<string, string> debug = new Dictionary<string, string>();
            m = m.Replace("\\", "");
            string r = "";
            foreach (char each in m)
            {
                string q = m;
                int jian = pageid % 10;
                int b = each;
                string n = ((char)(b - jian)).ToString();
                string to = each.ToString();
                r += n;
                if (!debug.ContainsKey(to))
                    debug.Add(to, n);
            }
            return r;
            //string r = m.Replace(/./ g, function(a){ return String.fromCharCode(a.charCodeAt(0) - pageid % 10)})
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
