using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOTIS1B_Bernardo_Kutsukawa_FMP
{
    public partial class Form1 : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;
                return handleParam;
            }
        }

        bool goLeft, goRight, goUp, goDown, gameOver;
        string facing = "up";
        public int playerHealth = 100;
        int score;
        int speed = 10;
        int ammo = 10;
        int crocSpeed = 2;
        int location;

        Random randNum = new Random();

        List<PictureBox> crocsList = new List<PictureBox>();

        public Form1()
        {
            InitializeComponent();
            RestartGame();
        }

        public Boss finalBoss = new Boss();



        private void MainTimerEvent(object sender, EventArgs e)
        {

            if (playerHealth > 1)
            {
                healthBar.Value = playerHealth;

            }
            else
            {
                gameOver = true;
                player.Image = Properties.Resources.turtdead;
                GameTimer.Stop();
            }

            txtAmmo.Text = "Ammo: " + ammo;
            txtScore.Text = "Crocs Hunted: " + score;

            if (goLeft == true && player.Left > 0)
            {
                player.Left -= speed;
            }

            if (goRight == true && player.Left + player.Width < this.ClientSize.Width)
            {
                player.Left += speed;
            }

            if (goUp == true && player.Top > 47)
            {
                player.Top -= speed;
            }

            if (goDown == true && player.Top + player.Height < this.ClientSize.Height)
            {
                player.Top += speed;
            }

            


            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "ammo")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                        ammo += 6;
                    }
                }

                if (x is PictureBox && (string)x.Tag == "crocs")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        playerHealth -= 1;
                    }

                    if (x.Left > player.Left)
                    {
                        x.Left -= crocSpeed;
                        ((PictureBox)x).Image = Properties.Resources.crocleft;

                    }
                    if (x.Left < player.Left)
                    {
                        x.Left += crocSpeed;
                        ((PictureBox)x).Image = Properties.Resources.crocright;

                    }
                    if (x.Top > player.Top)
                    {
                        x.Top -= crocSpeed;
                        ((PictureBox)x).Image = Properties.Resources.crocup;

                    }
                    if (x.Top < player.Top)
                    {
                        x.Top += crocSpeed;
                        ((PictureBox)x).Image = Properties.Resources.crocdown;

                    }
                }

                foreach (Control j in this.Controls)
                {
                    if (j is PictureBox && (string)j.Tag == "bullet" && x is PictureBox && (string)x.Tag == "crocs")
                    {
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                            score++;

                            this.Controls.Remove(j);
                            ((PictureBox)j).Dispose();
                            this.Controls.Remove(x);
                            ((PictureBox)x).Dispose();
                            crocsList.Remove(((PictureBox)x));
                            MakeCrocs();
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
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
                facing = "left";
                player.Image = Properties.Resources.turtleft;


            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
                facing = "right";
                player.Image = Properties.Resources.turtright;
            }

            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
                facing = "up";
                player.Image = Properties.Resources.turtup;
            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
                facing = "down";
                player.Image = Properties.Resources.turtdown;
            }


        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }

            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }

            if (e.KeyCode == Keys.Space && ammo > 0 && gameOver == false)
            {
                ammo--;
                ShootBullet(facing);

                if (ammo < 1)
                {
                    DropAmmo();
                }
            }

            if (e.KeyCode == Keys.Enter && gameOver == true)
            {
                RestartGame();
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (score == 5)
            {

                SpawnBoss("top");

            }
        }

        

        private void ShootBullet(string direction)
        {
            Bullet shootBullet = new Bullet();
            shootBullet.direction = direction;
            shootBullet.bulletLeft = player.Left + (player.Width / 2);
            shootBullet.bulletTop = player.Top + (player.Height / 2);
            shootBullet.MakeBullet(this);
        }



        private void SpawnBoss(string location)
        {
            
            Boss spawnBoss = new Boss();
            spawnBoss.location = "top";
            spawnBoss.bossLeft = randNum.Next(10 + this.ClientSize.Width - player.Width);          
            spawnBoss.bossTop = randNum.Next(60, this.ClientSize.Height - player.Height); ;            
            spawnBoss.DrawBoss(this);
            this.Controls.Add(this);
            

           


        }


        private void MakeCrocs()
        {
            PictureBox crocs = new PictureBox();
            crocs.Tag = "crocs";
            crocs.Image = Properties.Resources.crocdown;
            crocs.Left = randNum.Next(0, 900);
            crocs.Top = randNum.Next(0, 800);
            crocs.SizeMode = PictureBoxSizeMode.AutoSize;
            crocsList.Add(crocs);
            this.Controls.Add(crocs);
            player.BringToFront();


        }

        private void DropAmmo()
        {
            PictureBox ammo = new PictureBox();
            ammo.Image = Properties.Resources.bubbleammo;
            ammo.SizeMode = PictureBoxSizeMode.AutoSize;
            ammo.Left = randNum.Next(10, this.ClientSize.Width - ammo.Width);
            ammo.Top = randNum.Next(60, this.ClientSize.Height - ammo.Height);
            ammo.Tag = "ammo";
            this.Controls.Add(ammo);

            ammo.BringToFront();
            player.BringToFront();

        }

        private void RestartGame()
        {
            player.Image = Properties.Resources.turtup;

            foreach (PictureBox i in crocsList)
            {
                this.Controls.Remove(i);
            }

            crocsList.Clear();

            for (int i = 0; i < 3; i++)
            {
                MakeCrocs();
            }

            

            goUp = false;
            goDown = false;
            goLeft = false;
            goRight = false;
            gameOver = false;

            playerHealth = 100;
            score = 0;
            ammo = 10;

            GameTimer.Start();


        }



    }
}
