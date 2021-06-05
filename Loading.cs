using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLU3Sploit
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            {
                if (this.Opacity == 1)
                {
                    timer1.Stop();
                }
                this.Opacity += 0.28;
                new Key().Show();
                Hide();
            }
        }
    }
}
