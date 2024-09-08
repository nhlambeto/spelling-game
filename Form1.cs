using System;
using System.IO;
using System.Media;
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
    public partial class WelcomeForm : Form
    {
        private SoundPlayer backgroundMusic;
        public WelcomeForm()
        {
            InitializeComponent();
            InitializeMusic();
        }
        private void btnPlay_Click(object sender, EventArgs e)
        {
             GameForm GameForm = new GameForm();
             GameForm.Show();
             this.Hide();
        }
        private void btnInstructions_Click(object sender, EventArgs e)
        {
            string instructions = File.ReadAllText("Instructions.txt");
            MessageBox.Show(instructions, "Instructions");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InitializeMusic()
        {
            backgroundMusic = new SoundPlayer(@"backgroundmusic.wav");
            backgroundMusic.PlayLooping();
        }

        private void btnMute_Click(object sender, EventArgs e)
        {
            backgroundMusic.Stop();
        }

        
    }
}
