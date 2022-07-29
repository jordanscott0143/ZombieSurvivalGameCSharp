using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace SurviveTheNight
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();

            Sounds theme = new Sounds();
            theme.playSoundTheme();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void buttonPlayForm_Click(object sender, EventArgs e)
        {
            this.Hide();

            GameMode gameMode = new GameMode();

            gameMode.Show();

            Sounds buttonClick = new Sounds();
            buttonClick.playSoundButtonClick();
        }

        private void buttonHighScore_Click(object sender, EventArgs e)
        {
            this.Hide();

            HighScore highScore = new HighScore();

            highScore.Show();

            Sounds buttonClick = new Sounds();
            buttonClick.playSoundButtonClick();
        }

        private void buttonHelpForm_Click(object sender, EventArgs e)
        {
            this.Hide();

            HelpForm helpForm = new HelpForm();

            helpForm.Show();

            Sounds buttonClick = new Sounds();
            buttonClick.playSoundButtonClick();
        }


        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

            Sounds buttonClick = new Sounds();
            buttonClick.playSoundButtonClick();
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            this.Hide();

            About aboutForm = new About();

            aboutForm.Show();

            Sounds buttonClick = new Sounds();
            buttonClick.playSoundButtonClick();
        }
    }
}
