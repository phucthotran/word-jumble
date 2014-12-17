namespace WordJumble
{
    partial class WordJumblePro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WordJumblePro));
            this.lblHelp = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblBeginner = new System.Windows.Forms.Label();
            this.lblExpert = new System.Windows.Forms.Label();
            this.lblTimeTrial = new System.Windows.Forms.Label();
            this.lblLastest = new System.Windows.Forms.Label();
            this.mnuLastestPlay = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuLastest = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLoadGame = new System.Windows.Forms.ToolStripMenuItem();
            this.lblHighScores = new System.Windows.Forms.Label();
            this.lblOptions = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            this.mnuLastestPlay.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHelp
            // 
            this.lblHelp.BackColor = System.Drawing.Color.Transparent;
            this.lblHelp.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelp.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblHelp.Location = new System.Drawing.Point(310, 189);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(215, 142);
            this.lblHelp.TabIndex = 6;
            this.lblHelp.Text = "WORD JUMBLE 1.0\r\n© Tran Phuc Tho\r\n2011";
            this.lblHelp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelp});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(784, 24);
            this.menu.TabIndex = 8;
            this.menu.Text = "menuStrip1";
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUpdate,
            this.mnuAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuHelp.Text = "Help";
            // 
            // mnuUpdate
            // 
            this.mnuUpdate.Image = global::WordJumble.Properties.Resources.update;
            this.mnuUpdate.Name = "mnuUpdate";
            this.mnuUpdate.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.mnuUpdate.Size = new System.Drawing.Size(205, 22);
            this.mnuUpdate.Text = "Update Database";
            this.mnuUpdate.Click += new System.EventHandler(this.mnuUpdate_Click);
            // 
            // mnuAbout
            // 
            this.mnuAbout.Image = global::WordJumble.Properties.Resources.about;
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.mnuAbout.Size = new System.Drawing.Size(205, 22);
            this.mnuAbout.Text = "About";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // lblAverage
            // 
            this.lblAverage.BackColor = System.Drawing.Color.Transparent;
            this.lblAverage.Image = global::WordJumble.Properties.Resources.ButtonAverage;
            this.lblAverage.Location = new System.Drawing.Point(283, 31);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(122, 143);
            this.lblAverage.TabIndex = 1;
            this.lblAverage.Click += new System.EventHandler(this.lblAverage_Click);
            this.lblAverage.MouseLeave += new System.EventHandler(this.lblAverage_MouseLeave);
            this.lblAverage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblAverage_MouseMove);
            // 
            // lblBeginner
            // 
            this.lblBeginner.BackColor = System.Drawing.Color.Transparent;
            this.lblBeginner.Image = global::WordJumble.Properties.Resources.ButtonBeginner;
            this.lblBeginner.Location = new System.Drawing.Point(182, 158);
            this.lblBeginner.Name = "lblBeginner";
            this.lblBeginner.Size = new System.Drawing.Size(122, 143);
            this.lblBeginner.TabIndex = 0;
            this.lblBeginner.Click += new System.EventHandler(this.lblBeginner_Click);
            this.lblBeginner.MouseLeave += new System.EventHandler(this.lblBeginner_MouseLeave);
            this.lblBeginner.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblBeginner_MouseMove);
            // 
            // lblExpert
            // 
            this.lblExpert.BackColor = System.Drawing.Color.Transparent;
            this.lblExpert.Image = global::WordJumble.Properties.Resources.ButtonExpert;
            this.lblExpert.Location = new System.Drawing.Point(431, 31);
            this.lblExpert.Name = "lblExpert";
            this.lblExpert.Size = new System.Drawing.Size(122, 143);
            this.lblExpert.TabIndex = 2;
            this.lblExpert.Click += new System.EventHandler(this.lblExpert_Click);
            this.lblExpert.MouseLeave += new System.EventHandler(this.lblExpert_MouseLeave);
            this.lblExpert.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblExpert_MouseMove);
            // 
            // lblTimeTrial
            // 
            this.lblTimeTrial.BackColor = System.Drawing.Color.Transparent;
            this.lblTimeTrial.Image = global::WordJumble.Properties.Resources.ButtonTime;
            this.lblTimeTrial.Location = new System.Drawing.Point(531, 158);
            this.lblTimeTrial.Name = "lblTimeTrial";
            this.lblTimeTrial.Size = new System.Drawing.Size(122, 143);
            this.lblTimeTrial.TabIndex = 3;
            this.lblTimeTrial.Click += new System.EventHandler(this.lblTimeTrial_Click);
            this.lblTimeTrial.MouseLeave += new System.EventHandler(this.lblTimeTrial_MouseLeave);
            this.lblTimeTrial.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblTimeTrial_MouseMove);
            // 
            // lblLastest
            // 
            this.lblLastest.BackColor = System.Drawing.Color.Transparent;
            this.lblLastest.ContextMenuStrip = this.mnuLastestPlay;
            this.lblLastest.Image = global::WordJumble.Properties.Resources.ButtonLastestPlay;
            this.lblLastest.Location = new System.Drawing.Point(492, 307);
            this.lblLastest.Name = "lblLastest";
            this.lblLastest.Size = new System.Drawing.Size(122, 143);
            this.lblLastest.TabIndex = 4;
            this.lblLastest.Click += new System.EventHandler(this.lblLastest_Click);
            this.lblLastest.MouseLeave += new System.EventHandler(this.lblLastest_MouseLeave);
            this.lblLastest.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblLastest_MouseMove);
            // 
            // mnuLastestPlay
            // 
            this.mnuLastestPlay.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLastest,
            this.mnuLoadGame});
            this.mnuLastestPlay.Name = "mnuLastestPlay";
            this.mnuLastestPlay.Size = new System.Drawing.Size(153, 70);
            // 
            // mnuLastest
            // 
            this.mnuLastest.Image = global::WordJumble.Properties.Resources.lastest;
            this.mnuLastest.Name = "mnuLastest";
            this.mnuLastest.Size = new System.Drawing.Size(152, 22);
            this.mnuLastest.Text = "Lastest Play";
            this.mnuLastest.Click += new System.EventHandler(this.mnuLastest_Click);
            // 
            // mnuLoadGame
            // 
            this.mnuLoadGame.Image = global::WordJumble.Properties.Resources.Load;
            this.mnuLoadGame.Name = "mnuLoadGame";
            this.mnuLoadGame.Size = new System.Drawing.Size(152, 22);
            this.mnuLoadGame.Text = "Load Game";
            this.mnuLoadGame.Click += new System.EventHandler(this.mnuLoadGame_Click);
            // 
            // lblHighScores
            // 
            this.lblHighScores.BackColor = System.Drawing.Color.Transparent;
            this.lblHighScores.Image = global::WordJumble.Properties.Resources.ButtonHighScores;
            this.lblHighScores.Location = new System.Drawing.Point(349, 353);
            this.lblHighScores.Name = "lblHighScores";
            this.lblHighScores.Size = new System.Drawing.Size(122, 143);
            this.lblHighScores.TabIndex = 5;
            this.lblHighScores.Click += new System.EventHandler(this.lblHighScores_Click);
            this.lblHighScores.MouseLeave += new System.EventHandler(this.lblHighScores_MouseLeave);
            this.lblHighScores.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblHighScores_MouseMove);
            // 
            // lblOptions
            // 
            this.lblOptions.BackColor = System.Drawing.Color.Transparent;
            this.lblOptions.Image = global::WordJumble.Properties.Resources.ButtonOptions;
            this.lblOptions.Location = new System.Drawing.Point(206, 307);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(122, 143);
            this.lblOptions.TabIndex = 6;
            this.lblOptions.Click += new System.EventHandler(this.lblOptions_Click);
            this.lblOptions.MouseLeave += new System.EventHandler(this.lblOptions_MouseLeave);
            this.lblOptions.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblOptions_MouseMove);
            // 
            // WordJumblePro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = global::WordJumble.Properties.Resources.JumbleBg;
            this.ClientSize = new System.Drawing.Size(784, 520);
            this.Controls.Add(this.lblOptions);
            this.Controls.Add(this.lblHighScores);
            this.Controls.Add(this.lblLastest);
            this.Controls.Add(this.lblTimeTrial);
            this.Controls.Add(this.lblExpert);
            this.Controls.Add(this.lblBeginner);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.menu);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.Name = "WordJumblePro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Word Jumble 1.0";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WordJumblePro_FormClosed);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.mnuLastestPlay.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdate;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblBeginner;
        private System.Windows.Forms.Label lblExpert;
        private System.Windows.Forms.Label lblTimeTrial;
        private System.Windows.Forms.Label lblLastest;
        private System.Windows.Forms.Label lblHighScores;
        private System.Windows.Forms.Label lblOptions;
        private System.Windows.Forms.ContextMenuStrip mnuLastestPlay;
        private System.Windows.Forms.ToolStripMenuItem mnuLastest;
        private System.Windows.Forms.ToolStripMenuItem mnuLoadGame;
    }
}

