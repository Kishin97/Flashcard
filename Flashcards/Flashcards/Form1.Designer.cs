namespace Flashcards
{
    partial class Form1
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
            this.studyButton = new System.Windows.Forms.Button();
            this.QuizButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // studyButton
            // 
            this.studyButton.Location = new System.Drawing.Point(24, 23);
            this.studyButton.Name = "studyButton";
            this.studyButton.Size = new System.Drawing.Size(99, 67);
            this.studyButton.TabIndex = 0;
            this.studyButton.Text = "Study Mode";
            this.studyButton.UseVisualStyleBackColor = true;
            this.studyButton.Click += new System.EventHandler(this.StudyButton_Click);
            // 
            // QuizButton
            // 
            this.QuizButton.Location = new System.Drawing.Point(147, 23);
            this.QuizButton.Name = "QuizButton";
            this.QuizButton.Size = new System.Drawing.Size(99, 67);
            this.QuizButton.TabIndex = 1;
            this.QuizButton.Text = "Quiz Mode";
            this.QuizButton.UseVisualStyleBackColor = true;
            this.QuizButton.Click += new System.EventHandler(this.QuizButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(147, 120);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(99, 67);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(24, 120);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(99, 67);
            this.helpButton.TabIndex = 3;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 210);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.QuizButton);
            this.Controls.Add(this.studyButton);
            this.Name = "Form1";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button studyButton;
        private System.Windows.Forms.Button QuizButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button helpButton;
    }
}

