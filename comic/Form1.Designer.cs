using System;

namespace comic
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_URL = new System.Windows.Forms.TextBox();
            this.button_Begin = new System.Windows.Forms.Button();
            this.button_Debug = new System.Windows.Forms.Button();
            this.textBox_webSource = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Next_Regex = new System.Windows.Forms.TextBox();
            this.textBox_images = new System.Windows.Forms.TextBox();
            this.textBox_Firsts = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_First_Regex = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.bgWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bgWorker3 = new System.ComponentModel.BackgroundWorker();
            this.bgWorker2 = new System.ComponentModel.BackgroundWorker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_bg_1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_bg_2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label_bg_3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "下载网址：";
            // 
            // textBox_URL
            // 
            this.textBox_URL.Location = new System.Drawing.Point(83, 6);
            this.textBox_URL.Name = "textBox_URL";
            this.textBox_URL.Size = new System.Drawing.Size(215, 21);
            this.textBox_URL.TabIndex = 1;
            // 
            // button_Begin
            // 
            this.button_Begin.Location = new System.Drawing.Point(304, 5);
            this.button_Begin.Name = "button_Begin";
            this.button_Begin.Size = new System.Drawing.Size(72, 21);
            this.button_Begin.TabIndex = 2;
            this.button_Begin.Text = "begin";
            this.button_Begin.UseVisualStyleBackColor = true;
            this.button_Begin.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_Debug
            // 
            this.button_Debug.Location = new System.Drawing.Point(12, 401);
            this.button_Debug.Name = "button_Debug";
            this.button_Debug.Size = new System.Drawing.Size(365, 20);
            this.button_Debug.TabIndex = 5;
            this.button_Debug.Text = "调试";
            this.button_Debug.UseVisualStyleBackColor = true;
            this.button_Debug.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox_webSource
            // 
            this.textBox_webSource.Location = new System.Drawing.Point(14, 33);
            this.textBox_webSource.Multiline = true;
            this.textBox_webSource.Name = "textBox_webSource";
            this.textBox_webSource.Size = new System.Drawing.Size(362, 362);
            this.textBox_webSource.TabIndex = 6;
            this.textBox_webSource.Visible = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 453);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1005, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(32, 17);
            this.toolStripStatusLabel.Text = "欢迎";
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "单页正则：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "下页正则：";
            // 
            // textBox_Next_Regex
            // 
            this.textBox_Next_Regex.Location = new System.Drawing.Point(83, 66);
            this.textBox_Next_Regex.Name = "textBox_Next_Regex";
            this.textBox_Next_Regex.Size = new System.Drawing.Size(294, 21);
            this.textBox_Next_Regex.TabIndex = 10;
            this.textBox_Next_Regex.Text = "<a href=\'(index_\\d*\\.html)\' id=\"mhona\">下一页</a>";
            // 
            // textBox_images
            // 
            this.textBox_images.Location = new System.Drawing.Point(14, 241);
            this.textBox_images.Multiline = true;
            this.textBox_images.Name = "textBox_images";
            this.textBox_images.Size = new System.Drawing.Size(363, 154);
            this.textBox_images.TabIndex = 12;
            // 
            // textBox_Firsts
            // 
            this.textBox_Firsts.Location = new System.Drawing.Point(14, 125);
            this.textBox_Firsts.Multiline = true;
            this.textBox_Firsts.Name = "textBox_Firsts";
            this.textBox_Firsts.Size = new System.Drawing.Size(363, 110);
            this.textBox_Firsts.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "一页正则：";
            // 
            // textBox_First_Regex
            // 
            this.textBox_First_Regex.Location = new System.Drawing.Point(84, 93);
            this.textBox_First_Regex.Name = "textBox_First_Regex";
            this.textBox_First_Regex.Size = new System.Drawing.Size(214, 21);
            this.textBox_First_Regex.TabIndex = 14;
            this.textBox_First_Regex.Text = "<a href=\'(index_\\d*\\.html)\' id=\"mhona\">下一页</a>";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(304, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 21);
            this.button1.TabIndex = 16;
            this.button1.Text = "begin";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(382, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 17;
            this.label5.Text = "任务列表：";
            // 
            // bgWorker1
            // 
            this.bgWorker1.WorkerReportsProgress = true;
            this.bgWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgDowork);
            this.bgWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgReportProcess);
            this.bgWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgComplete);
            // 
            // bgWorker3
            // 
            this.bgWorker3.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgDowork);
            this.bgWorker3.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgReportProcess);
            this.bgWorker3.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgComplete);
            // 
            // bgWorker2
            // 
            this.bgWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgDowork);
            this.bgWorker2.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgReportProcess);
            this.bgWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgComplete);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Lime;
            this.label6.Location = new System.Drawing.Point(382, 405);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 19;
            this.label6.Text = "获取所有章节";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Aqua;
            this.label7.Location = new System.Drawing.Point(475, 405);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 12);
            this.label7.TabIndex = 20;
            this.label7.Text = "章节转图片详情";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label8.Location = new System.Drawing.Point(580, 405);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 12);
            this.label8.TabIndex = 21;
            this.label8.Text = "图片详情转链接";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label9.Location = new System.Drawing.Point(685, 405);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 22;
            this.label9.Text = "下载图片";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Location = new System.Drawing.Point(384, 33);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(355, 303);
            this.listView1.TabIndex = 23;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "类型";
            this.columnHeader1.Width = 51;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "网址";
            this.columnHeader2.Width = 180;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "章节名称";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "图片序号";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lime;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(453, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "添加任务";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Aqua;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(526, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 23);
            this.button3.TabIndex = 25;
            this.button3.Text = "添加任务";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button4.Location = new System.Drawing.Point(599, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(67, 23);
            this.button4.TabIndex = 26;
            this.button4.Text = "添加任务";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button5.Location = new System.Drawing.Point(672, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(67, 24);
            this.button5.TabIndex = 27;
            this.button5.Text = "添加任务";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_bg_1);
            this.groupBox1.Location = new System.Drawing.Point(745, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 108);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "进程1";
            // 
            // label_bg_1
            // 
            this.label_bg_1.AutoSize = true;
            this.label_bg_1.Location = new System.Drawing.Point(6, 17);
            this.label_bg_1.Name = "label_bg_1";
            this.label_bg_1.Size = new System.Drawing.Size(65, 24);
            this.label_bg_1.TabIndex = 0;
            this.label_bg_1.Text = "就绪\r\n欢迎使用！";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_bg_2);
            this.groupBox2.Location = new System.Drawing.Point(745, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 108);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "进程2";
            // 
            // label_bg_2
            // 
            this.label_bg_2.AutoSize = true;
            this.label_bg_2.Location = new System.Drawing.Point(6, 17);
            this.label_bg_2.Name = "label_bg_2";
            this.label_bg_2.Size = new System.Drawing.Size(65, 24);
            this.label_bg_2.TabIndex = 1;
            this.label_bg_2.Text = "就绪\r\n欢迎使用！";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label_bg_3);
            this.groupBox3.Location = new System.Drawing.Point(745, 312);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(259, 108);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "进程3";
            // 
            // label_bg_3
            // 
            this.label_bg_3.AutoSize = true;
            this.label_bg_3.Location = new System.Drawing.Point(6, 17);
            this.label_bg_3.Name = "label_bg_3";
            this.label_bg_3.Size = new System.Drawing.Size(65, 24);
            this.label_bg_3.TabIndex = 2;
            this.label_bg_3.Text = "就绪\r\n欢迎使用！";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(477, 381);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(262, 21);
            this.textBox1.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(383, 384);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 12);
            this.label10.TabIndex = 31;
            this.label10.Text = "保存的文件夹：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(383, 357);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 12);
            this.label11.TabIndex = 33;
            this.label11.Text = "保存文件路径：";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(477, 354);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(262, 21);
            this.textBox2.TabIndex = 32;
            this.textBox2.Text = "G:\\_mh\\sszj\\{0}_{1}.jpg";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(475, 339);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(143, 12);
            this.label12.TabIndex = 34;
            this.label12.Text = "{0}章节名称,{1}图片序号\r\n";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(385, 334);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(87, 22);
            this.button6.TabIndex = 35;
            this.button6.Text = "手动开始任务";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 475);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_First_Regex);
            this.Controls.Add(this.textBox_Firsts);
            this.Controls.Add(this.textBox_images);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Next_Regex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button_Debug);
            this.Controls.Add(this.button_Begin);
            this.Controls.Add(this.textBox_URL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_webSource);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_URL;
        private System.Windows.Forms.Button button_Begin;
        private System.Windows.Forms.Button button_Debug;
        private System.Windows.Forms.TextBox textBox_webSource;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textBox_Next_Regex;
        private System.Windows.Forms.TextBox textBox_images;
        private System.Windows.Forms.TextBox textBox_Firsts;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBox_First_Regex;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.ComponentModel.BackgroundWorker bgWorker1;
        private System.ComponentModel.BackgroundWorker bgWorker3;
        private System.ComponentModel.BackgroundWorker bgWorker2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_bg_1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_bg_2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label_bg_3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button button6;
    }
}

