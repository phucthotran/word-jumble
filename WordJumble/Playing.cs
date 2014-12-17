using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Media;
using System.IO;

namespace WordJumble
{
    public partial class Playing : Form
    {
        private int missed = 0;
        private int point = 0;
        private int winTimes = 0;
        private int bonus = 0;
        private int time = 0;
        private int totalWin = 0;
        private int hintTime = 2;
        private int changeTime = 2;
        private int reduceTime = 2;
        private string mode = null;
        private SoundPlayer sound;
        
        public Playing()
        {
            InitializeComponent();
            PlayMode = WordJumble.Properties.Settings.Default.Mode;
            TimeLimit = WordJumble.Properties.Settings.Default.TimeLimited;

            this.Text += " (" + PlayMode + " Mode)";
            lblMode.Text = PlayMode;            
        }
                
        public int Point { get { return point; } set { point = value; } }
        public int Bonus { get { return bonus; } set { bonus = value; } }
        public int Missed { get { return missed; } set { missed = value; } }
        public int TimeLimit { get { return time; } set { time = value; } }
        public int TotalWin { get { return totalWin; } set { totalWin = value; } }
        public int WinTimes { get { return winTimes; } set { winTimes = value; } }
        public int ChangeQuestionLimit { get { return changeTime; } set { changeTime = value; } }
        public int ReduceLimit { get { return reduceTime; } set { reduceTime = value; } }
        public int HintLimit { get { return hintTime; } set { hintTime = value; } }
        public string PlayMode { get { return mode; } set { mode = value; } }

        #region METHOD
        private void ResetHelp()
        {
            lblHelp.Text = null;
        }

        private bool IsSoundOn()
        {
            if (WordJumble.Properties.Settings.Default.SoundOn)
            {
                return true;
            }
            return false;
        }

        private void CheckMode()
        {
            switch (PlayMode)
            {
                case "Beginner":
                    ModeSettings.SetUp(10, 7, 2, 4, 1);
                    ModeSettings.SaveSettings();
                    break;
                case "Average":
                    ModeSettings.SetUp(20, 5, 4, 8, 2);
                    ModeSettings.SaveSettings();                    
                    break;
                case "Expert":
                    ModeSettings.SetUp(30, 3, 6, 16, 3);
                    ModeSettings.SaveSettings();
                    break;
                case "Time Limited":
                    ModeSettings.SetUp(20, 7, 8, 20, 4);
                    ModeSettings.SaveSettings();    
                    timeCount.Start();
                    break;                
            }
        }

        private void QuestionLoading()
        {
            lblHintWord.Text = null;
            QuestionGeneration qgObject = new QuestionGeneration();
            qgObject.GetQuestion();
            txtQuestion.Text = null;

            for (int i = 0; i < qgObject.ArrQuestion.Count; i++)
            {
                txtQuestion.Text += (i + 1) + ". " + qgObject.ArrQuestion[i] + "\r\n";
            }
            txtQuestion.Text.TrimEnd();
        }

        private void ResetData()
        {
            Missed = 0;
            WinTimes = 0;
            TimeLimit = WordJumble.Properties.Settings.Default.TimeLimited;
            Point = 0;
            Bonus = 0;
            progBonus.Value = 0;
            lblWinTimes.Text = "Total Win: 0";
            lblMissed.Text = "Missed: 0";
            lblBonus.Text = "Bonus: 0";
            lblPoint.Text = "Point: 0";
            if (PlayMode == "Time Limited")
            {
                timeCount.Start();
            }
            QuestionLoading();
        }

