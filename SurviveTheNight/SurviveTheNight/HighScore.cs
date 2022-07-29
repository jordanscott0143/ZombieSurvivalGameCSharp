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
    public partial class HighScore : Form
    {
        public HighScore()
        {
            Sounds theme = new Sounds();
            theme.playSoundTheme();
            InitializeComponent();
        }

        private void labelMenuTitle_Click(object sender, EventArgs e)
        {

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            MainMenu mainMenu = new MainMenu();

            mainMenu.Show();

            Sounds buttonClick = new Sounds();
            buttonClick.playSoundButtonClick();
        }
    }
}
