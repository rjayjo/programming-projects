
namespace FOTIS1B_Bernardo_Kutsukawa_FMP
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtAmmo = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.Label();
            this.txtHealth = new System.Windows.Forms.Label();
            this.healthBar = new System.Windows.Forms.ProgressBar();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.over = new System.Windows.Forms.Label();
            this.restart = new System.Windows.Forms.Button();
            this.Congrats = new System.Windows.Forms.Label();
            this.Wave = new System.Windows.Forms.Label();
            this.Wave2 = new System.Windows.Forms.Label();
            this.Wave3 = new System.Windows.Forms.Label();
            this.player = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAmmo
            // 
            this.txtAmmo.AutoSize = true;
            this.txtAmmo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmmo.Location = new System.Drawing.Point(807, 12);
            this.txtAmmo.Name = "txtAmmo";
            this.txtAmmo.Size = new System.Drawing.Size(93, 24);
            this.txtAmmo.TabIndex = 0;
            this.txtAmmo.Text = "Ammo: 0";
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(12, 12);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(173, 24);
            this.txtScore.TabIndex = 0;
            this.txtScore.Text = "Enemies Killed: 0";
            // 
            // txtHealth
            // 
            this.txtHealth.AutoSize = true;
            this.txtHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHealth.Location = new System.Drawing.Point(319, 12);
            this.txtHealth.Name = "txtHealth";
            this.txtHealth.Size = new System.Drawing.Size(76, 24);
            this.txtHealth.TabIndex = 0;
            this.txtHealth.Text = "Health:";
            // 
            // healthBar
            // 
            this.healthBar.Location = new System.Drawing.Point(401, 10);
            this.healthBar.Name = "healthBar";
            this.healthBar.Size = new System.Drawing.Size(167, 31);
            this.healthBar.TabIndex = 1;
            this.healthBar.Value = 100;
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.MainTimerEvent);
            // 
            // over
            // 
            this.over.AutoSize = true;
            this.over.BackColor = System.Drawing.Color.Red;
            this.over.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.over.Location = new System.Drawing.Point(297, 202);
            this.over.Name = "over";
            this.over.Size = new System.Drawing.Size(325, 63);
            this.over.TabIndex = 3;
            this.over.Text = "GAME OVER";
            // 
            // restart
            // 
            this.restart.BackColor = System.Drawing.Color.Gray;
            this.restart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restart.Location = new System.Drawing.Point(386, 268);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(142, 44);
            this.restart.TabIndex = 4;
            this.restart.Text = "RESTART";
            this.restart.UseVisualStyleBackColor = false;
            this.restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // Congrats
            // 
            this.Congrats.AutoSize = true;
            this.Congrats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Congrats.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Congrats.Location = new System.Drawing.Point(128, 281);
            this.Congrats.Name = "Congrats";
            this.Congrats.Size = new System.Drawing.Size(663, 31);
            this.Congrats.TabIndex = 7;
            this.Congrats.Text = "YOU GOT THE RETRIBUTION YOU DESERVED!\r\n";
            // 
            // Wave
            // 
            this.Wave.AutoSize = true;
            this.Wave.BackColor = System.Drawing.Color.White;
            this.Wave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Wave.Location = new System.Drawing.Point(646, 12);
            this.Wave.Name = "Wave";
            this.Wave.Size = new System.Drawing.Size(98, 25);
            this.Wave.TabIndex = 9;
            this.Wave.Text = "Wave: 1";
            // 
            // Wave2
            // 
            this.Wave2.AutoSize = true;
            this.Wave2.BackColor = System.Drawing.Color.White;
            this.Wave2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wave2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Wave2.Location = new System.Drawing.Point(646, 12);
            this.Wave2.Name = "Wave2";
            this.Wave2.Size = new System.Drawing.Size(98, 25);
            this.Wave2.TabIndex = 10;
            this.Wave2.Text = "Wave: 2";
            // 
            // Wave3
            // 
            this.Wave3.AutoSize = true;
            this.Wave3.BackColor = System.Drawing.Color.White;
            this.Wave3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wave3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Wave3.Location = new System.Drawing.Point(646, 12);
            this.Wave3.Name = "Wave3";
            this.Wave3.Size = new System.Drawing.Size(98, 25);
            this.Wave3.TabIndex = 11;
            this.Wave3.Text = "Wave: 3";
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::FOTIS1B_Bernardo_Kutsukawa_FMP.Properties.Resources.turtup;
            this.player.Location = new System.Drawing.Point(401, 471);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(100, 100);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 2;
            this.player.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::FOTIS1B_Bernardo_Kutsukawa_FMP.Properties.Resources.Blue_ocean;
            this.ClientSize = new System.Drawing.Size(924, 661);
            this.Controls.Add(this.Wave3);
            this.Controls.Add(this.Wave2);
            this.Controls.Add(this.Wave);
            this.Controls.Add(this.Congrats);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.over);
            this.Controls.Add(this.player);
            this.Controls.Add(this.healthBar);
            this.Controls.Add(this.txtHealth);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.txtAmmo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Turtle Revenger";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtAmmo;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label txtHealth;
        private System.Windows.Forms.ProgressBar healthBar;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label over;
        private System.Windows.Forms.Button restart;
        private System.Windows.Forms.Label Congrats;
        private System.Windows.Forms.Label Wave;
        private System.Windows.Forms.Label Wave2;
        private System.Windows.Forms.Label Wave3;
        private System.Windows.Forms.PictureBox player;
    }
}

