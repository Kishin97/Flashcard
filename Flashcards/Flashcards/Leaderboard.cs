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
    public partial class Leaderboard : Form
    {
        public Leaderboard()
        {
            InitializeComponent();
        }

        private void importLeaderboardButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text files (*.txt)|*.txt";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {               
                string name;
                int x = 1;
                int y = 1;
                System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName);
                // Format for filling out the leaderboard
                while ((name = sr.ReadLine()) != null)
                {
                    String score = sr.ReadLine();
                    String time = sr.ReadLine();
                    String date = sr.ReadLine();
                    tableLayoutPanel1.GetControlFromPosition(x, y).Text = name;
                    x++;
                    tableLayoutPanel1.GetControlFromPosition(x, y).Text = score;
                    x++;
                    tableLayoutPanel1.GetControlFromPosition(x, y).Text = time;
                    x++;
                    tableLayoutPanel1.GetControlFromPosition(x, y).Text = date;
                    x = 1;
                    y++;
                }
                sr.Close();               
            }
        }
     
        private void exitLeaderBoardButton_Click(object sender, EventArgs e)
        {
            Quiz_Mode a = new Quiz_Mode();
            this.Hide();
            a.Show();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Quiz_Mode a = new Quiz_Mode();
            this.Hide();
            a.Show();
        }     
    }
}
