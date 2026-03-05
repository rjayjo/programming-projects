
namespace FOTIS1B_Bernardo_DivRemLoop
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
            this.txtDividend = new System.Windows.Forms.TextBox();
            this.txtDivisor = new System.Windows.Forms.TextBox();
            this.txtQuotient = new System.Windows.Forms.TextBox();
            this.txtRemainder = new System.Windows.Forms.TextBox();
            this.lblDividend = new System.Windows.Forms.Label();
            this.lblDivisor = new System.Windows.Forms.Label();
            this.lblQuotient = new System.Windows.Forms.Label();
            this.lblRemainder = new System.Windows.Forms.Label();
            this.btnDivide = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDividend
            // 
            this.txtDividend.Location = new System.Drawing.Point(148, 60);
            this.txtDividend.Name = "txtDividend";
            this.txtDividend.Size = new System.Drawing.Size(100, 20);
            this.txtDividend.TabIndex = 0;
            // 
            // txtDivisor
            // 
            this.txtDivisor.Location = new System.Drawing.Point(148, 90);
            this.txtDivisor.Name = "txtDivisor";
            this.txtDivisor.Size = new System.Drawing.Size(100, 20);
            this.txtDivisor.TabIndex = 1;
            // 
            // txtQuotient
            // 
            this.txtQuotient.Location = new System.Drawing.Point(148, 120);
            this.txtQuotient.Name = "txtQuotient";
            this.txtQuotient.ReadOnly = true;
            this.txtQuotient.Size = new System.Drawing.Size(100, 20);
            this.txtQuotient.TabIndex = 2;
            // 
            // txtRemainder
            // 
            this.txtRemainder.Location = new System.Drawing.Point(148, 150);
            this.txtRemainder.Name = "txtRemainder";
            this.txtRemainder.ReadOnly = true;
            this.txtRemainder.Size = new System.Drawing.Size(100, 20);
            this.txtRemainder.TabIndex = 3;
            // 
            // lblDividend
            // 
            this.lblDividend.AutoSize = true;
            this.lblDividend.Location = new System.Drawing.Point(84, 63);
            this.lblDividend.Name = "lblDividend";
            this.lblDividend.Size = new System.Drawing.Size(49, 13);
            this.lblDividend.TabIndex = 4;
            this.lblDividend.Text = "Dividend";
            this.lblDividend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDivisor
            // 
            this.lblDivisor.AutoSize = true;
            this.lblDivisor.Location = new System.Drawing.Point(84, 93);
            this.lblDivisor.Name = "lblDivisor";
            this.lblDivisor.Size = new System.Drawing.Size(39, 13);
            this.lblDivisor.TabIndex = 5;
            this.lblDivisor.Text = "Divisor";
            // 
            // lblQuotient
            // 
            this.lblQuotient.AutoSize = true;
            this.lblQuotient.Location = new System.Drawing.Point(84, 123);
            this.lblQuotient.Name = "lblQuotient";
            this.lblQuotient.Size = new System.Drawing.Size(47, 13);
            this.lblQuotient.TabIndex = 6;
            this.lblQuotient.Text = "Quotient";
            // 
            // lblRemainder
            // 
            this.lblRemainder.AutoSize = true;
            this.lblRemainder.Location = new System.Drawing.Point(84, 153);
            this.lblRemainder.Name = "lblRemainder";
            this.lblRemainder.Size = new System.Drawing.Size(58, 13);
            this.lblRemainder.TabIndex = 7;
            this.lblRemainder.Text = "Remainder";
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(148, 180);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(100, 24);
            this.btnDivide.TabIndex = 8;
            this.btnDivide.Text = "Divide";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Divison-Remainder Loop";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 290);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.lblRemainder);
            this.Controls.Add(this.lblQuotient);
            this.Controls.Add(this.lblDivisor);
            this.Controls.Add(this.lblDividend);
            this.Controls.Add(this.txtRemainder);
            this.Controls.Add(this.txtQuotient);
            this.Controls.Add(this.txtDivisor);
            this.Controls.Add(this.txtDividend);
            this.Name = "Form1";
            this.Text = "Division Remainder Loop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDividend;
        private System.Windows.Forms.TextBox txtDivisor;
        private System.Windows.Forms.TextBox txtQuotient;
        private System.Windows.Forms.TextBox txtRemainder;
        private System.Windows.Forms.Label lblDividend;
        private System.Windows.Forms.Label lblDivisor;
        private System.Windows.Forms.Label lblQuotient;
        private System.Windows.Forms.Label lblRemainder;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Label label1;
    }
}

