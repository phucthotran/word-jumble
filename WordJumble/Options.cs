using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WordJumble
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
            rdOn.Checked = WordJumble.Properties.Settings.Default.SoundOn;
            rdOff.Checked = WordJumble.Properties.Settings.Default.SoundOff;
            numTimeLimited.Value = WordJumble.Properties.Settings.Default.TimeLimited;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();            
        }

        private void Options_FormClosing(object sender, FormClosingEventArgs e)
        {
            WordJumble.Properties.Settings.Default.SoundOn = rdOn.Checked;
            WordJumble.Properties.Settings.Default.SoundOff = rdOff.Checked;
            WordJumble.Properties.Settings.Default.TimeLimited = (int)numTimeLimited.Value;
            WordJumble.Properties.Settings.Default.Save();
        }
    }
}
