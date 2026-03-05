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

        
        int playerHealth = 100;        
        int score;
        int speed = 10;
        int ammo = 10;
        bool goLeft, goRight, goUp, goDown, gameOver;
        string facing = "up";
        int crocSpeed = 2;
        int octSpeed = 1;
        int crabSpeed = 3;


        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;
                return handleParam;
            }
        }

        Random randNum = new Random();

        List<PictureBox> crocsList = new List<PictureBox>();
        List<PictureBox> octsList = new List<PictureBox>();
        List<PictureBox> crabsList = new List<PictureBox>();

        public Form1()
        {
            InitializeComponent();
            startgame();
            

        }


        void startgame()
        {
            Wave.Visible = true;
            Wave2.Visible = false;
            Wave3.Visible = false;
            Congrats.Visible = false;
            over.Visible = false;
            restart.Visible = false;

            for (int i = 0; i < 3; i++)
            {
                MakeCrocs();
            }
        }

        

        private void MainTimerEvent(object sender, EventArgs e)
        {


            if (playerHealth > 1)
            {
                healthBar.Value = playerHealth;
            }
            
            else
            {
                over.Visible = true;
                restart.Visible = true;
                gameOver = true;
                player.Image = Properties.Resources.turtdead;
                GameTimer.Stop();
                over.BringToFront();
                restart.BringToFront();
            }

            if (healthBar.Value == 50)
            {
                DropHealth();
            }

            if (score == 5)
            {
                Wave.Visible = false;
                Wave2.Visible = true;
                Wave3.Visible = false;


                foreach (PictureBox i in crocsList)
                {

                    this.Controls.Remove(i);

                    for (int k = 0; k < 2; k++)
                    {
                        MakeOcts();
                    }

                }
                crocsList.Clear();


            }
            if (score == 10)
            {
                Wave.Visible = false;
                Wave2.Visible = false;
                Wave3.Visible = true;


                foreach (PictureBox i in octsList)
                {

                    this.Controls.Remove(i);

                    for (int l = 0; l < 1; l++)
                    {
                        MakeCrabs();
                    }

                }
                octsList.Clear();


            }



            if (score == 13)
            {
                Congrats.Visible = true;
                GameTimer.Stop();
                Congrats.BringToFront();
            }

         

            txtAmmo.Text = "Ammo: " + ammo;
            txtScore.Text = "Enemies Killed: " + score;



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
                        ammo += 5;
                    }
                }

                if (x is PictureBox && (string)x.Tag == "health")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                        playerHealth += 40;
                    }
                }

                if (x is PictureBox && (string)x.Tag == "crabs")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        playerHealth -= 1;

                    }
                    if (x.Left > player.Left)
                    {

                        x.Left -= crabSpeed;
                        ((PictureBox)x).Image = Properties.Resources.crableft;

                    }
                    if (x.Left < player.Left)
                    {
                        x.Left += crabSpeed;
                        ((PictureBox)x).Image = Properties.Resources.crabright;

                    }
                    if (x.Top > player.Top)
                    {
                        x.Top -= crabSpeed;
                        ((PictureBox)x).Image = Properties.Resources.crabdown;

                    }
                    if (x.Top < player.Top)
                    {
                        x.Top += crabSpeed;
                        ((PictureBox)x).Image = Properties.Resources.crabup;

                    }
                }

                if (x is PictureBox && (string)x.Tag == "octs")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        playerHealth -= 1;

                    }
                    if (x.Left > player.Left)
                    {

                        x.Left -= octSpeed;
                        ((PictureBox)x).Image = Properties.Resources.octleft;

                    }
                    if (x.Left < player.Left)
                    {
                        x.Left += octSpeed;
                        ((PictureBox)x).Image = Properties.Resources.octright;

                    }
                    if (x.Top > player.Top)
                    {
                        x.Top -= octSpeed;
                        ((PictureBox)x).Image = Properties.Resources.octdown;

                    }
                    if (x.Top < player.Top)
                    {
                        x.Top += octSpeed;
                        ((PictureBox)x).Image = Properties.Resources.octup;

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

                foreach (Control k in this.Controls)
                {
                    if (k is PictureBox && (string)k.Tag == "bullet" && x is PictureBox && (string)x.Tag == "octs")
                    {
                        if (x.Bounds.IntersectsWith(k.Bounds))
                        {
                            score++;

                            this.Controls.Remove(k);
                            ((PictureBox)k).Dispose();
                            this.Controls.Remove(x);
                            ((PictureBox)x).Dispose();
                            octsList.Remove(((PictureBox)x));
                            MakeOcts();
                        }
                    }
                }

                foreach (Control l in this.Controls)
                {
                    if (l is PictureBox && (string)l.Tag == "bullet" && x is PictureBox && (string)x.Tag == "crabs")
                    {
                        if (x.Bounds.IntersectsWith(l.Bounds))
                        {
                            score++;

                            this.Controls.Remove(l);
                            ((PictureBox)l).Dispose();
                            this.Controls.Remove(x);
                            ((PictureBox)x).Dispose();
                            octsList.Remove(((PictureBox)x));
                            MakeCrabs();
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

            if (e.KeyCode == Keys.Space && ammo > 0 && gameOver == false )
            {
                ammo--;
                ShootBullet(facing);

                if (ammo < 1)
                {
                    DropAmmo();
                }

                
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

        private void MakeOcts()
        {
            PictureBox octs = new PictureBox();
            octs.Tag = "octs";
            octs.Image = Properties.Resources.octup;
            octs.Left = randNum.Next(0, 500);
            octs.Top = randNum.Next(0, 500);
            octs.SizeMode = PictureBoxSizeMode.AutoSize;
            octsList.Add(octs);
            this.Controls.Add(octs);
            player.BringToFront();
        }

        private void MakeCrabs()
        {
            PictureBox crabs = new PictureBox();
            crabs.Tag = "crabs";
            crabs.Image = Properties.Resources.crabup;
            crabs.Left = randNum.Next(0, 500);
            crabs.Top = randNum.Next(0, 500);
            crabs.SizeMode = PictureBoxSizeMode.AutoSize;
            crabsList.Add(crabs);
            this.Controls.Add(crabs);
            player.BringToFront();
        }

        private void DropAmmo()
        {
            PictureBox ammo = new PictureBox();
            ammo.Image = Properties.Resources.bubbleammo;
            ammo.SizeMode = PictureBoxSizeMode.AutoSize;
            ammo.Left = randNum.Next(60, this.ClientSize.Width - ammo.Width);
            ammo.Top = randNum.Next(60, this.ClientSize.Height - ammo.Height);
            ammo.Tag = "ammo";
            this.Controls.Add(ammo);
            
            ammo.BringToFront();
            player.BringToFront();

        }

        private void DropHealth()
        {
            PictureBox health = new PictureBox();
            health.Image = Properties.Resources.health;
            health.SizeMode = PictureBoxSizeMode.AutoSize;
            health.Left = randNum.Next(10, this.ClientSize.Width - health.Width);
            health.Top = randNum.Next(60, this.ClientSize.Height - health.Height);
            health.Tag = "health";
            this.Controls.Add(health);

            health.BringToFront();
            player.BringToFront();

        }




        private void restart_Click(object sender, EventArgs e)
        {
            
            Application.Restart();
            
        }

    }
}
