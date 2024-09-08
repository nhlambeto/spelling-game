using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INF164HWAss1
{
    public partial class GameForm : Form
    {
        private GameClass game;
        private int initialHealth = 5;

        public GameForm()
        {
            InitializeComponent();

            game = new GameClass(initialHealth);

            game.OnTimerTick += Game_OnTimerTick;
            game.OnNextFruit += Game_OnNextFruit;
            game.OnGameOver += Game_OnGameOver;

            List<string> fruitNames = LoadFruitNamesFromFile("FruitNames.txt");
            game.Start(fruitNames);
        }

        private List<string> LoadFruitNamesFromFile(string filepath)
        {
            List<string> fruitNames = new List<string>();
            try
            {
                string[] lines = System.IO.File.ReadAllLines(filepath);
                fruitNames.AddRange(lines);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading fruit names: " + ex.Message);
            }
            return fruitNames;
        }

        private void Game_OnTimerTick(int scorePlayer, int scoreEnemy, TimeSpan gameTime)
        {
            lblScorePlayer.Text = $"Score: {scorePlayer}";
            lblTime.Text = $"Time: {gameTime.TotalSeconds} seconds";
            lblScoreEnemy.Text = $"Enemy Score: {scoreEnemy}";
        }

        private void Game_OnNextFruit(string correctFruit, string incompleteFruit)
        {
            lblFruitName.Text = incompleteFruit;
            pbFruit.Image = GetFruitImage(correctFruit);
        }

        private Image GetFruitImage(string fruitName)
        {
            var image = Properties.Resources.ResourceManager.GetObject(fruitName) as Image;
            if (image == null)
            {
                MessageBox.Show($"Image for {fruitName} does not exist.");
            }
            return image;
        }
        private void Game_OnGameOver()
        {
            MessageBox.Show("Game over");
            ShowHighScoreForm();
        }

        private void ShowHighScoreForm()
        {
            HighScoreForm highScoreForm = new HighScoreForm();
            highScoreForm.ShowDialog();
            this.Close();
        }

        private void UpdateHealthDisplay()
        {
            switch (game.healthPlayer)
            {
                case 5:
                    this.BackgroundImage = Properties.Resources.HealthFull;
                    break;
                case 4:
                    this.BackgroundImage = Properties.Resources.HealthFour;
                    break;
                case 3:
                    this.BackgroundImage = Properties.Resources.HealthThree;
                    break;
                case 2:
                    this.BackgroundImage = Properties.Resources.HealthTwo;
                    break;
                case 1:
                    this.BackgroundImage = Properties.Resources.HealthOne;
                    break;
                default:
                    this.BackgroundImage = Properties.Resources.HealthEmpty;
                    break;
            }
        }

        private void GameForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAnswer_Click_1(object sender, EventArgs e)
        {
            string answerPlayer = txtAnswer.Text;
            game.CheckAnswer(answerPlayer);

            if (game.healthPlayer > 0)
            {
                UpdateHealthDisplay();
                game.LoadNextFruit();
            }

            txtAnswer.Clear();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            game.GameTime = game.GameTime.Add(TimeSpan.FromSeconds(1));
            lblTime.Text = $"Time: {game.GameTime.TotalSeconds} seconds";
        }
    }
}
