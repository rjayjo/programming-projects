
namespace FOTIS1B_Bernardo_DigitReversal
{
    partial class frmDRC
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
            this.btnInitiate = new System.Windows.Forms.Button();
            this.lblOriginal = new System.Windows.Forms.Label();
            this.lblReversed = new System.Windows.Forms.Label();
            this.txtOriginal = new System.Windows.Forms.TextBox();
            this.txtReversed = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInitiate
            // 
            this.btnInitiate.Location = new System.Drawing.Point(231, 222);
            this.btnInitiate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInitiate.Name = "btnInitiate";
            this.btnInitiate.Size = new System.Drawing.Size(150, 35);
            this.btnInitiate.TabIndex = 0;
            this.btnInitiate.Text = "Initiate Reversal";
            this.btnInitiate.UseVisualStyleBackColor = true;
            this.btnInitiate.Click += new System.EventHandler(this.btnInitiate_Click);
            this.btnInitiate.MouseEnter += new System.EventHandler(this.btnInitiate_MouseEnter);
            this.btnInitiate.MouseLeave += new System.EventHandler(this.btnInitiate_MouseLeave);
            // 
            // lblOriginal
            // 
            this.lblOriginal.AutoSize = true;
            this.lblOriginal.Location = new System.Drawing.Point(99, 146);
            this.lblOriginal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOriginal.Name = "lblOriginal";
            this.lblOriginal.Size = new System.Drawing.Size(122, 20);
            this.lblOriginal.TabIndex = 1;
            this.lblOriginal.Text = "Original Number";
            // 
            // lblReversed
            // 
            this.lblReversed.AutoSize = true;
            this.lblReversed.Location = new System.Drawing.Point(82, 186);
            this.lblReversed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReversed.Name = "lblReversed";
            this.lblReversed.Size = new System.Drawing.Size(137, 20);
            this.lblReversed.TabIndex = 2;
            this.lblReversed.Text = "Reversed Number";
            // 
            // txtOriginal
            // 
            this.txtOriginal.Location = new System.Drawing.Point(231, 142);
            this.txtOriginal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOriginal.Name = "txtOriginal";
            this.txtOriginal.Size = new System.Drawing.Size(148, 26);
            this.txtOriginal.TabIndex = 3;
            this.txtOriginal.TextChanged += new System.EventHandler(this.txtOriginal_TextChanged);
            // 
            // txtReversed
            // 
            this.txtReversed.Location = new System.Drawing.Point(231, 182);
            this.txtReversed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtReversed.Name = "txtReversed";
            this.txtReversed.ReadOnly = true;
            this.txtReversed.Size = new System.Drawing.Size(148, 26);
            this.txtReversed.TabIndex = 4;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblTitle.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(102, 75);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(272, 39);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "DIGIT REVERSAL";
            // 
            // frmDRC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 478);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtReversed);
            this.Controls.Add(this.txtOriginal);
            this.Controls.Add(this.lblReversed);
            this.Controls.Add(this.lblOriginal);
            this.Controls.Add(this.btnInitiate);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDRC";
            this.Text = "Digit Reversal Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInitiate;
        private System.Windows.Forms.Label lblOriginal;
        private System.Windows.Forms.Label lblReversed;
        private System.Windows.Forms.TextBox txtOriginal;
        private System.Windows.Forms.TextBox txtReversed;
        private System.Windows.Forms.Label lblTitle;
    }
}

