using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Media;

namespace SurviveTheNight
{
    public partial class PlayForm : Form
    {

        bool goLeft;
        bool goRight;
        bool goUp;
        bool goDown;
        bool gameOver; //bool to check if game over is t or f. 

        string facing = "up"; // sets char default to face up

        int playerHealth = 100; // var to set player health using progress bar // chage name to Hero
        int speed = 10;         // var to set speed of hero's movement
        int zombieSpeed = 3;    // var to set speed of zombies movement
        int ammo = 10;          // var for how much bullets the hero starts with    
        int score;              // var that hold how many kills the hero has
        List<PictureBox> zombieList = new List<PictureBox>();

        Random randomNumber = new Random();


        public PlayForm()
        {
            Sounds theme = new Sounds();
            theme.playSoundTheme();

            InitializeComponent();
            RestartGame();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sounds buttonClick = new Sounds();
            buttonClick.playSoundButtonClick();

            RestartGame();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sounds buttonClick = new Sounds();
            buttonClick.playSoundButtonClick();

            Application.Exit();
        }

        private void MainTimerEvent(object sender, EventArgs e)
        {
            if (playerHealth > 1)
            {
                progressBarHealth.Value = playerHealth;
            }
            else
            {
                Sounds death = new Sounds();
                death.playSoundDeath();

                gameOver = true;
                player.Image = Properties.Resources.dead;
                gameTimer.Stop();

                MessageBox.Show("You Died! Press Enter or click File > New Game Play Again");
            }

            labelAmmo.Text = "Ammo: " + ammo;  //takes the ammo thats stored in the variable and places it beside the ammo logo
            labelScore.Text = "Score:" + score; // takes the kills and places it beside the Score label

            if (goLeft == true && player.Left > 0)
            {
                player.Left -= speed;  //if the player presses the left key then the hero will go left at the speed that is initialize 
            }
            if (goRight == true && player.Left + player.Width < this.ClientSize.Width)
            {
                player.Left += speed; //if the player presses the right key then the hero will go right at the speed that is initialize 
            }
            if (goUp == true && player.Top > 0)
            {
                player.Top -= speed;  //if the player presses the up key then the hero will go up at the speed that is initialize 
            }
            if (goDown == true && player.Top + player.Height < this.ClientSize.Height)
            {
                player.Top += speed;  //if the player presses the down key then the hero will go down at the speed that is initialize 
            }


            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "ammo")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                        ammo += 5;

