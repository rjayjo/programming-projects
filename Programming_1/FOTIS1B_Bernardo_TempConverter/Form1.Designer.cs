
namespace FOTIS1B_Bernardo_TempConverter
{
    partial class frmTempConverter
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
            this.btnCtoF = new System.Windows.Forms.Button();
            this.btnFtoC = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCelsiusInput = new System.Windows.Forms.TextBox();
            this.txtFahrenheitInput = new System.Windows.Forms.TextBox();
            this.txtFahrenheitResult = new System.Windows.Forms.TextBox();
            this.txtCelsiusResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCtoF
            // 
            this.btnCtoF.Location = new System.Drawing.Point(41, 160);
            this.btnCtoF.Name = "btnCtoF";
            this.btnCtoF.Size = new System.Drawing.Size(100, 23);
            this.btnCtoF.TabIndex = 0;
            this.btnCtoF.Text = "Convert";
            this.btnCtoF.UseVisualStyleBackColor = true;
            this.btnCtoF.Click += new System.EventHandler(this.btnCtoF_Click);
            // 
            // btnFtoC
            // 
            this.btnFtoC.Location = new System.Drawing.Point(194, 160);
            this.btnFtoC.Name = "btnFtoC";
            this.btnFtoC.Size = new System.Drawing.Size(100, 23);
            this.btnFtoC.TabIndex = 1;
            this.btnFtoC.Text = "Convert";
            this.btnFtoC.UseVisualStyleBackColor = true;
            this.btnFtoC.Click += new System.EventHandler(this.btnFtoC_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Celcius to Fahrenheit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fahrenheit to Celcius";
            // 
            // txtCelsiusInput
            // 
            this.txtCelsiusInput.Location = new System.Drawing.Point(41, 108);
            this.txtCelsiusInput.Name = "txtCelsiusInput";
            this.txtCelsiusInput.Size = new System.Drawing.Size(100, 20);
            this.txtCelsiusInput.TabIndex = 4;
            // 
            // txtFahrenheitInput
            // 
            this.txtFahrenheitInput.Location = new System.Drawing.Point(194, 108);
            this.txtFahrenheitInput.Name = "txtFahrenheitInput";
            this.txtFahrenheitInput.Size = new System.Drawing.Size(100, 20);
            this.txtFahrenheitInput.TabIndex = 5;
            // 
            // txtFahrenheitResult
            // 
            this.txtFahrenheitResult.Location = new System.Drawing.Point(41, 134);
            this.txtFahrenheitResult.Name = "txtFahrenheitResult";
            this.txtFahrenheitResult.ReadOnly = true;
            this.txtFahrenheitResult.Size = new System.Drawing.Size(100, 20);
            this.txtFahrenheitResult.TabIndex = 6;
            // 
            // txtCelsiusResult
            // 
            this.txtCelsiusResult.Location = new System.Drawing.Point(194, 134);
            this.txtCelsiusResult.Name = "txtCelsiusResult";
            this.txtCelsiusResult.ReadOnly = true;
            this.txtCelsiusResult.Size = new System.Drawing.Size(100, 20);
            this.txtCelsiusResult.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 34);
            this.label3.TabIndex = 8;
            this.label3.Text = "           Temperature Converter\r\n Celsius to Fahrenheit and Vice Versa\r\n";
            // 
            // frmTempConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCelsiusResult);
            this.Controls.Add(this.txtFahrenheitResult);
            this.Controls.Add(this.txtFahrenheitInput);
            this.Controls.Add(this.txtCelsiusInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFtoC);
            this.Controls.Add(this.btnCtoF);
            this.Name = "frmTempConverter";
            this.Text = "Temperature Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCtoF;
        private System.Windows.Forms.Button btnFtoC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCelsiusInput;
        private System.Windows.Forms.TextBox txtFahrenheitInput;
        private System.Windows.Forms.TextBox txtFahrenheitResult;
        private System.Windows.Forms.TextBox txtCelsiusResult;
        private System.Windows.Forms.Label label3;
    }
}

