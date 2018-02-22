using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Specialized;
using System.Threading;

namespace Flashcards
{
    public partial class Form2 : Form
    {
        List<string> questions = new List<string>();
        List<List<string>> answers = new List<List<string>>();
        Dictionary<Tuple<int,string,int>, List<string>> dict = new Dictionary<Tuple<int,string,int>, List<string>>();
        int currentCard = 1;
        int totalCards = 0;
        String answer = "";
        String question = "";
        String answersFileName = "";
        Boolean front = true;
        int answerCounter = 0;
        int questionCounter = 0;
        Form1 a = new Form1();
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void ImportQuestionsButton_Click(object sender, EventArgs e)
        {
            // Filter for text files
            openFileDialog1.Filter = "Text files (*.txt)|*.txt";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {                
                dict.Clear();
                questions.Clear();
                string line;
                System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName);
                questionCounter = 0;
                // Add each line of the questions file to the questions list
                while ((line = sr.ReadLine()) != null)
                {
                    questions.Add(line);
                    questionCounter++;
                }
                sr.Close();
                ImportAnswersButton.Enabled = true;
                // Check if the question and answer files are the same length
                if (answerCounter == questionCounter)
                {
                    startButton.Enabled = true;
                    randomBox.Enabled = true;
                    errorLabel.Text = "";
                }
                else if (answerCounter != 0)
                {
                    errorLabel.Text = "Questions and answers are not the same length. Please try again.";
                    startButton.Enabled = false;
                    randomBox.Enabled = false;
                }
            }
            
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            a.Show();
            this.Hide();
        }

