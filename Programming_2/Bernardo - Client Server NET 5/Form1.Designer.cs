
namespace Bernardo___Client_Server_NET_5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtAID = new System.Windows.Forms.TextBox();
            this.lblAID = new System.Windows.Forms.Label();
            this.dgvAvatars = new System.Windows.Forms.DataGridView();
            this.lblAL = new System.Windows.Forms.Label();
            this.lblN = new System.Windows.Forms.Label();
            this.lblBP = new System.Windows.Forms.Label();
            this.txtAL = new System.Windows.Forms.TextBox();
            this.txtN = new System.Windows.Forms.TextBox();
            this.txtBP = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnVA = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvatars)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAID
            // 
            this.txtAID.Location = new System.Drawing.Point(36, 110);
            this.txtAID.Name = "txtAID";
            this.txtAID.Size = new System.Drawing.Size(159, 31);
            this.txtAID.TabIndex = 0;
            // 
            // lblAID
            // 
            this.lblAID.AutoSize = true;
            this.lblAID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAID.Location = new System.Drawing.Point(36, 79);
            this.lblAID.Name = "lblAID";
            this.lblAID.Size = new System.Drawing.Size(101, 28);
            this.lblAID.TabIndex = 1;
            this.lblAID.Text = "Avatar I.D.";
            // 
            // dgvAvatars
            // 
            this.dgvAvatars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvatars.Location = new System.Drawing.Point(219, 46);
            this.dgvAvatars.Name = "dgvAvatars";
            this.dgvAvatars.RowHeadersWidth = 62;
            this.dgvAvatars.RowTemplate.Height = 33;
            this.dgvAvatars.Size = new System.Drawing.Size(618, 474);
            this.dgvAvatars.TabIndex = 2;
            this.dgvAvatars.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAvatars_CellClick);
            // 
            // lblAL
            // 
            this.lblAL.AutoSize = true;
            this.lblAL.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAL.Location = new System.Drawing.Point(36, 144);
            this.lblAL.Name = "lblAL";
            this.lblAL.Size = new System.Drawing.Size(118, 28);
            this.lblAL.TabIndex = 1;
            this.lblAL.Text = "Avatar Level";
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblN.Location = new System.Drawing.Point(36, 209);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(64, 28);
            this.lblN.TabIndex = 1;
            this.lblN.Text = "Name";
            // 
            // lblBP
            // 
            this.lblBP.AutoSize = true;
            this.lblBP.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBP.Location = new System.Drawing.Point(36, 274);
            this.lblBP.Name = "lblBP";
            this.lblBP.Size = new System.Drawing.Size(120, 28);
            this.lblBP.TabIndex = 1;
            this.lblBP.Text = "Battle Power";
            // 
            // txtAL
            // 
            this.txtAL.Location = new System.Drawing.Point(36, 175);
            this.txtAL.Name = "txtAL";
            this.txtAL.Size = new System.Drawing.Size(161, 31);
            this.txtAL.TabIndex = 0;
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(36, 240);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(161, 31);
            this.txtN.TabIndex = 0;
            // 
            // txtBP
            // 
            this.txtBP.Location = new System.Drawing.Point(38, 305);
            this.txtBP.Name = "txtBP";
            this.txtBP.Size = new System.Drawing.Size(161, 31);
            this.txtBP.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(36, 366);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(161, 34);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnVA
            // 
            this.btnVA.Location = new System.Drawing.Point(36, 406);
            this.btnVA.Name = "btnVA";
            this.btnVA.Size = new System.Drawing.Size(161, 34);
            this.btnVA.TabIndex = 3;
            this.btnVA.Text = "View All";
            this.btnVA.UseVisualStyleBackColor = true;
            this.btnVA.Click += new System.EventHandler(this.btnVA_Click);
            // 
            // btnE
            // 
            this.btnE.Location = new System.Drawing.Point(38, 446);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(161, 34);
            this.btnE.TabIndex = 3;
            this.btnE.Text = "Edit";
            this.btnE.UseVisualStyleBackColor = true;
            this.btnE.Click += new System.EventHandler(this.btnE_Click);
            // 
            // btnD
            // 
            this.btnD.Location = new System.Drawing.Point(38, 486);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(161, 34);
            this.btnD.TabIndex = 3;
            this.btnD.Text = "Delete";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Font = new System.Drawing.Font("Viner Hand ITC", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(35, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 45);
            this.label1.TabIndex = 4;
            this.label1.Text = "AVATARS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnE);
            this.Controls.Add(this.btnVA);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvAvatars);
            this.Controls.Add(this.lblBP);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.lblAL);
            this.Controls.Add(this.lblAID);
            this.Controls.Add(this.txtBP);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.txtAL);
            this.Controls.Add(this.txtAID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvatars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAID;
        private System.Windows.Forms.Label lblAID;
        private System.Windows.Forms.DataGridView dgvAvatars;
        private System.Windows.Forms.Label lblAL;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.Label lblBP;
        private System.Windows.Forms.TextBox txtAL;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.TextBox txtBP;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnVA;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Label label1;
    }
}

