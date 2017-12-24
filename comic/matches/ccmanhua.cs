using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace comic.matches
{
    public class ccmanhua : explainer
    {
        private string nowUrl;
        private string source;
        private BackgroundWorker sender;
        private pushMessage p;

        public void getAllUnits()
        {
            Regex r = new Regex(@"<li><a href=""([a-zA-Z0-9/\.]+)"" title=""([^""]+)""");
            MatchCollection ps = r.Matches(source);
            foreach(Match p in ps)
            {
                sender.ReportProgress(1, new messageMaker().report(2, "http://www.ccmanhua.net" + p.Groups[1].ToString(), p.Groups[2].ToString()));
            }
        }

        public void getImageURLs()
        {
            Regex r = new Regex(@"([\\/a-zA-Z0-9]+\.jpg)");
            MatchCollection ps = r.Matches(source);
            int i = 0;
            foreach(Match p in ps)
            {
                i++;
                sender.ReportProgress(1, new messageMaker().report(3, "http://ccmhimg.ufo001.com" + p.Groups[1].ToString().Replace("\\",""), this.p.zName, i.ToString()));
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
