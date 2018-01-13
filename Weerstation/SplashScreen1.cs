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
    public partial class SplashScreen1 : Form
    {
        private int _splashTimer = 0;
        public SplashScreen1()
        {
            InitializeComponent();
            CenterToScreen();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _splashTimer++;
            if (_splashTimer == 25)
            {
                timer1.Stop();
                new Form1().Show();
                this.Hide();
            }
        }
    }
}
