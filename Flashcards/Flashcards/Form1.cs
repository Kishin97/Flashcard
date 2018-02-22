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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StudyButton_Click(object sender, EventArgs e)
        {
            // Open Study Mode and hide this window
            Form2 m = new Form2();
            m.Show();
            this.Hide();
        }

        private void QuizButton_Click(object sender, EventArgs e)
        {
            // Open Quiz Mode and hide this window
            Quiz_Mode a = new Quiz_Mode();
            a.Show();
            this.Hide();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

       

        private void helpButton_Click(object sender, EventArgs e)
        {        
            // Open Help and hide this window
            Help a = new Help();
            a.Show();
            this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
