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
            this.label5 = new System.Windows.Forms.Label();
            this.bgWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bgWorker3 = new System.ComponentModel.BackgroundWorker();
            this.bgWorker2 = new System.ComponentModel.BackgroundWorker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_bg_1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_bg_2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label_bg_3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_path = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.checkBox_auto = new System.Windows.Forms.CheckBox();
            this.button_remove = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_out = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 17;
            this.label5.Text = "任务列表：";
            // 
            // bgWorker1
            // 
            this.bgWorker1.WorkerReportsProgress = true;
            this.bgWorker1.WorkerSupportsCancellation = true;
            this.bgWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgDowork);
            this.bgWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgReportProcess);
            this.bgWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgComplete);
            // 
            // bgWorker3
            // 
            this.bgWorker3.WorkerReportsProgress = true;
            this.bgWorker3.WorkerSupportsCancellation = true;
            this.bgWorker3.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgDowork);
            this.bgWorker3.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgReportProcess);
            this.bgWorker3.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgComplete);
            // 
            // bgWorker2
            // 
            this.bgWorker2.WorkerReportsProgress = true;
            this.bgWorker2.WorkerSupportsCancellation = true;
            this.bgWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgDowork);
            this.bgWorker2.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgReportProcess);
            this.bgWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgComplete);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Lime;
            this.label6.Location = new System.Drawing.Point(12, 405);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 19;
            this.label6.Text = "获取所有章节";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Aqua;
            this.label7.Location = new System.Drawing.Point(157, 405);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 12);
            this.label7.TabIndex = 20;
            this.label7.Text = "章节转图片详情";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label9.Location = new System.Drawing.Point(314, 405);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 22;
            this.label9.Text = "下载图片";
            // 
            // listView1
            // 
            this.listView1.AllowColumnReorder = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.HoverSelection = true;
            this.listView1.Location = new System.Drawing.Point(15, 33);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(355, 322);
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
            this.button2.Location = new System.Drawing.Point(83, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "添加任务";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Aqua;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(156, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 23);
            this.button3.TabIndex = 25;
            this.button3.Text = "添加任务";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button5.Location = new System.Drawing.Point(229, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(67, 24);
            this.button5.TabIndex = 27;
            this.button5.Text = "添加任务";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_bg_1);
            this.groupBox1.Location = new System.Drawing.Point(375, 6);
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
            this.groupBox2.Location = new System.Drawing.Point(375, 159);
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
            this.groupBox3.Location = new System.Drawing.Point(375, 312);
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 384);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 12);
            this.label11.TabIndex = 33;
            this.label11.Text = "保存文件路径：";
            // 
            // textBox_path
            // 
            this.textBox_path.Location = new System.Drawing.Point(107, 381);
            this.textBox_path.Name = "textBox_path";
            this.textBox_path.Size = new System.Drawing.Size(262, 21);
            this.textBox_path.TabIndex = 32;
            this.textBox_path.Text = "G:\\_mh\\sszj\\{0}_{1}.jpg";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(107, 366);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(143, 12);
            this.label12.TabIndex = 34;
            this.label12.Text = "{0}章节名称,{1}图片序号\r\n";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(14, 361);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(87, 22);
            this.button6.TabIndex = 35;
            this.button6.Text = "手动开始任务";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // checkBox_auto
            // 
            this.checkBox_auto.AutoSize = true;
            this.checkBox_auto.Location = new System.Drawing.Point(302, 9);
            this.checkBox_auto.Name = "checkBox_auto";
            this.checkBox_auto.Size = new System.Drawing.Size(72, 16);
            this.checkBox_auto.TabIndex = 36;
            this.checkBox_auto.Text = "自动开始";
            this.checkBox_auto.UseVisualStyleBackColor = true;
            // 
            // button_remove
            // 
            this.button_remove.Location = new System.Drawing.Point(285, 361);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(75, 22);
            this.button_remove.TabIndex = 37;
            this.button_remove.Text = "删除选中项";
            this.button_remove.UseVisualStyleBackColor = true;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // listView2
            // 
            this.listView2.AllowColumnReorder = true;
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView2.HoverSelection = true;
            this.listView2.Location = new System.Drawing.Point(642, 33);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(355, 167);
            this.listView2.TabIndex = 38;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "类型";
            this.columnHeader5.Width = 51;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "网址";
            this.columnHeader6.Width = 180;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "章节名称";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "图片序号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(640, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 39;
            this.label1.Text = "错误列表";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(642, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 40;
            this.button1.Text = "<<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_out
            // 
            this.textBox_out.Location = new System.Drawing.Point(642, 235);
            this.textBox_out.Multiline = true;
            this.textBox_out.Name = "textBox_out";
            this.textBox_out.ReadOnly = true;
            this.textBox_out.Size = new System.Drawing.Size(355, 182);
            this.textBox_out.TabIndex = 41;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(770, 206);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 23);
            this.button4.TabIndex = 42;
            this.button4.Text = "删除";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(898, 206);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(99, 23);
            this.button7.TabIndex = 43;
            this.button7.Text = "清空错误";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 423);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox_out);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.button_remove);
            this.Controls.Add(this.checkBox_auto);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox_path);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Label label5;
        private System.ComponentModel.BackgroundWorker bgWorker1;
        private System.ComponentModel.BackgroundWorker bgWorker3;
        private System.ComponentModel.BackgroundWorker bgWorker2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_bg_1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_bg_2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label_bg_3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_path;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.CheckBox checkBox_auto;
        private System.Windows.Forms.Button button_remove;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_out;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button7;
    }
}

