using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLU3Sploit.Properties;
using DataSaving;

namespace BLU3Sploit
{
    public partial class SubOptions : Form
    {
        private static SettingsModel Settings = SettingsManager.Load();
        public SubOptions()
        {
            InitializeComponent();
        }

        private void TopmostBTN_Click(object sender, EventArgs e)
        {

        }

        private void SubOptions_Load(object sender, EventArgs e)
        {

        }
    }
}
