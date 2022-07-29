using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SurviveTheNight
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();

            Sounds theme = new Sounds();
            theme.playSoundTheme();
        }

        private void returnToMainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            MainMenu mainMenu = new MainMenu();

            mainMenu.Show();

            Sounds click = new Sounds();
            click.playSoundButtonClick();
        }
    }
}
