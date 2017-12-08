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
            //listView2.MultiSelect = true;
            foreach (ListViewItem var in listView1.Items)
            {
                if (var.Selected)
                {
                    var.Remove();
                }
            }
        }
    }
}