                        Sounds ammoGrab = new Sounds();
                        ammoGrab.playSoundAmmoPickUp();
                    }
                }


                if (x is PictureBox && (string)x.Tag == "zombie")
                {

                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        playerHealth -= 1;
                    }

                    if (x.Left > player.Left)
                    {
                        x.Left -= zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zleft;
                    }
                    if (x.Left < player.Left)
                    {
                        x.Left += zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zright;
                    }
                    if (x.Top > player.Top)
                    {
                        x.Top -= zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zup;
                    }
                    if (x.Top < player.Top)
                    {
                        x.Top += zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zdown;
                    }
                }

                foreach (Control j in this.Controls)
                {
                    if (j is PictureBox && (string)j.Tag == "bullet" && x is PictureBox && (string)x.Tag == "zombie")
                    {
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                            score++;

                            this.Controls.Remove(j);
                            ((PictureBox)j).Dispose();
                            this.Controls.Remove(x);
                            ((PictureBox)x).Dispose();

                            zombieList.Remove(((PictureBox)x));

                            MakeZombies();
                        }
                    }
                }

            }

        }


        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (gameOver == true)
            {
                return;
            }


            if (e.KeyCode == Keys.A)
            {
                goLeft = true;
                facing = "left";
                player.Image = Properties.Resources.left; // if the player presses the left key then game will grab the image in resourse of the hero facing left
            }

            if (e.KeyCode == Keys.D)
            {
                goRight = true;
                facing = "right";
                player.Image = Properties.Resources.right; // if the player presses the right key then game will grab the image in resourse of the hero facing right
            }

            if (e.KeyCode == Keys.W)
            {
                goUp = true;
                facing = "up";
                player.Image = Properties.Resources.up; // if the player presses the up key then game will grab the image in resourse of the hero facing up
            }

            if (e.KeyCode == Keys.S)
            {
                goDown = true;
                facing = "down";
                player.Image = Properties.Resources.down; // if the player presses the down key then game will grab the image in resourse of the hero facing down
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                goLeft = false;   // if key A is not pressed then the hero will not got left

            }

            if (e.KeyCode == Keys.D)
            {
                goRight = false;  // if key D is not pressed then the hero will not got Right

            }

            if (e.KeyCode == Keys.W)
            {
                goUp = false;  // if key W is not pressed then the hero will not got up

            }

            if (e.KeyCode == Keys.S)
            {
                goDown = false;  // if key S is not pressed then the hero will not got down

            }

            if (e.KeyCode == Keys.Space && ammo > 0 && gameOver == false)
            {
                ammo--;
                ShootBullet(facing); // ammo decreases by 1 everytime the hero shoots bullets

                if (ammo < 1)
                {
                    DropAmmo();  // if the hero's ammo reaches zero then the game will drop a ammmo pack at a random location on the map
                }
            }

            if (e.KeyCode == Keys.Enter && gameOver == true)
            {
                RestartGame();
            }
        }
        private void ShootBullet(string direction)
        {
            Bullet shootBullet = new Bullet();
            shootBullet.direction = direction;
            shootBullet.bulletLeft = player.Left + (player.Width / 2);
            shootBullet.bulletTop = player.Top + (player.Height / 2);
            shootBullet.MakeBullet(this);

            Sounds gun = new Sounds();
            gun.playSoundWeapon();
        }

        private void MakeZombies()
        {
            PictureBox zombie = new PictureBox();
            zombie.Tag = "zombie";
            zombie.Image = Properties.Resources.zdown; // goes through the resourses and looks for the image zdown 
            zombie.Left = randomNumber.Next(0, 900);   // pick a random x and y coordinate and spawns a zombie
            zombie.Top = randomNumber.Next(0, 800);
            zombie.SizeMode = PictureBoxSizeMode.AutoSize; // the size of the zombie

            zombieList.Add(zombie);

            this.Controls.Add(zombie);

            player.BringToFront();
        }

        private void DropAmmo()
        {
            PictureBox ammo = new PictureBox();
            ammo.Image = Properties.Resources.ammo_Image;
            ammo.SizeMode = PictureBoxSizeMode.AutoSize;
            ammo.Left = randomNumber.Next(10, this.ClientSize.Width - ammo.Width);
            ammo.Top = randomNumber.Next(60, this.ClientSize.Height - ammo.Height);
            ammo.Tag = "ammo";

            this.Controls.Add(ammo);

            ammo.BringToFront();
            player.BringToFront();

            Sounds ammoDrop = new Sounds();
            ammoDrop.playSoundAmmoDrop();

        }

        private void RestartGame()
        {
            player.Image = Properties.Resources.up;

            

            foreach (PictureBox i in zombieList)
            {
                this.Controls.Remove(i);

               
            }

            zombieList.Clear();

            for (int i = 0; i < 3; i++)
            {
                MakeZombies();
            }

            goUp = false;
            goDown = false;
            goLeft = false;
            goRight = false;

            gameOver = false;

            playerHealth = 100;
            score = 0;
            ammo = 10;

            gameTimer.Start();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            MainMenu mainMenu = new MainMenu();

            mainMenu.Show();

            Sounds buttonClick = new Sounds();
            buttonClick.playSoundButtonClick();

        }

        private void PlayForm_Load(object sender, EventArgs e)
        {

        }

        //private void showP2ToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    groupBoxP2.Visible = true;
        //}

        //private void hideP2ToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    groupBoxP2.Visible = false;
        //}

        //private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    RestartGame();
        //}
    }

}

    