        private void ImportAnswersButton_Click(object sender, EventArgs e)
        {
            openFileDialog2.Filter = "Text files (*.txt)|*.txt";
            if (openFileDialog2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                answerCounter = 0;
                answers.Clear();
                string line;
                System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog2.FileName);
                answersFileName = Path.GetFileNameWithoutExtension(openFileDialog2.FileName);
                // Add each line of the answers file to the answers list
                // '//APPENDANSWER' means that there are multiple answers
                // correlated to one question
                while ((line = sr.ReadLine()) != null)
                {
                    List<string> answer = line.Split(new string[] { " //APPENDANSWER " }, StringSplitOptions.None).ToList<string>();
                    answers.Add(answer);
                    answerCounter++;
                }
                sr.Close();
                if(answerCounter == questionCounter)
                {
                    startButton.Enabled = true;
                    errorLabel.Text = "";
                    randomBox.Enabled = true;
                }
                else
                {
                    errorLabel.Text = "Questions and answers are not the same length. Please try again.";
                    startButton.Enabled = false;
                    randomBox.Enabled = false;
                }  
            }                                                
        }      
       
        private void startButton_Click(object sender, EventArgs e)
        {
            messageBox.Text = "";
            int count = 0;
            dict.Clear();
            var rnd = new Random();
            // Randomize questions and answers
            var priority = Enumerable.Range(0, answers.Count).OrderBy(x => rnd.Next()).Take(answers.Count).ToList();
            if (!randomBox.Checked)
            {
                // Keep questions and answers in original order
                priority = Enumerable.Range(0, answers.Count).Take(answers.Count).ToList();
            }
            foreach (List<string> answer in answers)
            {
                if (count >= questionCounter && count >= answerCounter)
                {
                    break;
                }
                // First param is card number, second param is question,
                // Third param is card order
                var tuple = new Tuple<int, string, int>(count, questions.ElementAt(count), priority.ElementAt(count));
                if (!dict.ContainsKey(tuple) && !dict.ContainsValue(answer))
                {
                    dict.Add(tuple, answer);
                    count++;
                }
            }
            startButton.Text = "Restart";
            totalCards = dict.Count;
            currentCard = 1;
            CardCountLabel.Text = currentCard + "/" + totalCards;
            CancelSelectionButton.Enabled = true;
            ImportQuestionsButton.Enabled = false;
            ImportAnswersButton.Enabled = false;
            AddAnotherAnswerButton.Enabled = true;
            randomBox.Enabled = true;
            if(totalCards > 1)
            {
                NextButton.Enabled = true;
            }
            answer = "";
            foreach (KeyValuePair<Tuple<int,string,int>, List<string>> entry in dict)
              {
                if (entry.Key.Item3 == currentCard-1)
                {
                    question = entry.Key.Item2;
                    cardButton.Text = question;
                    int counting = 0;
                    foreach (string item in entry.Value)
                    {
                        if (counting != entry.Value.Count-1)
                        {
                            answer += item + ", ";
                        }
                        else
                        {
                            answer += item;
                        }
                        counting++;
                    }
                }
              }
        }
       
        private void PreviousButton_Click(object sender, EventArgs e)
        {
            messageBox.Text = "";
            if (currentCard <= 2)
            {
                PreviousButton.Enabled = false;
            }
            NextButton.Enabled = true;
            answer = "";
            currentCard--;
            CardCountLabel.Text = currentCard.ToString() + "/" + totalCards.ToString();
            // Iterate through the dictionary
            foreach (KeyValuePair<Tuple<int, string,int>, List<string>> entry in dict)
            {
                if (entry.Key.Item3 == currentCard-1)
                {
                    question = entry.Key.Item2;
                    cardButton.Text = question;
                    int count = 0;
                    foreach (string item in entry.Value)
                    {
                        // If this is not the final answer, append the answer and a comma
                        // Otherwise, just append the answer
                        if (count != entry.Value.Count-1)
                        {
                            answer += item + ", ";
                        }
                        else
                        {
                            answer += item;
                        }
                        count++;
                    }
                }
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            messageBox.Text = "";
            if (totalCards > 1)
            {
                PreviousButton.Enabled = true;
            }
            if(currentCard >= questionCounter-1)
            {
                NextButton.Enabled = false;
            }
            answer = "";            
            currentCard++;
            CardCountLabel.Text = currentCard.ToString() + "/" + totalCards.ToString();
            foreach (KeyValuePair<Tuple<int, string,int>, List<string>> entry in dict)
            {
                if (entry.Key.Item3 == currentCard - 1)
                {
                    question = entry.Key.Item2;
                    cardButton.Text = question;
                    int counting = 0;
                    foreach (string item in entry.Value)
                    {
                        if (counting != entry.Value.Count - 1)
                        {
                            answer += item + ", ";
                        }
                        else
                        {
                            answer += item;
                        }
                        counting++;
                    }
                }
            }
        }

        private void AddAnotherAnswerButton_Click(object sender, EventArgs e)
        {
            string userInput = userInputTextBox.Text;
            if (addAnswerRButton.Checked)
            {
                foreach (KeyValuePair<Tuple<int, string, int>, List<string>> entry in dict)
                {
                    int counter = 0;
                    // Check if list of answers for that question already contains that answer
                    if (entry.Key.Item3 == currentCard - 1 && !entry.Value.Contains(userInput, StringComparer.OrdinalIgnoreCase)
                        && userInput != "")
                    {
                        // Read the answers file
                        using (var input = File.OpenText(answersFileName + ".txt"))
                        // Create a temporary answers file
                        using (var output = new StreamWriter(answersFileName + " Temp.txt"))
                        {
                            string line;                            
                            while (null != (line = input.ReadLine()))
                            {
                                // Check if the counter corresponds the question
                                // and append the userInput to the list of answers
                                // for that question
                                if (counter == entry.Key.Item1)
                                {
                                    // Write to the temporary file
                                    line += " //APPENDANSWER " + userInput;
                                    output.WriteLine(line);
                                }
                                else
                                {
                                    output.WriteLine(line);
                                }
                                counter++;
                            }
                        }
                        // Replace the original file with the temporary file and delete the 
                        // temporary file
                        File.Replace(answersFileName + " Temp.txt", answersFileName + ".txt", null);
                        answer = "";
                        for (int i = 0; i < entry.Value.Count; i++)
                        {                           
                                answer += entry.Value.ElementAt(i) + ", ";                                                      
                        }
                        entry.Value.Add(userInput);
                        answer += userInput;
                        messageBox.Text = "Answer was added successfully";
                    }
                    else if(entry.Key.Item3 == currentCard - 1 && entry.Value.Contains(userInput, StringComparer.OrdinalIgnoreCase)
                        && userInput != "")
                    {
                        messageBox.Text = "Answer list already contains this answer";
                    }
                }
            }
            else if (removeAnswerRButton.Checked)
            {
                foreach (KeyValuePair<Tuple<int, string, int>, List<string>> entry in dict)
                {
                    int counter = 0;
                    if(entry.Key.Item3 == currentCard - 1 && entry.Value.Contains(userInput, StringComparer.OrdinalIgnoreCase)
                        && userInput != "" && entry.Value.Count == 1)
                    {
                        messageBox.Text = "Answer could not be removed since it is the only one left";
                    }
                    if (entry.Key.Item3 == currentCard - 1 && entry.Value.Contains(userInput, StringComparer.OrdinalIgnoreCase)
                        && userInput != "" && entry.Value.Count > 1)
                    {
                        entry.Value.RemoveAll(o => o.Equals(userInput, StringComparison.OrdinalIgnoreCase));
                        messageBox.Text = "Answer was removed successfully";
                        using (var input = File.OpenText(answersFileName + ".txt"))
                        using (var output = new StreamWriter(answersFileName + " Temp.txt"))
                        {
                            string line;
                            while (null != (line = input.ReadLine()))
                            {
                                if (counter == entry.Key.Item1)
                                {
                                    line = "";
                                    for (int i = 0; i < entry.Value.Count; i++)
                                    {
                                        // If this is not the first answer, write '//APPENDANSWER'
                                        if (i != 0)
                                        {
                                            line += " //APPENDANSWER " + entry.Value.ElementAt(i);
                                        }
                                        else
                                        {
                                            line += entry.Value.ElementAt(i);
                                        }
                                    }
                                    output.WriteLine(line);
                                }
                                else
                                {
                                    output.WriteLine(line);
                                }
                                counter++;
                            }
                        }
                        File.Replace(answersFileName + " Temp.txt", answersFileName + ".txt", null);
                        answer = "";
                        for (int i = 0; i < entry.Value.Count; i++)
                        {
                            if (i != entry.Value.Count - 1)
                            {
                                answer += entry.Value.ElementAt(i) + ", ";
                            }
                            else
                            {
                                answer += entry.Value.ElementAt(i);
                            }
                        }
                    }
                    else if(entry.Key.Item3 == currentCard - 1 && !entry.Value.Contains(userInput, StringComparer.OrdinalIgnoreCase)
                        && userInput != "")
                    {
                        messageBox.Text = "Answer could not be found.";
                    }
                }
            }
            else
            {
                messageBox.Text = "Click one of the two radio buttons.";
            }
            userInputTextBox.Text = "";            
        }

        private void CancelSelectionButton_Click(object sender, EventArgs e)
        {
            messageBox.Text = "";
            ImportQuestionsButton.Enabled = true;
            startButton.Enabled = false;
            PreviousButton.Enabled = false;
            NextButton.Enabled = false;
            AddAnotherAnswerButton.Enabled = false;
            CancelSelectionButton.Enabled = false;
            randomBox.Enabled = false;
            dict.Clear();
            totalCards = 0;
            currentCard = 1;
            CardCountLabel.Text = "0/0";
            cardButton.Text = "";
            answer = "";
            startButton.Text = "Start";

        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {            
            a.Show();
            this.Hide();
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {

        }
        private void Form2_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
        private void Form2_KeyUp(object sender, KeyEventArgs e)
        {

        }
        
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Left Key
            if (keyData == Keys.Left && !userInputTextBox.Focused)
            {
                PreviousButton.PerformClick();
                return true;
            }
            // Right Key
            else if(keyData == Keys.Right && !userInputTextBox.Focused)
            {
                NextButton.PerformClick();
                return true;
            }
            // Space Key
            else if(keyData == Keys.Space && !userInputTextBox.Focused)
            {
                cardButton.PerformClick();
                return true;
            }
            // Enter Key
            else if(keyData == Keys.Enter && userInputTextBox.Focused)
            {
                AddAnotherAnswerButton.PerformClick();
                cardButton.Focus();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Form2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
           
        }
        

        private void cardButton_Click(object sender, EventArgs e)
        {            
            cardButton.Text = front ? answer : question;
            front = front ? false : true;
        }      
      
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (startButton.Text == "Restart") {
                messageBox.Text = "Click the Restart Button to change the order of the cards";
            }
        }
    }
 
}
