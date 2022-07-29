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
    public partial class GameMode : Form
    {
        public GameMode()
        {
            InitializeComponent();

            Sounds theme = new Sounds();
            theme.playSoundTheme();
        }

        private void buttonEasyMode_Click(object sender, EventArgs e)
        {
            this.Hide();

            PlayForm playForm = new PlayForm();

            playForm.Show();

            Sounds buttonClick = new Sounds();
            buttonClick.playSoundButtonClick();


        }

        private void buttonHardMode_Click(object sender, EventArgs e)
        {
            this.Hide();

            PlayFormHardMode playFormHardMode = new PlayFormHardMode();

            playFormHardMode.Show();

            Sounds buttonClick = new Sounds();
            buttonClick.playSoundButtonClick();
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            MainMenu mainMenu = new MainMenu();

            mainMenu.Show();

            Sounds buttonClick = new Sounds();
            buttonClick.playSoundButtonClick();
        }
    }
}
