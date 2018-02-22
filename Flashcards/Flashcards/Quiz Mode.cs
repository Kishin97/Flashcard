using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flashcards
{
    public partial class Quiz_Mode : Form
    {
        Stopwatch sw;
        Timer timer;
        List<string> questions = new List<string>();
        List<List<string>> answers = new List<List<string>>();
        Dictionary<Tuple<int, string, int>, List<string>> dict = new Dictionary<Tuple<int, string, int>, List<string>>();
        int currentCard = 1;
        int totalCards = 0;
        String answer = "";
        String question = "";
        String answersFileName = "";
        String questionsFileName = "";
        Boolean answered = false;
        int answerCounter = 0;
        int questionCounter = 0;
        int answeredCorrectly = 0;
        String name = "";
        Form1 a = new Form1();
        public Quiz_Mode()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (StartButton.Text != "Restart")
            {
                name = userTextBox.Text;
            }
            if (name != "")
            {
                nameLabel.Left = 75;
                nameLabel.Text = "Your Answer:";
                int count = 0;
                dict.Clear();
                var rnd = new Random();
                var priority = Enumerable.Range(0, answers.Count).OrderBy(x => rnd.Next()).Take(answers.Count).ToList();
                userTextBox.Focus();
                foreach (List<string> answer in answers)
                {
                    if (count >= questionCounter && count >= answerCounter)
                    {
                        break;
                    }
                    var tuple = new Tuple<int, string, int>(count, questions.ElementAt(count), priority.ElementAt(count));
                    if (!dict.ContainsKey(tuple) && !dict.ContainsValue(answer))
                    {
                        dict.Add(tuple, answer);
                        count++;
                    }
                }
                StartButton.Text = "Restart";
                totalCards = dict.Count;
                currentCard = 1;
                CardCountLabel.Text = currentCard + "/" + totalCards;
                CancelSelectionButton.Enabled = true;
                ImportQuestionsButton.Enabled = false;
                ImportAnswersButton.Enabled = false;
                answer = "";
                answered = false;
                userTextBox.Text = "";
                messageRichTextBox.Text = "";
                scoreLabel.Text = "00.00%";
                answeredCorrectly = 0;
                foreach (KeyValuePair<Tuple<int, string, int>, List<string>> entry in dict)
                {
                    // Get question corresponding to currentCard
                    if (entry.Key.Item3 == currentCard - 1)
                    {
                        question = entry.Key.Item2;
                        cardButton.Text = question;
                        foreach (string item in entry.Value)
                        {
                            answer += item + " ";
                        }
                    }
                }
                // Create a timer with an interval of 10 ms
                timer = new Timer();
                timer.Interval = (10);
                timer.Tick += new EventHandler(timer_Tick);
                sw = new Stopwatch();
                timer.Start();
                sw.Start();
            }
            else
            {
                messageRichTextBox.Text = "Please enter your name.";
            }
        }
       
        private void timer_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = sw.Elapsed;
            minutesLabel.Text = ts.Minutes.ToString("00");
            secondsLabel.Text = ts.Seconds.ToString("00");
            double underSeconds = ts.Milliseconds / 10;
            // Since there is an interval of 10 ms, divide milliseconds by 10
            millisecondsLabel.Text = underSeconds.ToString("00");
            Application.DoEvents();
        }

        private void ImportQuestionsButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text files (*.txt)|*.txt";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                dict.Clear();
                questions.Clear();
                string line;
                System.IO.StreamReader sr = new
                System.IO.StreamReader(openFileDialog1.FileName);
                questionsFileName = Path.GetFileNameWithoutExtension(openFileDialog1.FileName);
                questionCounter = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    questions.Add(line);
                    questionCounter++;
                }
                sr.Close();
                ImportAnswersButton.Enabled = true;
            }
        }

        private void ImportAnswersButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text files (*.txt)|*.txt";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                answerCounter = 0;
                answers.Clear();
                string line;
                System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName);
                answersFileName = Path.GetFileNameWithoutExtension(openFileDialog1.FileName);
                while ((line = sr.ReadLine()) != null)
                {
                    List<string> answer = line.Split(new string[] { " //APPENDANSWER " }, StringSplitOptions.None).ToList<string>();
                    answers.Add(answer);
                    answerCounter++;
                }
                sr.Close();
                if (answerCounter == questionCounter)
                {
                    StartButton.Enabled = true;
                    messageRichTextBox.Text = "";
                }
                else
                {
                    messageRichTextBox.Text = "Questions and answers are not the same length. Please try again.";
                    StartButton.Enabled = false;
                }
                userTextBox.Focus();
            }              
        }

        private void CancelSelectionButton_Click(object sender, EventArgs e)
        {
            ImportQuestionsButton.Enabled = true;
            StartButton.Enabled = false;          
            CancelSelectionButton.Enabled = false;
            dict.Clear();
            totalCards = 0;
            currentCard = 1;
            CardCountLabel.Text = "0/0";
            cardButton.Text = "";
            answer = "";
            StartButton.Text = "Start";
            timer.Stop();
            sw.Reset();
            answered = false;
            minutesLabel.Text = "00";
            secondsLabel.Text = "00";
            millisecondsLabel.Text = "00";
            userTextBox.Text = "";
            messageRichTextBox.Text = "";
            scoreLabel.Text = "00.00%";
            answeredCorrectly = 0;
            nameLabel.Text = "Name:";
            nameLabel.Left = 105;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            a.Show();
            this.Hide();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            a.Show();
            this.Hide();
        }
      
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Control + Enter
            if(keyData == (Keys.Control | Keys.Enter))
            {
                StartButton.PerformClick();
                return true;
            }            
            // Enter
            else if (keyData == Keys.Enter && userTextBox.Focused && StartButton.Text != "Start" && !messageRichTextBox.Text.Contains("Congrats"))
            {
                cardButton.PerformClick();
                return true;
            }
            else if (keyData == Keys.Enter && userTextBox.Focused && (StartButton.Text == "Start" || messageRichTextBox.Text.Contains("Congrats")))
            {
                StartButton.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void viewLeaderBoardButton_Click(object sender, EventArgs e)
        {
            Leaderboard x = new Leaderboard();
            x.Show();
            this.Hide();
        }

        private void cardButton_Click(object sender, EventArgs e)
        {
            if (currentCard <= totalCards && !answered)
            {
                userTextBox.Focus();
                Boolean equality = false;
                foreach (KeyValuePair<Tuple<int, string, int>, List<string>> entry in dict)
                {
                    if (entry.Key.Item3 == currentCard - 1)
                    {
                        foreach (string item in entry.Value)
                        {
                            // Check if the answer the user entered is equal
                            // to one of the answers in the answers list for
                            // that question
                            if (item.ToLower().Equals(userTextBox.Text.ToLower()))
                            {
                                equality = true;
                            }
                        }
                    }
                }
                if (equality)
                {
                    messageRichTextBox.Text = "Correct";
                    answeredCorrectly++;
                    scoreLabel.Text = (Convert.ToDouble(answeredCorrectly) / Convert.ToDouble(currentCard)).ToString("00.00%");
                }
                else
                {
                    messageRichTextBox.Text = "Incorrect, the correct answer is one of the following: \n" + answer;
                    scoreLabel.Text = (Convert.ToDouble(answeredCorrectly) / Convert.ToDouble(currentCard)).ToString("00.00%");
                }
                if (currentCard == totalCards)
                {
                    // Stop timer when the last question is answered and record the time
                    answered = true;
                    timer.Stop();
                    sw.Stop();
                    String trueMinute = minutesLabel.Text;
                    String trueSecond = secondsLabel.Text;
                    String trueMs = millisecondsLabel.Text;
                    if (trueMinute.ElementAt(0).ToString().Equals("0"))
                    {
                        trueMinute = trueMinute.Substring(1);
                    }
                    if (trueSecond.ElementAt(0).ToString().Equals("0"))
                    {
                        trueSecond = trueSecond.Substring(1);
                    }
                    messageRichTextBox.Text += "\nCongrats " + name + ", you finished the flashcard set with a score of " + scoreLabel.Text + " and a time of " + trueMinute + " minute(s) and " + trueSecond + "." + trueMs + " second(s)!";
                    String newName = name;
                    double newScore = 100.00 * Convert.ToDouble((Convert.ToDouble(answeredCorrectly) / Convert.ToDouble(currentCard)).ToString("00.00"));
                    String newTime = minutesLabel.Text + colonLabel.Text + secondsLabel.Text + colon2Label.Text + millisecondsLabel.Text;
                    DateTime newDate = DateTime.Now;
                    // Tuple params will have name, score, time taken to complete, and date in that order
                    List<Tuple<String, double, String, DateTime>> leaderBoard = new List<Tuple<String, double, String, DateTime>>();
                    // Create the leaderboard text file
                    if (!File.Exists(questionsFileName + " and " + answersFileName + " Leaderboard.txt"))
                    {
                        int rank = 1;
                        using (StreamWriter w = File.AppendText(questionsFileName + " and " + answersFileName + " Leaderboard.txt"))
                        {
                            while (rank < 11)
                            {
                                DateTime localDate = DateTime.Now;
                                leaderBoard.Add(Tuple.Create("-------", 00.00, "59:59:99", localDate));
                                w.WriteLine("-------");
                                w.WriteLine("00.00");
                                w.WriteLine("59:59:99");
                                w.WriteLine(localDate.ToString());
                                rank++;
                            }
                        }
                    }
                    // Change the leaderboard text file
                    else
                    {
                        System.IO.StreamReader sr = new System.IO.StreamReader(questionsFileName + " and " + answersFileName + " Leaderboard.txt");
                        String item1;
                        while (null != (item1 = sr.ReadLine()))
                        {
                            String item2 = sr.ReadLine();
                            String item3 = sr.ReadLine();
                            String item4 = sr.ReadLine();
                            DateTime dateItem4 = DateTime.Parse(item4);
                            leaderBoard.Add(Tuple.Create(item1, Convert.ToDouble(item2), item3, dateItem4));
                        }
                        sr.Close();
                    }
                    // Check if user made leaderboard by sorting by score, time taken,
                    // and date and deleting the last spot
                    leaderBoard.Add(Tuple.Create(name, newScore, newTime, newDate));
                    leaderBoard = leaderBoard.OrderByDescending(a => a.Item2).ThenBy(a => TimeSpan.ParseExact(a.Item3, "mm':'ss':'ff", CultureInfo.InvariantCulture)).ThenBy(a => a.Item4).ToList();
                    leaderBoard.Remove(leaderBoard.Last());
                    if (leaderBoard.Contains(Tuple.Create(name, newScore, newTime, newDate)))
                    {
                        messageRichTextBox.Text += " You also made the leaderboard!";
                    }
                    using (var input = File.OpenText(questionsFileName + " and " + answersFileName + " Leaderboard.txt"))
                    using (var output = new StreamWriter(questionsFileName + " and " + answersFileName + " Leaderboard Temp.txt"))
                    {
                        int counter = 0;
                        string line;
                        while (null != (line = input.ReadLine()))
                        {
                            // Format for filling out leaderboard file
                            if (counter % 4 == 0)
                            {
                                output.WriteLine(leaderBoard.ElementAt(counter / 4).Item1);
                                output.WriteLine(leaderBoard.ElementAt(counter / 4).Item2);
                                output.WriteLine(leaderBoard.ElementAt(counter / 4).Item3);
                                output.WriteLine(leaderBoard.ElementAt(counter / 4).Item4);
                            }
                            counter++;
                        }
                    }
                    File.Replace(questionsFileName + " and " + answersFileName + " Leaderboard Temp.txt", questionsFileName + " and " + answersFileName + " Leaderboard.txt", null);
                }

            }
            if (currentCard < totalCards)
            {
                answer = "";
                currentCard++;
                CardCountLabel.Text = currentCard.ToString() + "/" + totalCards.ToString();
                foreach (KeyValuePair<Tuple<int, string, int>, List<string>> entry in dict)
                {
                    if (entry.Key.Item3 == currentCard - 1)
                    {
                        question = entry.Key.Item2;
                        cardButton.Text = question;
                        foreach (string item in entry.Value)
                        {
                            answer += item + " ";
                        }
                    }
                }
                userTextBox.Text = "";
            }
        }
    }
}
