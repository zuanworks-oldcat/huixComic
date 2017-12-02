using System;
using System.Collections.Generic;
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
        List<string[]> getAllUnitURLs(string main_context);
        string getImageURL(string detail_context);
        string getNextURL(string detail_context, string nowURL);
    }
    public class fzdm : geter
    {
        public List<string[]> getAllUnitURLs(string main_context)
        {
            throw new NotImplementedException();
        }

        public string[] getImageURLs(string detail_context)
        {
            throw new NotImplementedException();
        }
        public string getImageURL(string detail_context)
        {
            //MessageBox.Show(@"mhurl\s\=\s\" + "\"" + @"([^\n] *\" + @".jpg)\" + "\"" + ";");
            //MatchCollection mc = Regex.Matches(detail_context, @"mhurl\s\=\s\"+"\""+@"([^\n] *\"+@".jpg)\"+"\""+";");
            Base64Decoder t = new Base64Decoder();
            Match m = Regex.Match(detail_context, t.GetDecoded("bWh1cmxcc1w9XHNcIihbXlxuXSpcLmpwZylcIjs=").ToString());
            return "http://p1.xiaoshidi.net/" + m.Groups[1];
        }

        public string getNextURL(string detail_context, string nowURL)
        {
            //匹配下一页URL
            Base64Decoder t = new Base64Decoder();
            Match m = Regex.Match(detail_context, t.GetDecoded("PGEgaHJlZj0nKGluZGV4X1xkKlwuaHRtbCknIGlkPSJtaG9uYSI+5LiL5LiA6aG1PC9hPg==").ToString());
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
