using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weerstation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
            
            
        }



        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Visible = false;
            }
        }

        private void openenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Visible == false)
            {
                this.Visible = true;
            }
        }

        private void sluitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void overToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.Show();
        }
    }
}
