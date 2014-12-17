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
    public partial class SaveScores : Form
    {
        public SaveScores()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Length >= 5)
            {
                HighestScores hscObject = new HighestScores(txtName.Text, SaveScoresSettings.Point, SaveScoresSettings.Bonus, SaveScoresSettings.Missed, SaveScoresSettings.Time);
                hscObject.AddScores();
                if (!hscObject.IsExist())
                {
                    hscObject.CreateFile();
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Name should be greater or equal 5", "WordJumble", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
