namespace Flashcards
{
    partial class Quiz_Mode
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
            this.minutesLabel = new System.Windows.Forms.Label();
            this.secondsLabel = new System.Windows.Forms.Label();
            this.millisecondsLabel = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.colonLabel = new System.Windows.Forms.Label();
            this.colon2Label = new System.Windows.Forms.Label();
            this.ImportQuestionsButton = new System.Windows.Forms.Button();
            this.ImportAnswersButton = new System.Windows.Forms.Button();
            this.CancelSelectionButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.CardCountLabel = new System.Windows.Forms.Label();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.messageLabel = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.messageRichTextBox = new System.Windows.Forms.RichTextBox();
            this.viewLeaderBoardButton = new System.Windows.Forms.Button();
            this.cardButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // minutesLabel
            // 
            this.minutesLabel.AutoSize = true;
            this.minutesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutesLabel.Location = new System.Drawing.Point(211, 9);
            this.minutesLabel.Name = "minutesLabel";
            this.minutesLabel.Size = new System.Drawing.Size(30, 24);
            this.minutesLabel.TabIndex = 0;
            this.minutesLabel.Text = "00";
            // 
            // secondsLabel
            // 
            this.secondsLabel.AutoSize = true;
            this.secondsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondsLabel.Location = new System.Drawing.Point(253, 9);
            this.secondsLabel.Name = "secondsLabel";
            this.secondsLabel.Size = new System.Drawing.Size(30, 24);
            this.secondsLabel.TabIndex = 1;
            this.secondsLabel.Text = "00";
            // 
            // millisecondsLabel
            // 
            this.millisecondsLabel.AutoSize = true;
            this.millisecondsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.millisecondsLabel.Location = new System.Drawing.Point(294, 9);
            this.millisecondsLabel.Name = "millisecondsLabel";
            this.millisecondsLabel.Size = new System.Drawing.Size(30, 24);
            this.millisecondsLabel.TabIndex = 2;
            this.millisecondsLabel.Text = "00";
            // 
            // StartButton
            // 
            this.StartButton.Enabled = false;
            this.StartButton.Location = new System.Drawing.Point(235, 291);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(95, 40);
            this.StartButton.TabIndex = 3;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // colonLabel
            // 
            this.colonLabel.AutoSize = true;
            this.colonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colonLabel.Location = new System.Drawing.Point(239, 7);
            this.colonLabel.Name = "colonLabel";
            this.colonLabel.Size = new System.Drawing.Size(15, 24);
            this.colonLabel.TabIndex = 6;
            this.colonLabel.Text = ":";
            // 
            // colon2Label
            // 
            this.colon2Label.AutoSize = true;
            this.colon2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colon2Label.Location = new System.Drawing.Point(281, 7);
            this.colon2Label.Name = "colon2Label";
            this.colon2Label.Size = new System.Drawing.Size(15, 24);
            this.colon2Label.TabIndex = 7;
            this.colon2Label.Text = ":";
            // 
            // ImportQuestionsButton
            // 
            this.ImportQuestionsButton.Location = new System.Drawing.Point(12, 291);
            this.ImportQuestionsButton.Name = "ImportQuestionsButton";
            this.ImportQuestionsButton.Size = new System.Drawing.Size(95, 40);
            this.ImportQuestionsButton.TabIndex = 8;
            this.ImportQuestionsButton.Text = "Import Questions";
            this.ImportQuestionsButton.UseVisualStyleBackColor = true;
            this.ImportQuestionsButton.Click += new System.EventHandler(this.ImportQuestionsButton_Click);
            // 
            // ImportAnswersButton
            // 
            this.ImportAnswersButton.Enabled = false;
            this.ImportAnswersButton.Location = new System.Drawing.Point(12, 357);
            this.ImportAnswersButton.Name = "ImportAnswersButton";
            this.ImportAnswersButton.Size = new System.Drawing.Size(95, 40);
            this.ImportAnswersButton.TabIndex = 9;
            this.ImportAnswersButton.Text = "Import Answers";
            this.ImportAnswersButton.UseVisualStyleBackColor = true;
            this.ImportAnswersButton.Click += new System.EventHandler(this.ImportAnswersButton_Click);
            // 
            // CancelSelectionButton
            // 
            this.CancelSelectionButton.Enabled = false;
            this.CancelSelectionButton.Location = new System.Drawing.Point(235, 357);
            this.CancelSelectionButton.Name = "CancelSelectionButton";
            this.CancelSelectionButton.Size = new System.Drawing.Size(95, 40);
            this.CancelSelectionButton.TabIndex = 12;
            this.CancelSelectionButton.Text = "Change Set";
            this.CancelSelectionButton.UseVisualStyleBackColor = true;
            this.CancelSelectionButton.Click += new System.EventHandler(this.CancelSelectionButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(433, 357);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(95, 40);
            this.exitButton.TabIndex = 13;
            this.exitButton.Text = "Exit Quiz Mode";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // CardCountLabel
            // 
            this.CardCountLabel.AutoSize = true;
            this.CardCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardCountLabel.Location = new System.Drawing.Point(12, 10);
            this.CardCountLabel.Name = "CardCountLabel";
            this.CardCountLabel.Size = new System.Drawing.Size(35, 24);
            this.CardCountLabel.TabIndex = 14;
            this.CardCountLabel.Text = "0/0";
            // 
            // userTextBox
            // 
            this.userTextBox.Location = new System.Drawing.Point(146, 425);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(244, 20);
            this.userTextBox.TabIndex = 15;
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel.Location = new System.Drawing.Point(47, 454);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(0, 16);
            this.messageLabel.TabIndex = 16;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(454, 10);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(70, 24);
            this.scoreLabel.TabIndex = 18;
            this.scoreLabel.Text = "00.00%";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(105, 428);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 19;
            this.nameLabel.Text = "Name:";
            // 
            // messageRichTextBox
            // 
            this.messageRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.messageRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageRichTextBox.Location = new System.Drawing.Point(50, 454);
            this.messageRichTextBox.Name = "messageRichTextBox";
            this.messageRichTextBox.ReadOnly = true;
            this.messageRichTextBox.Size = new System.Drawing.Size(437, 72);
            this.messageRichTextBox.TabIndex = 20;
            this.messageRichTextBox.Text = "";
            // 
            // viewLeaderBoardButton
            // 
            this.viewLeaderBoardButton.Location = new System.Drawing.Point(433, 291);
            this.viewLeaderBoardButton.Name = "viewLeaderBoardButton";
            this.viewLeaderBoardButton.Size = new System.Drawing.Size(95, 40);
            this.viewLeaderBoardButton.TabIndex = 21;
            this.viewLeaderBoardButton.Text = "View Leaderboard";
            this.viewLeaderBoardButton.UseVisualStyleBackColor = true;
            this.viewLeaderBoardButton.Click += new System.EventHandler(this.viewLeaderBoardButton_Click);
            // 
            // cardButton
            // 
            this.cardButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardButton.Location = new System.Drawing.Point(12, 37);
            this.cardButton.Name = "cardButton";
            this.cardButton.Size = new System.Drawing.Size(516, 232);
            this.cardButton.TabIndex = 22;
            this.cardButton.UseVisualStyleBackColor = false;
            this.cardButton.Click += new System.EventHandler(this.cardButton_Click);
            // 
            // Quiz_Mode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 538);
            this.Controls.Add(this.cardButton);
            this.Controls.Add(this.viewLeaderBoardButton);
            this.Controls.Add(this.messageRichTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.userTextBox);
            this.Controls.Add(this.CardCountLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.CancelSelectionButton);
            this.Controls.Add(this.ImportAnswersButton);
            this.Controls.Add(this.ImportQuestionsButton);
            this.Controls.Add(this.colon2Label);
            this.Controls.Add(this.colonLabel);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.millisecondsLabel);
            this.Controls.Add(this.secondsLabel);
            this.Controls.Add(this.minutesLabel);
            this.Name = "Quiz_Mode";
            this.Text = "Quiz Mode";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label minutesLabel;
        private System.Windows.Forms.Label secondsLabel;
        private System.Windows.Forms.Label millisecondsLabel;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label colonLabel;
        private System.Windows.Forms.Label colon2Label;
        private System.Windows.Forms.Button ImportQuestionsButton;
        private System.Windows.Forms.Button ImportAnswersButton;
        private System.Windows.Forms.Button CancelSelectionButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label CardCountLabel;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.RichTextBox messageRichTextBox;
        private System.Windows.Forms.Button viewLeaderBoardButton;
        private System.Windows.Forms.Button cardButton;
    }
}