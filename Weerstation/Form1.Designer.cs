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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Actueel = new System.Windows.Forms.TabPage();
            this.Trend = new System.Windows.Forms.TabPage();
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
            this.Opties = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.Actueel.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // Trend
            // 
            this.Trend.Location = new System.Drawing.Point(4, 22);
            this.Trend.Name = "Trend";
            this.Trend.Padding = new System.Windows.Forms.Padding(3);
            this.Trend.Size = new System.Drawing.Size(401, 285);
            this.Trend.TabIndex = 1;
            this.Trend.Text = "Trend";
            this.Trend.UseVisualStyleBackColor = true;
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
            // Opties
            // 
            this.Opties.Location = new System.Drawing.Point(4, 22);
            this.Opties.Name = "Opties";
            this.Opties.Padding = new System.Windows.Forms.Padding(3);
            this.Opties.Size = new System.Drawing.Size(401, 285);
            this.Opties.TabIndex = 2;
            this.Opties.Text = "Opties";
            this.Opties.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(137, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(137, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "label6";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(18, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
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
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
    }
}

