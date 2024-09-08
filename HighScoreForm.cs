using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.LinkLabel;

namespace INF164HWAss1
{
    public partial class HighScoreForm : Form
    {
        public HighScoreForm()
        {
            InitializeComponent();
            InitializeDataGridView();
            LoadHighScores();

        }

        private void InitializeDataGridView()
        {
            dgvHighScores.Columns.Clear();


            dgvHighScores.Columns.Add("PlayerName", "Player Name");
            dgvHighScores.Columns.Add("CorrectAnswers", "Correct Answers");
            dgvHighScores.Columns.Add("WrongAnswers", "Wrong Answers");


            dgvHighScores.Columns["PlayerName"].Width = 150;
            dgvHighScores.Columns["CorrectAnswers"].Width = 150;
            dgvHighScores.Columns["WrongAnswers"].Width = 150;
        }

        private void LoadHighScores()
        {
            string filePath = "highscores.txt";

            if (File.Exists(filePath))
            {

                dgvHighScores.Rows.Clear();


                string[] lines = File.ReadAllLines(filePath);


                foreach (string line in lines)
                {
                    string[] columns = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);


                    if (columns.Length == 3)
                    {

                        dgvHighScores.Rows.Add(columns[0], columns[1], columns[2]);
                    }
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            WelcomeForm welcomeForm = new WelcomeForm();
            welcomeForm.Show();
            this.Hide();
        }
    }
}
