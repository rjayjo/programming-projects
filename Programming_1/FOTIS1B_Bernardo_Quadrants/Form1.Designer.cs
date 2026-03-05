
namespace FOTIS1B_Bernardo_Quadrants
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
            this.lblInput = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblQ = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.txtQ = new System.Windows.Forms.TextBox();
            this.btnInitiate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(138, 53);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(69, 14);
            this.lblInput.TabIndex = 0;
            this.lblInput.Text = "Input Point";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(40, 73);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(77, 14);
            this.lblX.TabIndex = 1;
            this.lblX.Text = "X-Coordinate";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(39, 102);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(78, 14);
            this.lblY.TabIndex = 2;
            this.lblY.Text = "Y-Coordinate";
            // 
            // lblQ
            // 
            this.lblQ.AutoSize = true;
            this.lblQ.Location = new System.Drawing.Point(59, 145);
            this.lblQ.Name = "lblQ";
            this.lblQ.Size = new System.Drawing.Size(58, 14);
            this.lblQ.TabIndex = 3;
            this.lblQ.Text = "Quadrant";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(123, 70);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 22);
            this.txtX.TabIndex = 4;
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(123, 99);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(100, 22);
            this.txtY.TabIndex = 5;
            // 
            // txtQ
            // 
            this.txtQ.Location = new System.Drawing.Point(123, 142);
            this.txtQ.Name = "txtQ";
            this.txtQ.ReadOnly = true;
            this.txtQ.Size = new System.Drawing.Size(100, 22);
            this.txtQ.TabIndex = 6;
            // 
            // btnInitiate
            // 
            this.btnInitiate.Location = new System.Drawing.Point(122, 170);
            this.btnInitiate.Name = "btnInitiate";
            this.btnInitiate.Size = new System.Drawing.Size(101, 23);
            this.btnInitiate.TabIndex = 7;
            this.btnInitiate.Text = "Process Point";
            this.btnInitiate.UseVisualStyleBackColor = true;
            this.btnInitiate.Click += new System.EventHandler(this.btnInitiate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Quadrant Determiner";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 227);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInitiate);
            this.Controls.Add(this.txtQ);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.lblQ);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.lblInput);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Quadrants";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblQ;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox txtQ;
        private System.Windows.Forms.Button btnInitiate;
        private System.Windows.Forms.Label label1;
    }
}

