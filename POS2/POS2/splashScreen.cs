using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace POS2
{
    public partial class splashScreen : Form
    {

        private void splashScreen_Load(object sender, EventArgs e)
        {

        }

        public int timerVar = 0;

        public splashScreen()
        {
            InitializeComponent();
        }

        private void loadingTimer_Tick_1(object sender, EventArgs e)
        {
            timerVar++;
            if (timerVar <= 100)
            {
                this.Text = "Loading (" + timerVar + "%)";
                loadingBar.Value = timerVar;
            }
            else if (timerVar < 120)
            {
                this.Opacity--;
            }
            else if (timerVar > 120)
            {
                this.Close();
            }
        }

    }
}
