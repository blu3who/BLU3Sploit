using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fusion;

namespace BLU3Sploit
{
    public partial class getkey : Form
    {
        private static FusionApp App = new FusionApp("1302967");

        public getkey()
        {
            InitializeComponent();
        }

        private async void LoginBTN_Click(object sender, EventArgs e)
        {
            {
                var registerResponse = await App.Register(user.Text, pass.Text, key.Text);
                if (registerResponse.Error == false)
                {
                    // Successfully registered
                    MessageBox.Show(registerResponse.Message, "BLU3");
                }
                else
                {
                    // Failed register
                    MessageBox.Show(registerResponse.Message, "BLU3");
                }
            }
        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Hide();
            new Key().Show();
        }
    }
}
