using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flashcards
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 a = new Form1();
            a.Show();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            this.Hide();
            Form1 a = new Form1();
            a.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "Next Page")
            {
                richTextBox1.Text = "Quiz Mode: \n" +
                    "In this mode, you can quiz yourself on the flashcards you made and view your accuracy and the time taken to answer the questions. " +
                    "Once you have imported your questions and answers and typed in your name, click the Start button to begin the quiz. " +
                    "The flashcard will display the question and you will need to type the answer in the text box below. Click the flashcard or press the Enter key to submit your answer. " +
                    "Once you submit your answer, the game will tell you if you are right or wrong and will list all of the possible answers if you are wrong. " +
                    "You may restart the game at any point during the quiz by clicking the Restart button or pressing the Ctrl + Enter buttons. Like Study Mode, you can also change the flashcard set by clicking the Change Set button. " +
                    "Once you answer the final question, the timer will stop and your score and time will be recorded and if they are good enough, your attempt will go on the leaderboard. " +
                    "Click the View Leaderboard Button to open the leaderboard and import the leaderboard file that the program made and you will be able to see your ranking. The rankings are sorted by score, then by time, and then by date achieved.";
                button2.Text = "Previous Page";
            }
            else
            {
                richTextBox1.Text = "Study Mode:\n" +
                "In this mode, you can study your flashcards and edit your answers as needed. View the sample question and answer files to understand the syntax for creating your own flashcards. Once you have imported your cards, check the Randomize checkbox if you would like to change the order of the cards and click the Start button to begin. You can flip a flashcard by clicking on it and you can go to the other flashcards by clicking the Previous and Next buttons. You can also use the spacebar and the left and right arrow keys to flip a flashcard or go to another flashcard as long as the the text box is not focused. You can add or remove answers by clicking one of their respective radio buttons, typing in an answer, and clicking the Go button or pressing Enter. Finally, you can change the flashcard set at any time by clicking the Change Set button.";
                button2.Text = "Next Page";
            }
        }
    }
}
