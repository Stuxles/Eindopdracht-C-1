using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services;
using System.Windows.Forms;
using Newtonsoft.Json;
using Weerstation.Weather;

namespace Weerstation
{
    public partial class Form1 : Form
    {
        private int _weatherTimer = 0;
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
            timer1.Start();
            UpdateWeather();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _weatherTimer++;
            if (_weatherTimer == Int32.Parse(Interval.Text) * 10)
            {
                UpdateWeather();
            }
        }

        private void UpdateWeather()
        {
            Weather.WebService1 service = new Weather.WebService1();
            String[] cWeather = service.CurrentWeather(Plaats.Text);
            label1.Text = cWeather[0];
            label2.Text = cWeather[1];
            if (radioButton1.Checked)
            {
                double fahrint = Convert.ToInt32(double.Parse(cWeather[2]) * 1.8 + 32);
                label3.Text = fahrint + " F";
            }
            if (radioButton2.Checked)
            {
                int celcius = Convert.ToInt32(double.Parse(cWeather[2]));
                label3.Text = celcius + " °C";
            }
            label4.Text = cWeather[3]+"%";
            label5.Text = cWeather[4]+"km/h";
            pictureBox1.ImageLocation = cWeather[5];
            label6.Text = "(Laatste update: " + DateTime.Now.ToLongTimeString() + ")";
                _weatherTimer = 0;
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

        private void verversenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateWeather();
        }
    }
}
