using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Text.RegularExpressions;

namespace comic
{
    interface explainer
    {
        void init(BackgroundWorker tsender, string s, string url, pushMessage get);
        void getImageURLs();
        void getAllUnits();
    }
    public partial class Form1
    {
        public bool select_fzdm(string url)
        {
            if (url.Contains("http://manhua.fzdm.com/")) return true; else return false;
        }
        public bool select_bbhou(string url)
        {
            if (url.Contains("http://www.bbhou.com/manhua/")) return true; else return false;
        }
        explainer _select(string url)
        {
            if (select_fzdm(url)) return new fzdm();
            else if (select_bbhou(url)) return new bbhou();
            else throw new Exception("No explainer matches");
        }
    }
}
