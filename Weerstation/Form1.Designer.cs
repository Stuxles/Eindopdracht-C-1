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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
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
            this.Opties = new System.Windows.Forms.TabPage();
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
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Plaats = new System.Windows.Forms.TextBox();
            this.Interval = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.Actueel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Trend.SuspendLayout();
            this.Opties.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Actueel);
            this.tabControl1.Controls.Add(this.Trend);
            this.tabControl1.Controls.Add(this.Opties);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(409, 311);
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
            this.Actueel.Location = new System.Drawing.Point(4, 22);
            this.Actueel.Name = "Actueel";
            this.Actueel.Padding = new System.Windows.Forms.Padding(3);
            this.Actueel.Size = new System.Drawing.Size(401, 285);
            this.Actueel.TabIndex = 0;
            this.Actueel.Text = "Actueel";
            this.Actueel.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Wind:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Luchtvochtigheid:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Temperatuur:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.InitialImage = global::Weerstation.Properties.Resources._01d;
            this.pictureBox1.Location = new System.Drawing.Point(15, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(192, 269);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(203, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "LastUpdate";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Wind";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lucht";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Temp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Weer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plaats";
            // 
            // Trend
            // 
            this.Trend.Controls.Add(this.chart1);
            this.Trend.Location = new System.Drawing.Point(4, 22);
            this.Trend.Name = "Trend";
            this.Trend.Padding = new System.Windows.Forms.Padding(3);
            this.Trend.Size = new System.Drawing.Size(401, 285);
            this.Trend.TabIndex = 1;
            this.Trend.Text = "Trend";
            this.Trend.UseVisualStyleBackColor = true;
            // 
            // Opties
            // 
            this.Opties.Controls.Add(this.label13);
            this.Opties.Controls.Add(this.radioButton2);
            this.Opties.Controls.Add(this.radioButton1);
            this.Opties.Controls.Add(this.Interval);
            this.Opties.Controls.Add(this.Plaats);
            this.Opties.Controls.Add(this.label12);
            this.Opties.Controls.Add(this.label11);
            this.Opties.Controls.Add(this.label10);
            this.Opties.Location = new System.Drawing.Point(4, 22);
            this.Opties.Name = "Opties";
            this.Opties.Padding = new System.Windows.Forms.Padding(3);
            this.Opties.Size = new System.Drawing.Size(401, 285);
            this.Opties.TabIndex = 2;
            this.Opties.Text = "Opties";
            this.Opties.UseVisualStyleBackColor = true;
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
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.overToolStripMenuItem,
            this.toolStripSeparator1,
            this.verversenToolStripMenuItem,
            this.toolStripSeparator2,
            this.optiesToolStripMenuItem,
            this.toolStripSeparator3,
            this.openenToolStripMenuItem,
            this.sluitenToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 132);
            // 
            // overToolStripMenuItem
            // 
            this.overToolStripMenuItem.Name = "overToolStripMenuItem";
            this.overToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.overToolStripMenuItem.Text = "Over";
            this.overToolStripMenuItem.Click += new System.EventHandler(this.overToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // verversenToolStripMenuItem
            // 
            this.verversenToolStripMenuItem.Name = "verversenToolStripMenuItem";
            this.verversenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.verversenToolStripMenuItem.Text = "Verversen";
            this.verversenToolStripMenuItem.Click += new System.EventHandler(this.verversenToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // optiesToolStripMenuItem
            // 
            this.optiesToolStripMenuItem.Name = "optiesToolStripMenuItem";
            this.optiesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.optiesToolStripMenuItem.Text = "Opties";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // openenToolStripMenuItem
            // 
            this.openenToolStripMenuItem.Name = "openenToolStripMenuItem";
            this.openenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openenToolStripMenuItem.Text = "Openen";
            this.openenToolStripMenuItem.Click += new System.EventHandler(this.openenToolStripMenuItem_Click);
            // 
            // sluitenToolStripMenuItem
            // 
            this.sluitenToolStripMenuItem.Name = "sluitenToolStripMenuItem";
            this.sluitenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sluitenToolStripMenuItem.Text = "Sluiten";
            this.sluitenToolStripMenuItem.Click += new System.EventHandler(this.sluitenToolStripMenuItem_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Location = new System.Drawing.Point(6, 6);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(389, 276);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title2.Alignment = System.Drawing.ContentAlignment.TopCenter;
            title2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
            title2.Name = "Title1";
            title2.Text = "Gemiddelde temperatuur";
            this.chart1.Titles.Add(title2);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Plaats";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(40, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Interval";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(40, 139);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Weergave";
            // 
            // Plaats
            // 
            this.Plaats.Location = new System.Drawing.Point(103, 80);
            this.Plaats.Name = "Plaats";
            this.Plaats.Size = new System.Drawing.Size(196, 20);
            this.Plaats.TabIndex = 3;
            this.Plaats.Text = "Emmen";
            // 
            // Interval
            // 
            this.Interval.Location = new System.Drawing.Point(103, 109);
            this.Interval.Name = "Interval";
            this.Interval.Size = new System.Drawing.Size(31, 20);
            this.Interval.TabIndex = 4;
            this.Interval.Text = "60";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(103, 135);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(31, 17);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.Text = "F";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(140, 135);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(36, 17);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "°C";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(140, 117);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 12);
            this.label13.TabIndex = 7;
            this.label13.Text = "(In secs.)";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Weerstation.Properties.Resources.spots_background_light_circles_69100;
            this.ClientSize = new System.Drawing.Size(434, 336);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Stenden Weerstation";
            this.tabControl1.ResumeLayout(false);
            this.Actueel.ResumeLayout(false);
            this.Actueel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Trend.ResumeLayout(false);
            this.Opties.ResumeLayout(false);
            this.Opties.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
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
        private System.Windows.Forms.TextBox Interval;
        private System.Windows.Forms.TextBox Plaats;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer timer1;
    }
}

