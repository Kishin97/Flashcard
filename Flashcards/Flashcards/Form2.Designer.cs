namespace Flashcards
{
    partial class Form2
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
            this.ImportQuestionsButton = new System.Windows.Forms.Button();
            this.ImportAnswersButton = new System.Windows.Forms.Button();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.AddAnotherAnswerButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.startButton = new System.Windows.Forms.Button();
            this.CardCountLabel = new System.Windows.Forms.Label();
            this.CancelSelectionButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.userInputTextBox = new System.Windows.Forms.TextBox();
            this.cardButton = new System.Windows.Forms.Button();
            this.removeAnswerRButton = new System.Windows.Forms.RadioButton();
            this.addAnswerRButton = new System.Windows.Forms.RadioButton();
            this.messageBox = new System.Windows.Forms.RichTextBox();
            this.randomBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ImportQuestionsButton
            // 
            this.ImportQuestionsButton.Location = new System.Drawing.Point(168, 358);
            this.ImportQuestionsButton.Name = "ImportQuestionsButton";
            this.ImportQuestionsButton.Size = new System.Drawing.Size(95, 40);
            this.ImportQuestionsButton.TabIndex = 0;
            this.ImportQuestionsButton.Text = "Import Questions";
            this.ImportQuestionsButton.UseVisualStyleBackColor = true;
            this.ImportQuestionsButton.Click += new System.EventHandler(this.ImportQuestionsButton_Click);
            // 
            // ImportAnswersButton
            // 
            this.ImportAnswersButton.Enabled = false;
            this.ImportAnswersButton.Location = new System.Drawing.Point(446, 358);
            this.ImportAnswersButton.Name = "ImportAnswersButton";
            this.ImportAnswersButton.Size = new System.Drawing.Size(95, 40);
            this.ImportAnswersButton.TabIndex = 1;
            this.ImportAnswersButton.Text = "Import Answers";
            this.ImportAnswersButton.UseVisualStyleBackColor = true;
            this.ImportAnswersButton.Click += new System.EventHandler(this.ImportAnswersButton_Click);
            // 
            // PreviousButton
            // 
            this.PreviousButton.Enabled = false;
            this.PreviousButton.Location = new System.Drawing.Point(29, 358);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(95, 40);
            this.PreviousButton.TabIndex = 2;
            this.PreviousButton.Text = "Previous";
            this.PreviousButton.UseVisualStyleBackColor = true;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Enabled = false;
            this.NextButton.Location = new System.Drawing.Point(580, 358);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(95, 40);
            this.NextButton.TabIndex = 3;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // AddAnotherAnswerButton
            // 
            this.AddAnotherAnswerButton.Enabled = false;
            this.AddAnotherAnswerButton.Location = new System.Drawing.Point(509, 421);
            this.AddAnotherAnswerButton.Name = "AddAnotherAnswerButton";
            this.AddAnotherAnswerButton.Size = new System.Drawing.Size(53, 25);
            this.AddAnotherAnswerButton.TabIndex = 4;
            this.AddAnotherAnswerButton.Text = "Go";
            this.AddAnotherAnswerButton.UseVisualStyleBackColor = true;
            this.AddAnotherAnswerButton.Click += new System.EventHandler(this.AddAnotherAnswerButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(580, 413);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(95, 40);
            this.CancelButton.TabIndex = 6;
            this.CancelButton.Text = "Exit Study Mode";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // startButton
            // 
            this.startButton.Enabled = false;
            this.startButton.Location = new System.Drawing.Point(29, 413);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(95, 40);
            this.startButton.TabIndex = 8;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // CardCountLabel
            // 
            this.CardCountLabel.AutoSize = true;
            this.CardCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardCountLabel.Location = new System.Drawing.Point(328, 9);
            this.CardCountLabel.Name = "CardCountLabel";
            this.CardCountLabel.Size = new System.Drawing.Size(42, 25);
            this.CardCountLabel.TabIndex = 9;
            this.CardCountLabel.Text = "0/0";
            // 
            // CancelSelectionButton
            // 
            this.CancelSelectionButton.Enabled = false;
            this.CancelSelectionButton.Location = new System.Drawing.Point(308, 358);
            this.CancelSelectionButton.Name = "CancelSelectionButton";
            this.CancelSelectionButton.Size = new System.Drawing.Size(95, 40);
            this.CancelSelectionButton.TabIndex = 11;
            this.CancelSelectionButton.Text = "Change Set";
            this.CancelSelectionButton.UseVisualStyleBackColor = true;
            this.CancelSelectionButton.Click += new System.EventHandler(this.CancelSelectionButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(194, 460);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 12;
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // userInputTextBox
            // 
            this.userInputTextBox.Location = new System.Drawing.Point(257, 424);
            this.userInputTextBox.Name = "userInputTextBox";
            this.userInputTextBox.Size = new System.Drawing.Size(246, 20);
            this.userInputTextBox.TabIndex = 13;
            // 
            // cardButton
            // 
            this.cardButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardButton.Location = new System.Drawing.Point(29, 46);
            this.cardButton.Name = "cardButton";
            this.cardButton.Size = new System.Drawing.Size(646, 294);
            this.cardButton.TabIndex = 16;
            this.cardButton.UseVisualStyleBackColor = false;
            this.cardButton.Click += new System.EventHandler(this.cardButton_Click);
            // 
            // removeAnswerRButton
            // 
            this.removeAnswerRButton.AutoSize = true;
            this.removeAnswerRButton.Location = new System.Drawing.Point(135, 436);
            this.removeAnswerRButton.Name = "removeAnswerRButton";
            this.removeAnswerRButton.Size = new System.Drawing.Size(120, 17);
            this.removeAnswerRButton.TabIndex = 17;
            this.removeAnswerRButton.TabStop = true;
            this.removeAnswerRButton.Text = "Remove an answer:";
            this.removeAnswerRButton.UseVisualStyleBackColor = true;
            // 
            // addAnswerRButton
            // 
            this.addAnswerRButton.AutoSize = true;
            this.addAnswerRButton.Location = new System.Drawing.Point(135, 413);
            this.addAnswerRButton.Name = "addAnswerRButton";
            this.addAnswerRButton.Size = new System.Drawing.Size(99, 17);
            this.addAnswerRButton.TabIndex = 18;
            this.addAnswerRButton.TabStop = true;
            this.addAnswerRButton.Text = "Add an answer:";
            this.addAnswerRButton.UseVisualStyleBackColor = true;
            // 
            // messageBox
            // 
            this.messageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.messageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageBox.Location = new System.Drawing.Point(135, 459);
            this.messageBox.Name = "messageBox";
            this.messageBox.ReadOnly = true;
            this.messageBox.Size = new System.Drawing.Size(427, 39);
            this.messageBox.TabIndex = 19;
            this.messageBox.Text = "";
            // 
            // randomBox
            // 
            this.randomBox.AutoSize = true;
            this.randomBox.Enabled = false;
            this.randomBox.Location = new System.Drawing.Point(29, 462);
            this.randomBox.Name = "randomBox";
            this.randomBox.Size = new System.Drawing.Size(79, 17);
            this.randomBox.TabIndex = 20;
            this.randomBox.Text = "Randomize";
            this.randomBox.UseVisualStyleBackColor = true;
            this.randomBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 510);
            this.Controls.Add(this.randomBox);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.addAnswerRButton);
            this.Controls.Add(this.removeAnswerRButton);
            this.Controls.Add(this.cardButton);
            this.Controls.Add(this.userInputTextBox);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.CancelSelectionButton);
            this.Controls.Add(this.CardCountLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddAnotherAnswerButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.PreviousButton);
            this.Controls.Add(this.ImportAnswersButton);
            this.Controls.Add(this.ImportQuestionsButton);
            this.Name = "Form2";
            this.Text = "Study Mode";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form2_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form2_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ImportQuestionsButton;
        private System.Windows.Forms.Button ImportAnswersButton;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button AddAnotherAnswerButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label CardCountLabel;
        private System.Windows.Forms.Button CancelSelectionButton;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.TextBox userInputTextBox;
        private System.Windows.Forms.Button cardButton;
        private System.Windows.Forms.RadioButton removeAnswerRButton;
        private System.Windows.Forms.RadioButton addAnswerRButton;
        private System.Windows.Forms.RichTextBox messageBox;
        private System.Windows.Forms.CheckBox randomBox;
    }
}