namespace WordJumble
{
    partial class Playing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Playing));
            this.lblMode = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.AnswerArea = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.QuestionArea = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.grHelp = new System.Windows.Forms.GroupBox();
            this.lblChangeQuestion = new System.Windows.Forms.Label();
            this.lblHint = new System.Windows.Forms.Label();
            this.lblReduce = new System.Windows.Forms.Label();
            this.lblHelp = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.btnAnswer = new System.Windows.Forms.Button();
            this.lblInput = new System.Windows.Forms.Label();
            this.lblMissed = new System.Windows.Forms.Label();
            this.lblPoint = new System.Windows.Forms.Label();
            this.lblBonus = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.timeCount = new System.Windows.Forms.Timer(this.components);
            this.progBonus = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWinTimes = new System.Windows.Forms.Label();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.lblHintWord = new System.Windows.Forms.Label();
            this.timeCheck = new System.Windows.Forms.Timer(this.components);
            this.lblSave = new System.Windows.Forms.Label();
            this.grHelp.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMode
            // 
            this.lblMode.BackColor = System.Drawing.Color.Transparent;
            this.lblMode.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMode.ForeColor = System.Drawing.Color.Crimson;
            this.lblMode.Location = new System.Drawing.Point(95, 26);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(186, 23);
            this.lblMode.TabIndex = 4;
            this.lblMode.Text = "Beginner";
            this.lblMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1,
            this.AnswerArea,
            this.QuestionArea});
            this.shapeContainer1.Size = new System.Drawing.Size(794, 558);
            this.shapeContainer1.TabIndex = 5;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BackColor = System.Drawing.Color.White;
            this.rectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape1.BorderColor = System.Drawing.Color.LightGray;
            this.rectangleShape1.CornerRadius = 2;
            this.rectangleShape1.Enabled = false;
            this.rectangleShape1.Location = new System.Drawing.Point(367, 29);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(285, 46);
            // 
            // AnswerArea
            // 
            this.AnswerArea.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.AnswerArea.BorderColor = System.Drawing.Color.LightGray;
            this.AnswerArea.CornerRadius = 2;
            this.AnswerArea.Enabled = false;
            this.AnswerArea.Location = new System.Drawing.Point(251, 359);
            this.AnswerArea.Name = "AnswerArea";
            this.AnswerArea.Size = new System.Drawing.Size(482, 173);
            // 
            // QuestionArea
            // 
            this.QuestionArea.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.QuestionArea.BorderColor = System.Drawing.Color.LightGray;
            this.QuestionArea.CornerRadius = 2;
            this.QuestionArea.Enabled = false;
            this.QuestionArea.Location = new System.Drawing.Point(251, 91);
            this.QuestionArea.Name = "QuestionArea";
            this.QuestionArea.Size = new System.Drawing.Size(482, 254);
            // 
            // grHelp
            // 
            this.grHelp.Controls.Add(this.lblChangeQuestion);
            this.grHelp.Controls.Add(this.lblHint);
            this.grHelp.Controls.Add(this.lblReduce);
            this.grHelp.Controls.Add(this.lblHelp);
            this.grHelp.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grHelp.Location = new System.Drawing.Point(264, 370);
            this.grHelp.Name = "grHelp";
            this.grHelp.Size = new System.Drawing.Size(208, 152);
            this.grHelp.TabIndex = 6;
            this.grHelp.TabStop = false;
            this.grHelp.Text = "Help";
            // 
            // lblChangeQuestion
            // 
            this.lblChangeQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblChangeQuestion.Enabled = false;
            this.lblChangeQuestion.Image = global::WordJumble.Properties.Resources.Change;
            this.lblChangeQuestion.Location = new System.Drawing.Point(7, 21);
            this.lblChangeQuestion.Name = "lblChangeQuestion";
            this.lblChangeQuestion.Size = new System.Drawing.Size(67, 65);
            this.lblChangeQuestion.TabIndex = 6;
            this.lblChangeQuestion.Click += new System.EventHandler(this.lblChangeQuestion_Click);
            this.lblChangeQuestion.MouseLeave += new System.EventHandler(this.lblChangeQuestion_MouseLeave);
            this.lblChangeQuestion.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblChangeQuestion_MouseMove);
            // 
            // lblHint
            // 
            this.lblHint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHint.Enabled = false;
            this.lblHint.Image = global::WordJumble.Properties.Resources.Hint;
            this.lblHint.Location = new System.Drawing.Point(75, 21);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(67, 65);
            this.lblHint.TabIndex = 5;
            this.lblHint.Click += new System.EventHandler(this.lblHint_Click);
            this.lblHint.MouseLeave += new System.EventHandler(this.lblHint_MouseLeave);
            this.lblHint.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblHint_MouseMove);
            // 
            // lblReduce
            // 
            this.lblReduce.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblReduce.Enabled = false;
            this.lblReduce.Image = global::WordJumble.Properties.Resources.Reduce;
            this.lblReduce.Location = new System.Drawing.Point(136, 21);
            this.lblReduce.Name = "lblReduce";
            this.lblReduce.Size = new System.Drawing.Size(67, 65);
            this.lblReduce.TabIndex = 4;
            this.lblReduce.Click += new System.EventHandler(this.lblReduce_Click);
            this.lblReduce.MouseLeave += new System.EventHandler(this.lblReduce_MouseLeave);
            this.lblReduce.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblReduce_MouseMove);
            // 
            // lblHelp
            // 
            this.lblHelp.Location = new System.Drawing.Point(6, 86);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(196, 54);
            this.lblHelp.TabIndex = 3;
            this.lblHelp.Text = "Win 2 times: Hint - Win 5 times: Change Question - Win 7 times: Reduce and Change" +
                " Question";
            this.lblHelp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(490, 466);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(231, 20);
            this.txtAnswer.TabIndex = 3;
            this.txtAnswer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnswer_KeyPress);
            // 
            // btnAnswer
            // 
            this.btnAnswer.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswer.Image = global::WordJumble.Properties.Resources.answer;
            this.btnAnswer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnswer.Location = new System.Drawing.Point(490, 492);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(231, 30);
            this.btnAnswer.TabIndex = 4;
            this.btnAnswer.Text = "Answer";
            this.btnAnswer.UseVisualStyleBackColor = true;
            this.btnAnswer.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // lblInput
            // 
            this.lblInput.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInput.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblInput.Location = new System.Drawing.Point(487, 444);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(234, 19);
            this.lblInput.TabIndex = 9;
            this.lblInput.Text = "Input right sentence, please";
            // 
            // lblMissed
            // 
            this.lblMissed.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMissed.ForeColor = System.Drawing.Color.Brown;
            this.lblMissed.Location = new System.Drawing.Point(376, 42);
            this.lblMissed.Name = "lblMissed";
            this.lblMissed.Size = new System.Drawing.Size(76, 21);
            this.lblMissed.TabIndex = 11;
            this.lblMissed.Text = "Missed: 0";
            // 
            // lblPoint
            // 
            this.lblPoint.BackColor = System.Drawing.Color.White;
            this.lblPoint.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoint.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblPoint.Location = new System.Drawing.Point(474, 42);
            this.lblPoint.Name = "lblPoint";
            this.lblPoint.Size = new System.Drawing.Size(76, 21);
            this.lblPoint.TabIndex = 12;
            this.lblPoint.Text = "Point: 0";
            this.lblPoint.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblBonus
            // 
            this.lblBonus.BackColor = System.Drawing.Color.White;
            this.lblBonus.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBonus.ForeColor = System.Drawing.Color.Red;
            this.lblBonus.Location = new System.Drawing.Point(573, 42);
            this.lblBonus.Name = "lblBonus";
            this.lblBonus.Size = new System.Drawing.Size(76, 21);
            this.lblBonus.TabIndex = 13;
            this.lblBonus.Text = "Bonus: 0";
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Red;
            this.lblTime.Location = new System.Drawing.Point(490, 412);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(231, 21);
            this.lblTime.TabIndex = 14;
            // 
            // timeCount
            // 
            this.timeCount.Interval = 1000;
            this.timeCount.Tick += new System.EventHandler(this.timeCount_Tick);
            // 
            // progBonus
            // 
            this.progBonus.Location = new System.Drawing.Point(298, 303);
            this.progBonus.Name = "progBonus";
            this.progBonus.Size = new System.Drawing.Size(398, 27);
            this.progBonus.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progBonus.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(295, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Bonus";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWinTimes
            // 
            this.lblWinTimes.BackColor = System.Drawing.Color.Transparent;
            this.lblWinTimes.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinTimes.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblWinTimes.Location = new System.Drawing.Point(95, 53);
            this.lblWinTimes.Name = "lblWinTimes";
            this.lblWinTimes.Size = new System.Drawing.Size(186, 23);
            this.lblWinTimes.TabIndex = 17;
            this.lblWinTimes.Text = "Total Win: 0";
            this.lblWinTimes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtQuestion
            // 
            this.txtQuestion.BackColor = System.Drawing.Color.White;
            this.txtQuestion.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtQuestion.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestion.HideSelection = false;
            this.txtQuestion.Location = new System.Drawing.Point(300, 105);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.ReadOnly = true;
            this.txtQuestion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtQuestion.Size = new System.Drawing.Size(397, 175);
            this.txtQuestion.TabIndex = 18;
            this.txtQuestion.TabStop = false;
            this.txtQuestion.WordWrap = false;
            // 
            // lblHintWord
            // 
            this.lblHintWord.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHintWord.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblHintWord.Location = new System.Drawing.Point(490, 379);
            this.lblHintWord.Name = "lblHintWord";
            this.lblHintWord.Size = new System.Drawing.Size(231, 21);
            this.lblHintWord.TabIndex = 19;
            // 
            // timeCheck
            // 
            this.timeCheck.Enabled = true;
            this.timeCheck.Interval = 1000;
            this.timeCheck.Tick += new System.EventHandler(this.timeCheck_Tick);
            // 
            // lblSave
            // 
            this.lblSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSave.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSave.ForeColor = System.Drawing.Color.DarkGray;
            this.lblSave.Image = ((System.Drawing.Image)(resources.GetObject("lblSave.Image")));
            this.lblSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSave.Location = new System.Drawing.Point(61, 121);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(125, 34);
            this.lblSave.TabIndex = 20;
            this.lblSave.Text = "   Save Game";
            this.lblSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSave.Click += new System.EventHandler(this.lblSave_Click);
            // 
            // Playing
            // 
            this.AcceptButton = this.btnAnswer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::WordJumble.Properties.Resources.JumblePlaying;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(794, 558);
            this.Controls.Add(this.lblSave);
            this.Controls.Add(this.lblHintWord);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.lblWinTimes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progBonus);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblBonus);
            this.Controls.Add(this.lblPoint);
            this.Controls.Add(this.lblMissed);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.btnAnswer);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.grHelp);
            this.Controls.Add(this.lblMode);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Playing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Word Jumble 1.0 - Playing";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Playing_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Playing_FormClosed);
            this.Load += new System.EventHandler(this.Playing_Load);
            this.grHelp.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMode;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape QuestionArea;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape AnswerArea;
        private System.Windows.Forms.GroupBox grHelp;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Button btnAnswer;
        private System.Windows.Forms.Label lblInput;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Label lblMissed;
        private System.Windows.Forms.Label lblPoint;
        private System.Windows.Forms.Label lblBonus;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timeCount;
        private System.Windows.Forms.ProgressBar progBonus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWinTimes;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Label lblReduce;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.Label lblChangeQuestion;
        private System.Windows.Forms.Label lblHintWord;
        private System.Windows.Forms.Timer timeCheck;
        private System.Windows.Forms.Label lblSave;
    }
}