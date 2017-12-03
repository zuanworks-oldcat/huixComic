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
        private string GetHttpWebRequest(object urll)
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
            catch(Exception e)
            {
                MessageBox.Show("发生了个错误：无法读取网页，一般是服务器挂了\n错误信息\n"+e.ToString()+"\n如果一直出现这个错误，当我（这个信息框）在显示的时候，直接按下Ctrl+c就可以复制错误信息给我咯！");
            }
            //in:websource
            return strHTML;
        }
        
        public Form1()
        {
            InitializeComponent();
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
                i.Text = "章>址";
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            string ask = Interaction.InputBox("输入首页的链接", "询问：", "http://");
            if (ask != "")
            {
                ListViewItem i = new ListViewItem();
                i.Text = "全>章";
                i.SubItems.Add(ask);
                i.SubItems.Add("---");
                i.SubItems.Add("---");
                listView1.Items.Add(i);
            }
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            int Index = 0;
            if (listView1.SelectedItems.Count > 0)//判断listview有被选中项  
            {
                Index = listView1.SelectedItems[0].Index;//取当前选中项的index,SelectedItems[0]这必须为0         
                listView1.Items[Index].Remove();
            }
        }
    }
}
