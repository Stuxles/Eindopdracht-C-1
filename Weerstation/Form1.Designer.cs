namespace Weerstation
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Actueel = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Trend = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Opties = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.Plaats = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.overToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.verversenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.optiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.openenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sluitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.Interval = new System.Windows.Forms.NumericUpDown();
            this.tabControl1.SuspendLayout();
            this.Actueel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Trend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.Opties.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Interval)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Actueel);
            this.tabControl1.Controls.Add(this.Trend);
            this.tabControl1.Controls.Add(this.Opties);
            this.tabControl1.Location = new System.Drawing.Point(17, 16);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(545, 383);
            this.tabControl1.TabIndex = 0;
            // 
            // Actueel
            // 
            this.Actueel.Controls.Add(this.label9);
            this.Actueel.Controls.Add(this.label8);
            this.Actueel.Controls.Add(this.label7);
            this.Actueel.Controls.Add(this.pictureBox1);
            this.Actueel.Controls.Add(this.label6);
            this.Actueel.Controls.Add(this.label5);
            this.Actueel.Controls.Add(this.label4);
            this.Actueel.Controls.Add(this.label3);
            this.Actueel.Controls.Add(this.label2);
            this.Actueel.Controls.Add(this.label1);
            this.Actueel.Location = new System.Drawing.Point(4, 25);
            this.Actueel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Actueel.Name = "Actueel";
            this.Actueel.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Actueel.Size = new System.Drawing.Size(537, 354);
            this.Actueel.TabIndex = 0;
            this.Actueel.Text = "Actueel";
            this.Actueel.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 188);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "Wind:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 153);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Luchtvochtigheid:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 117);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Temperatuur:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.InitialImage = global::Weerstation.Properties.Resources._01d;
            this.pictureBox1.Location = new System.Drawing.Point(20, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 62);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(256, 331);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(271, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "LastUpdate";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 188);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Wind";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 153);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lucht";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Temp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Weer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plaats";
            // 
            // Trend
            // 
            this.Trend.Controls.Add(this.chart1);
            this.Trend.Location = new System.Drawing.Point(4, 25);
            this.Trend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Trend.Name = "Trend";
            this.Trend.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Trend.Size = new System.Drawing.Size(537, 354);
            this.Trend.TabIndex = 1;
            this.Trend.Text = "Trend";
            this.Trend.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(8, 7);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(519, 340);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title1.Alignment = System.Drawing.ContentAlignment.TopCenter;
            title1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
            title1.Name = "Title1";
            title1.Text = "Gemiddelde temperatuur";
            this.chart1.Titles.Add(title1);
            // 
            // Opties
            // 
            this.Opties.Controls.Add(this.Interval);
            this.Opties.Controls.Add(this.label13);
            this.Opties.Controls.Add(this.radioButton2);
            this.Opties.Controls.Add(this.radioButton1);
            this.Opties.Controls.Add(this.Plaats);
            this.Opties.Controls.Add(this.label12);
            this.Opties.Controls.Add(this.label11);
            this.Opties.Controls.Add(this.label10);
            this.Opties.Location = new System.Drawing.Point(4, 25);
            this.Opties.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Opties.Name = "Opties";
            this.Opties.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Opties.Size = new System.Drawing.Size(537, 354);
            this.Opties.TabIndex = 2;
            this.Opties.Text = "Opties";
            this.Opties.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(187, 144);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 15);
            this.label13.TabIndex = 7;
            this.label13.Text = "(In secs.)";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(187, 166);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(44, 21);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "°C";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(137, 166);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(37, 21);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.Text = "F";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Plaats
            // 
            this.Plaats.Location = new System.Drawing.Point(137, 98);
            this.Plaats.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Plaats.Name = "Plaats";
            this.Plaats.Size = new System.Drawing.Size(260, 22);
            this.Plaats.TabIndex = 3;
            this.Plaats.Text = "Emmen";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(53, 171);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 17);
            this.label12.TabIndex = 2;
            this.label12.Text = "Weergave";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(53, 143);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "Interval";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(53, 107);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Plaats";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Stenden Weerstation";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.overToolStripMenuItem,
            this.toolStripSeparator1,
            this.verversenToolStripMenuItem,
            this.toolStripSeparator2,
            this.optiesToolStripMenuItem,
            this.toolStripSeparator3,
            this.openenToolStripMenuItem,
            this.sluitenToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(261, 171);
            // 
            // overToolStripMenuItem
            // 
            this.overToolStripMenuItem.Name = "overToolStripMenuItem";
            this.overToolStripMenuItem.Size = new System.Drawing.Size(260, 24);
            this.overToolStripMenuItem.Text = "Over";
            this.overToolStripMenuItem.Click += new System.EventHandler(this.overToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(257, 6);
            // 
            // verversenToolStripMenuItem
            // 
            this.verversenToolStripMenuItem.Name = "verversenToolStripMenuItem";
            this.verversenToolStripMenuItem.Size = new System.Drawing.Size(260, 24);
            this.verversenToolStripMenuItem.Text = "Verversen";
            this.verversenToolStripMenuItem.Click += new System.EventHandler(this.verversenToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(257, 6);
            // 
            // optiesToolStripMenuItem
            // 
            this.optiesToolStripMenuItem.Name = "optiesToolStripMenuItem";
            this.optiesToolStripMenuItem.Size = new System.Drawing.Size(260, 24);
            this.optiesToolStripMenuItem.Text = "Opties";
            this.optiesToolStripMenuItem.Click += new System.EventHandler(this.optiesToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(257, 6);
            // 
            // openenToolStripMenuItem
            // 
            this.openenToolStripMenuItem.Name = "openenToolStripMenuItem";
            this.openenToolStripMenuItem.Size = new System.Drawing.Size(260, 24);
            this.openenToolStripMenuItem.Text = "Openen";
            this.openenToolStripMenuItem.Click += new System.EventHandler(this.openenToolStripMenuItem_Click);
            // 
            // sluitenToolStripMenuItem
            // 
            this.sluitenToolStripMenuItem.Name = "sluitenToolStripMenuItem";
            this.sluitenToolStripMenuItem.Size = new System.Drawing.Size(260, 24);
            this.sluitenToolStripMenuItem.Text = "Sluiten";
            this.sluitenToolStripMenuItem.Click += new System.EventHandler(this.sluitenToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.ReadOnly = true;
            this.toolStripTextBox1.Size = new System.Drawing.Size(200, 27);
            this.toolStripTextBox1.Text = "Temp";
            // 
            // Interval
            // 
            this.Interval.Location = new System.Drawing.Point(137, 138);
            this.Interval.Name = "Interval";
            this.Interval.Size = new System.Drawing.Size(51, 22);
            this.Interval.TabIndex = 8;
            this.Interval.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Weerstation.Properties.Resources.spots_background_light_circles_69100;
            this.ClientSize = new System.Drawing.Size(579, 414);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Stenden Weerstation";
            this.tabControl1.ResumeLayout(false);
            this.Actueel.ResumeLayout(false);
            this.Actueel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Trend.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.Opties.ResumeLayout(false);
            this.Opties.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Interval)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Actueel;
        private System.Windows.Forms.TabPage Trend;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem overToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem verversenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem optiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem openenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sluitenToolStripMenuItem;
        private System.Windows.Forms.TabPage Opties;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox Plaats;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.NumericUpDown Interval;
    }
}

