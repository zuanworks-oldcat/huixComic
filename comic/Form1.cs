using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace comic
{

    public partial class Form1 : Form
    {

        private bool[] bgStatus = new bool[3];
        private string GetHttpWebRequest(object urll)
        {
            string url = urll as string;
            string strHTML = "";
            WebClient myWebClient = new WebClient();
            Stream myStream = myWebClient.OpenRead(url);
            StreamReader sr = new StreamReader(myStream, Encoding.GetEncoding("utf-8"));
            strHTML = sr.ReadToEnd();
            myStream.Close();
            //in:websource
            return strHTML;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//button_begin
        {
            textBox_images.Text = "";
            do
            {
                Task<string> t1 = Task<string>.Factory.StartNew(new Func<object, string>(GetHttpWebRequest), (object)textBox_URL.Text);
                List<int> index = new List<int>();
                toolStripProgressBar.Minimum = 0;
                toolStripProgressBar.Maximum = 60;
                toolStripProgressBar.Value = 0;
                toolStripStatusLabel.Text = "等待主页获取";
                if (!t1.IsCompleted) Application.DoEvents();
                Application.DoEvents();
                for (int i = 0; i < 1000; i++) { label1.MaximumSize = new Size(1000 + i, 1000 + i); };//无奈之举
                if (!t1.IsFaulted)
                {
                    textBox_webSource.Text = t1.Result;
                    string webs = textBox_webSource.Text;
                    //Regex.Matches(webs,"")
                    //MessageBox.Show(index.Count.ToString());
                    fzdm imageGeter = new fzdm();
                    textBox_images.Text += imageGeter.getImageURL(webs) + "\r\n";
                    textBox_URL.Text = imageGeter.getNextURL(webs, textBox_URL.Text);
                }
                else
                {
                    break;
                }
            } while (textBox_URL.Text != "");
        }
        bool DebugFlag = false;
        private void button3_Click(object sender, EventArgs e)
        {
            //if (DebugFlag)
            //{
            //    DebugFlag = false;
            //    textBox_webSource.Visible=true;
            //}
            //else
            //{
            //    DebugFlag = true;
            //    textBox_URL.BringToFront();
            //}
            textBox_webSource.BringToFront();
            DebugFlag = !DebugFlag;
            textBox_webSource.Visible = DebugFlag;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            new_call();
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            string ask = Interaction.InputBox("输入一章开头的链接", "询问：", "http://");
            if (ask != "")
            {
                string mc = Interaction.InputBox("输入章节名称", "询问：");
                if (mc == "") return;
                ListViewItem i = new ListViewItem();
                i.Text = "章>详";
                i.SubItems.Add(ask);
                i.SubItems.Add(mc);
                i.SubItems.Add("---");
                listView1.Items.Add(i);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bgStatus[0] = false;
            bgStatus[1] = false;
            bgStatus[2] = false;
        }
        
    }
    
    
}