        private void CheckQuestion()
        {
            QuestionGeneration qgObject = new QuestionGeneration();

            string s = null;
            s = txtAnswer.Text.TrimStart();
            if (s.TrimEnd() == qgObject.Answer)
            {                
                if (IsSoundOn()) { sound = new SoundPlayer("win.wav"); sound.Play(); }
                Point += ModeSettings.WinPoint;
                WinTimes++;
                TotalWin++;
                lblPoint.Text = "Point: " + Point;
                lblWinTimes.Text = "Total Win: " + TotalWin;                
                txtAnswer.Clear();
                progBonus.PerformStep(); //Increment 10
                if (WinTimes == ModeSettings.WinTimesToBonus)
                {
                    WinTimes = 0;
                    progBonus.Value = 0;
                    Bonus += ModeSettings.BonusPoint;
                    lblBonus.Text = "Bonus: " + Bonus;
                }
                QuestionLoading();
                TimeLimit = WordJumble.Properties.Settings.Default.TimeLimited;
            }
            else
            {
                if (Missed < ModeSettings.WrongTimesLimit)
                {
                    if (IsSoundOn()) { sound = new SoundPlayer("lose.wav"); sound.Play(); }
                    if (point > 0)
                    {
                        Point -= ModeSettings.SubtractPoint;
                    }
                    Missed++;
                    WinTimes = 0;
                    progBonus.Value = 0;
                    lblMissed.Text = "Missed: " + Missed;
                    lblPoint.Text = "Point: " + Point;
                    MessageBox.Show("Please try again");
                }
                else
                {
                    DialogResult dg = MessageBox.Show("You lose. Are you wanna try again", "WordJumble", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dg == DialogResult.Yes)
                    {
                        ResetData();
                    }
                    else
                    {
                        WordJumblePro fMain = new WordJumblePro();
                        fMain.Show(); 
                    }
                }
            }
        }
        #endregion

        private void Playing_FormClosed(object sender, FormClosedEventArgs e)
        {
            WordJumblePro fMain = new WordJumblePro();
            fMain.Show();
        }        

        private void Playing_Load(object sender, EventArgs e)
        {
            CheckMode();
            QuestionLoading();
            if (WordJumble.Properties.Settings.Default.ModeLastest)
            {
                ResumeSettings.SetUp();
                Bonus = ResumeSettings.Bonus;
                Point = ResumeSettings.Point;
                Missed = ResumeSettings.Missed;
                TotalWin = ResumeSettings.TotalWin;
                WinTimes = ResumeSettings.WinTimes;
                progBonus.Value = ResumeSettings.PrepareBonus;
                HintLimit = ResumeSettings.HintLimit;
                ChangeQuestionLimit = ResumeSettings.ChangeQuestionLimit;
                ReduceLimit = ResumeSettings.ReduceLimit;

                lblMissed.Text = "Missed: " + Missed;
                lblBonus.Text = "Bonus: " + Bonus;
                lblPoint.Text = "Point: " + Point;
                lblWinTimes.Text = "Total Win: " + TotalWin;
            }
            progBonus.Maximum = WordJumble.Properties.Settings.Default.WinTimes * 10;
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {            
            CheckQuestion();
        }

        private void timeCount_Tick(object sender, EventArgs e)
        {
            if (TimeLimit == 0)
            {                
                TimeLimit = WordJumble.Properties.Settings.Default.TimeLimited;
                QuestionLoading();

                if (Missed < ModeSettings.WrongTimesLimit)
                {                
                    if (IsSoundOn())
                    {
                        sound = new SoundPlayer("lose.wav"); sound.Play();
                    }
                    if (Point > 0)
                    {
                        Point -= ModeSettings.SubtractPoint;
                    }
                    Missed++;
                    WinTimes = 0;
                    progBonus.Value = 0;
                    lblMissed.Text = "Missed: " + Missed;
                    lblPoint.Text = "Point: " + Point;
                }
                else if (Missed == ModeSettings.WrongTimesLimit)
                {
                    timeCount.Stop();
                    DialogResult dg = MessageBox.Show("You lose. Are you wanna try again", "WordJumble", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dg == DialogResult.Yes)
                    {
                        ResetData();
                    }
                    else
                    {
                        this.Close();

                        WordJumblePro fMain = new WordJumblePro();
                        fMain.Show();
                    }
                }
            }
            TimeLimit--;
            lblTime.Text = "Time Remain: " + TimeLimit;
        }

        private void Playing_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Missed < ModeSettings.WrongTimesLimit)
            {
                DialogResult dg = MessageBox.Show("Are you wanna save to play after (by Lastest Play mode)?", "Word Jumble", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dg == DialogResult.Yes)
                {
                    WordJumble.Properties.Settings.Default.Mode4Resume = PlayMode;
                    ResumeSettings.SetUp(Point, Bonus, Missed, WinTimes, TotalWin, progBonus.Value, HintLimit, ChangeQuestionLimit, ReduceLimit);
                    ResumeSettings.SaveSettings();
                    WordJumble.Properties.Settings.Default.ModeLastest = true;
                    WordJumble.Properties.Settings.Default.Save();
                }
                else
                {
                    WordJumble.Properties.Settings.Default.ModeLastest = false;
                }
            }
            timeCount.Stop();

