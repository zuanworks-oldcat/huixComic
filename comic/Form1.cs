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
            panel1.Visible = false;
            timer1.Enabled = true;
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
            button7_Click(new object(), new EventArgs());
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = false;
            timer1.Enabled = true;
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

        private void button7_Click(object sender, EventArgs e)
        {
            textBox_out.Text = "huixComic ver:" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString() + "\r\n";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem var in listView2.Items)
            {
                if (var.Selected)
                {
                    listView1.Items.Add(happyapps.DeepCopy(var));
                    var.Remove();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem var in listView2.Items)
            {
                if (var.Selected)
                {
                    var.Remove();
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox_maxBGs_C.Text) > 0 && Convert.ToInt32(textBox_maxBGs_C.Text) < 100)
            {
                textBox_maxBGWs.Text = Convert.ToInt32(textBox_maxBGs_C.Text).ToString();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int c = 0;
            foreach (ListViewItem var in listView3.Items)
            {
                c++;
                if (!var.Selected) continue;
                BGWs[Convert.ToUInt32(var.Text)].CancelAsync();
                listView2.Items.Add(happyapps.DeepCopy(BGWitems[Convert.ToUInt32(var.Text)]));
                BGWs.Remove(Convert.ToUInt32(var.Text));
                BGWinfos.Remove(Convert.ToUInt32(var.Text));
                BGWitems.Remove(Convert.ToUInt32(var.Text));
            }
            if (c != 0) textBox_out.Text += "本次将" + c.ToString() + "个任务取消" + "\r\n";
            setTipLabel();
        }

        int news = 0;
        int dones = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_status.Text = string.Format("完成{1}个任务，新增{0}个任务（上一秒）", news.ToString(), dones.ToString());
            news = 0;
            dones = 0;
        }
    }
}
