using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Net;
using System.IO;

namespace WordJumble
{
    public partial class WordJumblePro : Form
    {
        Playing fPlay;
        public WordJumblePro()
        {
            InitializeComponent();

            if (File.Exists("WordJumble.wjdb"))
            {
                //GET DATE OF DATABASE
                using (FileStream fs = new FileStream("WordJumble.wjdb", FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    StreamReader sReader = new StreamReader(fs);
                    WordJumble.Properties.Settings.Default.dbDate = sReader.ReadLine().Substring(9, 11);
                    WordJumble.Properties.Settings.Default.Save();
                }
            }
            else
            {
                MessageBox.Show("Database not found", "WordJumble", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
        }

        private void ResetHelp()
        {
            this.lblHelp.Text = "WORD JUMBLE 1.0 \n © Tran Phuc Tho \n 2011";
        }

        #region MENU
        private void mnuUpdate_Click(object sender, EventArgs e)
        {            
            WebClient web = new WebClient();
            string dbDate, dbDateCurrent = null;
            try
            {
                dbDate = web.DownloadString("http://www.singlestar.tk/wordjumble/version.txt").Trim();
                dbDateCurrent = WordJumble.Properties.Settings.Default.dbDate.Trim();

                if (dbDateCurrent == dbDate)
                {
                    MessageBox.Show("Database is up to date", "WordJumble", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    web.DownloadFileAsync(new Uri("http://www.singlestar.tk/wordjumble/WordJumble-" + dbDate.Substring(0, 2) + dbDate.Substring(3, 2) + dbDate.Substring(6)), "WordJumbleTemp.wjdb");
                }

                web.DownloadProgressChanged += new DownloadProgressChangedEventHandler(web_DownloadProgressChanged);
                web.DownloadFileCompleted += new AsyncCompletedEventHandler(web_DownloadFileCompleted);
            }
            catch (WebException)
            {
                MessageBox.Show("Please check your network connection", "WordJumble", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void web_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            MessageBox.Show("Working..." + e.ProgressPercentage + "%", "Update Database", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void web_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            File.Delete("WordJumble.wjdb");
            File.Move("WordJumbleTemp.wjdb", "WordJumble.wjdb"); //Database rename
            MessageBox.Show("Update completed.", "WordJumble", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Author: Tran Phuc Tho (ITExplore)\nVersion: 1.0\nDatabase: " + WordJumble.Properties.Settings.Default.dbDate + "\nEmail: ITExplore09@yahoo.com.vn\nWebsite: http://wwww.singlestar.tk", 
                "About Author", MessageBoxButtons.OK, MessageBoxIcon.Information
                );
        }
        #endregion

        #region BUTTON CLICK
        private void lblBeginner_Click(object sender, EventArgs e)
        {
            this.Hide();

            // SET UP
            WordJumble.Properties.Settings.Default.Mode = "Beginner";
            WordJumble.Properties.Settings.Default.ModeLastest = false;
            fPlay = new Playing();
            fPlay.Show();            
        }

        private void lblAverage_Click(object sender, EventArgs e)
        {
            this.Hide();

            // SET UP
            WordJumble.Properties.Settings.Default.Mode = "Average";
            WordJumble.Properties.Settings.Default.ModeLastest = false;
            fPlay = new Playing();
            fPlay.Show();            
        }

        private void lblExpert_Click(object sender, EventArgs e)
        {
            this.Hide();

            // SET UP
            WordJumble.Properties.Settings.Default.Mode = "Expert";
            WordJumble.Properties.Settings.Default.ModeLastest = false;
            fPlay = new Playing();
            fPlay.Show();            
        }

        private void lblTimeTrial_Click(object sender, EventArgs e)
        {
            this.Hide();

            // SET UP
            WordJumble.Properties.Settings.Default.Mode = "Time Limited";
            WordJumble.Properties.Settings.Default.ModeLastest = false;
            fPlay = new Playing();
            fPlay.Show();            
        }

        private void lblLastest_Click(object sender, EventArgs e)
        {
            mnuLastestPlay.Show(lblLastest, 1, 1);
        }

        private void lblHighScores_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"Scores\Beginner.wjhs") || File.Exists(@"Scores\Average.wjhs") || File.Exists(@"Scores\Expert.wjhs") || File.Exists(@"Scores\TimeLimited.wjhs"))
            {
                ScoresTable score = new ScoresTable();
                score.ShowDialog();
            }
            else
            {
                MessageBox.Show("No record found", "WordJumble", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lblOptions_Click(object sender, EventArgs e)
        {
            Options options = new Options();
            options.ShowDialog();            
        }
        #endregion

        #region DISPLAY HELP

        private void lblBeginner_MouseMove(object sender, MouseEventArgs e)
        {
            this.lblHelp.Text = "Beginner: Player will guess 7 times. If wrong 7 times, game will over. \n Mark: \n -Correct: 2 Point \n -Missed: -1 Point \n -Bonus: 4 Point";
        }

        private void lblBeginner_MouseLeave(object sender, EventArgs e)
        {
            ResetHelp();
        }

        private void lblAverage_MouseMove(object sender, MouseEventArgs e)
        {
            this.lblHelp.Text = "Average: Player will guess 5 times. If wrong 5 times, game will over. \n Mark: \n -Correct: 4 Point \n -Missed: -2 Point \n -Bonus: 8 Point";
        }
        
        private void lblAverage_MouseLeave(object sender, EventArgs e)
        {
            ResetHelp();
        }

        private void lblExpert_MouseMove(object sender, MouseEventArgs e)
        {
            this.lblHelp.Text = "Expert: Player will guess 3 times. If wrong 3 times, game will over. \n Mark: \n -Correct: 6 Point \n -Missed: -3 Point \n -Bonus: 16 Point";
        }

        private void lblExpert_MouseLeave(object sender, EventArgs e)
        {
            ResetHelp();
        }

        private void lblTimeTrial_MouseMove(object sender, MouseEventArgs e)
        {
            this.lblHelp.Text = "Time Trial: Player have " + WordJumble.Properties.Settings.Default.TimeLimited + " seconds (Can set up in Options dialog).\n If wrong 7 times or timeout, game will over. \n Mark: \n -Correct: 8 Point \n -Missed: -4 Point \n Bonus: 20 Point";
        }

        private void lblTimeTrial_MouseLeave(object sender, EventArgs e)
        {
            ResetHelp();
        }

        private void lblLastest_MouseMove(object sender, MouseEventArgs e)
        {
            this.lblHelp.Text = "Play lastest game that you save before or Load games that you saved";
        }

        private void lblLastest_MouseLeave(object sender, EventArgs e)
        {
            ResetHelp();
        }

        private void lblHighScores_MouseMove(object sender, MouseEventArgs e)
        {
            this.lblHelp.Text = "High Scores";
        }

        private void lblHighScores_MouseLeave(object sender, EventArgs e)
        {
            ResetHelp();
        }

        private void lblOptions_MouseMove(object sender, MouseEventArgs e)
        {
            this.lblHelp.Text = "Options: Program's settings. For example: game's sound, music,...";
        }

        private void lblOptions_MouseLeave(object sender, EventArgs e)
        {
            ResetHelp();
        }
        #endregion

        private void mnuLastest_Click(object sender, EventArgs e)
        {
            if (WordJumble.Properties.Settings.Default.ModeLastest)
            {
                this.Hide();
                // SET UP
                WordJumble.Properties.Settings.Default.Mode = WordJumble.Properties.Settings.Default.Mode4Resume;
                fPlay = new Playing();
                fPlay.Show();
            }
            else
            {
                MessageBox.Show("You aren't save before. So, You cann't use this mode", "WordJumble", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void mnuLoadGame_Click(object sender, EventArgs e)
        {
            OpenFileDialog load = new OpenFileDialog();
            load.Filter = "WordJumble Saved|*.wjsav";
            load.Title = "WordJumble Loading Game";

            if (load.ShowDialog() == DialogResult.OK)
            {
                LoadGame.Process(load.FileName);                
                this.Hide();
                
                fPlay = new Playing();
                fPlay.Show();
            }
        }

        private void WordJumblePro_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
    }
}