            SaveScores scObject = new SaveScores();
            HighestScores hscObject = new HighestScores();
            if (Point > 5 && (hscObject.IsHighestScore(Point) || hscObject.IsTopTen() || !hscObject.IsExist()))
            {
                SaveScoresSettings.SetUp(TimeLimit, Point, Bonus, Missed);
                SaveScoresSettings.SaveSettings();

                scObject.ShowDialog();
            }            
        }

        private void lblReduce_Click(object sender, EventArgs e)
        {
            ReduceLimit--;
            if (ReduceLimit >= 0)
            {
                lblReduce.Enabled = false;
            }
            Point = Point / 2;
            lblPoint.Text = "Point: " + Point;
            QuestionLoading();
            TimeLimit = WordJumble.Properties.Settings.Default.TimeLimited;            
        }

        private void lblReduce_MouseMove(object sender, MouseEventArgs e)
        {
            lblHelp.Text = "Reduce 50% of Scores and Change another question";
        }

        private void lblReduce_MouseLeave(object sender, EventArgs e)
        {
            ResetHelp();
        }

        private void lblHint_Click(object sender, EventArgs e)
        {
            HintLimit--;
            if (HintLimit >= 0)
            {
                lblHint.Enabled = false;
            }
            if (Point > 0)
            {
                Point -= 2;                
            }
            lblPoint.Text = "Point: " + Point;

            int count = 0;
            QuestionGeneration qgObject = new QuestionGeneration();
            for (int i = 0; i < qgObject.Answer.Length; i++)
            {                
                if (qgObject.Answer[i] == ' ' && count != 2)
                {
                    count++;
                    lblHintWord.Text = "Hint: " + qgObject.Answer.Substring(0, i+1);
                }
            }
        }

        private void lblHint_MouseMove(object sender, MouseEventArgs e)
        {
            lblHelp.Text = "Hint 2 words and Subtract 2 Point";
        }

        private void lblHint_MouseLeave(object sender, EventArgs e)
        {
            ResetHelp();
        }

        private void lblChangeQuestion_Click(object sender, EventArgs e)
        {
            ChangeQuestionLimit--;
            if (ChangeQuestionLimit >= 0)
            {
                lblChangeQuestion.Enabled = false;
            }
            Point = 0;
            lblPoint.Text = "Point: " + Point;
            QuestionLoading();
            TimeLimit = WordJumble.Properties.Settings.Default.TimeLimited;
        }

        private void lblChangeQuestion_MouseMove(object sender, MouseEventArgs e)
        {
            lblHelp.Text = "Clear scores (Point) and Change Another Question";
        }

        private void lblChangeQuestion_MouseLeave(object sender, EventArgs e)
        {
            ResetHelp();
        }

        private void timeCheck_Tick(object sender, EventArgs e)
        {
            if (TotalWin >= 2 && HintLimit >= 1)
            {
                lblHint.Enabled = true;
                lblHelp.Text = null;
            }
            if (TotalWin >= 5 && ChangeQuestionLimit >= 1)
            {
                lblChangeQuestion.Enabled = true;
            }
            if (TotalWin >= 7 && ReduceLimit >= 1)
            {
                lblReduce.Enabled = true;
            }            
        }

        private void txtAnswer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void lblSave_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "WordJumble Saved|*.wjsav";
            save.Title = "WordJumble Save Game";
            save.FileName = dt.Month + "-" + dt.Day + "-" + dt.Year + "-" + PlayMode.Trim() + ".wjsav";

            if (save.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sWriter = new StreamWriter(save.FileName))
                {
                    sWriter.WriteLine("Mode: " + PlayMode);
                    sWriter.WriteLine("Point: " + Point);
                    sWriter.WriteLine("Missed: " + Missed);
                    sWriter.WriteLine("Bonus: " + Bonus);
                    sWriter.WriteLine("Total Win: " + TotalWin);
                    sWriter.WriteLine("Win Times: " + WinTimes);
                    sWriter.WriteLine("Prepare Bonus: " + progBonus.Value);
                    sWriter.WriteLine("Hint Limit: " + HintLimit);
                    sWriter.WriteLine("Change Question Limit: " + ChangeQuestionLimit);
                    sWriter.WriteLine("Reduce Limit: " + ReduceLimit);
                }
            }
        }
    }
}
