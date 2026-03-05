using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

  

namespace FOTIS1B_Bernardo_Kutsukawa_FMP
{
    public class Boss
    {
        public int HP = 1000;
        public string location;
        public int bossTop;
        public int bossLeft;
        public int bossSpeed = 1;

        public PictureBox player
        {
            get
            {
                return player;
            }
        }
        private List<PictureBox> bossMovement = new List<PictureBox>();
        

        private Timer bossTimer = new Timer(); 

        public void DrawBoss(Form form)
        {
            PictureBox bossMovement = new PictureBox();
            bossMovement.Tag = "bossMovement";
            bossMovement.Image = Properties.Resources.octup;
            bossMovement.SizeMode = PictureBoxSizeMode.AutoSize;
            bossMovement.Left = bossLeft;
            bossMovement.Top = bossTop;
            bossMovement.Visible = true;
            


            form.Controls.Add(bossMovement);

            bossTimer.Interval = bossSpeed;
            bossTimer.Tick += new EventHandler(BossMS);
            bossTimer.Start();


            foreach (Control x in form.Controls)
                if (x is PictureBox && (string)x.Tag == "bossMovement")
                {
                 
                    if (x.Left > player.Left)
                    {
                        x.Left -= bossSpeed;
                        ((PictureBox)x).Image = Properties.Resources.octleft;

                    }
                    if (x.Left < player.Left)
                    {
                        x.Left += bossSpeed;
                        ((PictureBox)x).Image = Properties.Resources.octright;

                    }
                    if (x.Top > player.Top)
                    {
                        x.Top -= bossSpeed;
                        ((PictureBox)x).Image = Properties.Resources.octdown;

                    }
                    if (x.Top < player.Top)
                    {
                        x.Top += bossSpeed;
                        ((PictureBox)x).Image = Properties.Resources.octup;

                    }
                }


           
        }
    

      
            

        public void BossMS(object sender, EventArgs e)
        {
            PictureBox bossMovement = new PictureBox();
            bossMovement.Tag = "bossMovement";
            bossMovement.Image = Properties.Resources.octup;
            bossMovement.SizeMode = PictureBoxSizeMode.AutoSize;
            bossMovement.Left = bossLeft;
            bossMovement.Top = bossTop;
            bossMovement.Visible = true;

            if (location == "left")
            {
                bossMovement.Left -= bossSpeed;
            }

            if (location == "right")
            {
                bossMovement.Left += bossSpeed;

            }

            if (location == "up")
            {
                bossMovement.Top -= bossSpeed;
            }

            if (location == "down")
            {
                bossMovement.Top += bossSpeed;
            }
        }





    }
}
