using System;
using System.ComponentModel;
using System.Text;
using System.Text.RegularExpressions;

namespace comic.matches
{
    public class bbhou : explainer
    {
        private string nowUrl;
        private string source;
        private BackgroundWorker sender;
        private pushMessage p;

        public void getAllUnits()
        {
            //href="(/manhua/[0-9a-zA-Z]*/\d*\.html)" title="([^"]*)" target="_blank">[^<]*</a>
            //aHJlZj0iKC9tYW5odWEvWzAtOWEtekEtWl0qL1xkKlwuaHRtbCkiIHRpdGxlPSIoW14iXSopIiB0YXJnZXQ9Il9ibGFuayI+W148XSo8L2E+
            MatchCollection ps = Regex.Matches(source, Encoding.UTF8.GetString(Convert.FromBase64String("aHJlZj0iKC9tYW5odWEvWzAtOWEtekEtWl0qL1xkKlwuaHRtbCkiIHRpdGxlPSIoW14iXSopIiB0YXJnZXQ9Il9ibGFuayI+W148XSo8L2E+")));
            foreach (Match p in ps)
            {
                sender.ReportProgress(1, new messageMaker().report(2, "http://www.bbhou.com" + p.Groups[1].ToString(), p.Groups[2].ToString()));
            }
        }

        public void getImageURLs()
        {
            //"\\/comic\\/(\d*)\\/(\d*)\\/(\d*)\\/(\d*)\.jpg"
            //IlxcL2NvbWljXFwvKFxkKilcXC8oXGQqKVxcLyhcZCopXFwvKFxkKilcLmpwZyI=
            MatchCollection ps = Regex.Matches(source, Encoding.UTF8.GetString(Convert.FromBase64String("IlxcL2NvbWljXFwvKFxkKilcXC8oXGQqKVxcLyhcZCopXFwvKFxkKilcLmpwZyI=")));
            int i = 0;
            foreach (Match p in ps)
            {
                i++;
                sender.ReportProgress(1, new messageMaker().report(3, "http://hicomic.bbhou.com/comic/" + p.Groups[1] + "/" + p.Groups[2] + "/" + p.Groups[3] + "/" + p.Groups[4] + ".jpg", this.p.zName, i.ToString()));
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
