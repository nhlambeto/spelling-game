using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INF164HWAss1
{
    public class GameClass
    {
        public int scorePlayer { get; set; }
        public int scoreEnemy { get; set; }

        public int healthPlayer { get; set; }

        private TimeSpan gameTime;
        public TimeSpan GameTime
        {
            get { return gameTime; }
            set { gameTime = value; }
        }
        private List<string> FruitNames { get; set; }
        public string CurrentFruit { get; set; }

        public event Action<int, int, TimeSpan> OnTimerTick;
        public event Action<string, string> OnNextFruit;
        public event Action OnGameOver;

        private Timer gameTimer;
        private Random random;

        public GameClass(int initialHealth)
        {
            healthPlayer = initialHealth;
            scorePlayer = 0;
            scoreEnemy = 0;
            GameTime = TimeSpan.FromSeconds(30);

            gameTimer = new Timer();
            gameTimer.Interval = 1000;
            gameTimer.Tick += GameTimer_Tick;

            random = new Random();
        }

        public void Start(List<string> fruitNames)
        {
            FruitNames = new List<string>(fruitNames);
            LoadNextFruit();
            gameTimer.Start();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            gameTime = gameTime.Subtract(TimeSpan.FromSeconds(1));
            OnTimerTick?.Invoke(scorePlayer, scoreEnemy, GameTime);

            if (gameTime.TotalSeconds <= 0)
            {
                gameTimer.Stop();
                OnGameOver?.Invoke();
            }
        }

        public void LoadNextFruit()
        {
            if (FruitNames.Count == 0)
            {
                gameTimer.Stop();
                OnGameOver?.Invoke();
                return;
            }

            int index = random.Next(FruitNames.Count);
            CurrentFruit = FruitNames[index];
            FruitNames.RemoveAt(index);

            string incompleteFruit = CreateIncompleteFruitName(CurrentFruit);
            OnNextFruit?.Invoke(CurrentFruit, incompleteFruit);
        }

        private string CreateIncompleteFruitName(string fruitName)
        {
            int removeIndex = random.Next(1, fruitName.Length - 1);
            return fruitName.Substring(0, removeIndex) + "_" + fruitName.Substring(removeIndex + 1);
        }

        public void CheckAnswer(string answerPlayer)
        {
            if (answerPlayer.Equals(CurrentFruit, StringComparison.OrdinalIgnoreCase))
            {
                scorePlayer += 10;
            }

            else
            {
                healthPlayer--;
                scoreEnemy += 10;
                if (healthPlayer <= 0)
                {
                    gameTimer.Stop();
                    OnGameOver?.Invoke();
                }
            }
        }
    }
}

