using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataSaving;
using Fusion;
using System.Diagnostics;

namespace BLU3Sploit
{
    public partial class Key : Form
    {
        public Key()
        {
            InitializeComponent();
        }

        private static FusionApp App = new FusionApp("1302967");
        private static SettingsModel Settings = SettingsManager.Load();
        private static string currentVersion = "1.0";
        private static string liveVersion;
        private static string updateurl;

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            var loginResponse = await App.Login(LoginBTN.Text, "");
            if (loginResponse.Error == false)
            {
                try
                {
                    liveVersion = await FusionApp.GetAppVar("version");
                    updateurl = await FusionApp.GetAppVar("updateurl");

                    if (!string.Equals(currentVersion, liveVersion))
                    {
                        DialogResult dialogResult = MessageBox.Show("There is a new update would you like to download it?", "BLU3", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            Process.Start(updateurl);
                            Application.Exit();
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Failed to get update!", "BLU3");
                }

                Hide();
                new BLU3Sploit().Show();
            }
            else
            {
                MessageBox.Show(loginResponse.Message, "BLU3");
            }
        }

        private void key1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Key_Load(object sender, EventArgs e)
        {
            if (Settings.SaveMyLogin)
            {
                username.Text = Settings.Username;
                password.Text = Settings.Password;
                SaveMyLoginSiwtch.Checked = true;
            }
        }

        private async void LoginBTN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(username.Text) || string.IsNullOrWhiteSpace(password.Text)) return;

            var loginResponse = await App.Login(username.Text, password.Text, "", false, false);
            if (loginResponse.Error == false)
            {
                if (SaveMyLoginSiwtch.Checked)
                {
                    Settings.Username = username.Text;
                    Settings.Password = password.Text;
                    Settings.Save();
                }
                // Successful login
                new BLU3Sploit().Show();
                Hide();

            }
            else
            {
                // Failed login
                MessageBox.Show(loginResponse.Message, "BLU3");
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Hide();
            new getkey().Show();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
