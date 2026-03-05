
namespace Bernardo___2_Layer_Application
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
            this.lblCID = new System.Windows.Forms.Label();
            this.txtCID = new System.Windows.Forms.TextBox();
            this.dgvC = new System.Windows.Forms.DataGridView();
            this.lblCN = new System.Windows.Forms.Label();
            this.txtCN = new System.Windows.Forms.TextBox();
            this.lblCNO = new System.Windows.Forms.Label();
            this.txtCNO = new System.Windows.Forms.TextBox();
            this.btnVA = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvC)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCID
            // 
            this.lblCID.AutoSize = true;
            this.lblCID.Location = new System.Drawing.Point(39, 106);
            this.lblCID.Name = "lblCID";
            this.lblCID.Size = new System.Drawing.Size(120, 25);
            this.lblCID.TabIndex = 0;
            this.lblCID.Text = "Customer I.D.";
            // 
            // txtCID
            // 
            this.txtCID.Location = new System.Drawing.Point(39, 134);
            this.txtCID.Name = "txtCID";
            this.txtCID.Size = new System.Drawing.Size(187, 31);
            this.txtCID.TabIndex = 1;
            // 
            // dgvC
            // 
            this.dgvC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvC.Location = new System.Drawing.Point(263, 33);
            this.dgvC.Name = "dgvC";
            this.dgvC.RowHeadersWidth = 62;
            this.dgvC.RowTemplate.Height = 33;
            this.dgvC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvC.Size = new System.Drawing.Size(484, 455);
            this.dgvC.TabIndex = 2;
            this.dgvC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvC_CellClick);
            // 
            // lblCN
            // 
            this.lblCN.AutoSize = true;
            this.lblCN.Location = new System.Drawing.Point(39, 168);
            this.lblCN.Name = "lblCN";
            this.lblCN.Size = new System.Drawing.Size(141, 25);
            this.lblCN.TabIndex = 0;
            this.lblCN.Text = "Company Name";
            // 
            // txtCN
            // 
            this.txtCN.Location = new System.Drawing.Point(39, 196);
            this.txtCN.Name = "txtCN";
            this.txtCN.Size = new System.Drawing.Size(187, 31);
            this.txtCN.TabIndex = 1;
            // 
            // lblCNO
            // 
            this.lblCNO.AutoSize = true;
            this.lblCNO.Location = new System.Drawing.Point(39, 230);
            this.lblCNO.Name = "lblCNO";
            this.lblCNO.Size = new System.Drawing.Size(106, 25);
            this.lblCNO.TabIndex = 0;
            this.lblCNO.Text = "Contact No.";
            // 
            // txtCNO
            // 
            this.txtCNO.Location = new System.Drawing.Point(39, 258);
            this.txtCNO.Name = "txtCNO";
            this.txtCNO.Size = new System.Drawing.Size(187, 31);
            this.txtCNO.TabIndex = 1;
            // 
            // btnVA
            // 
            this.btnVA.Location = new System.Drawing.Point(39, 325);
            this.btnVA.Name = "btnVA";
            this.btnVA.Size = new System.Drawing.Size(187, 34);
            this.btnVA.TabIndex = 3;
            this.btnVA.Text = "View All";
            this.btnVA.UseVisualStyleBackColor = true;
            this.btnVA.Click += new System.EventHandler(this.btnVA_Click);
            // 
            // btnA
            // 
            this.btnA.Location = new System.Drawing.Point(39, 365);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(187, 34);
            this.btnA.TabIndex = 3;
            this.btnA.Text = "Add";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnE
            // 
            this.btnE.Location = new System.Drawing.Point(39, 405);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(187, 34);
            this.btnE.TabIndex = 3;
            this.btnE.Text = "Edit";
            this.btnE.UseVisualStyleBackColor = true;
            this.btnE.Click += new System.EventHandler(this.btnE_Click);
            // 
            // btnD
            // 
            this.btnD.Location = new System.Drawing.Point(39, 445);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(187, 34);
            this.btnD.TabIndex = 3;
            this.btnD.Text = "Delete";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(28, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 45);
            this.label1.TabIndex = 4;
            this.label1.Text = "CUSTOMERS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 534);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnE);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.btnVA);
            this.Controls.Add(this.dgvC);
            this.Controls.Add(this.txtCNO);
            this.Controls.Add(this.lblCNO);
            this.Controls.Add(this.txtCN);
            this.Controls.Add(this.lblCN);
            this.Controls.Add(this.txtCID);
            this.Controls.Add(this.lblCID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCID;
        private System.Windows.Forms.TextBox txtCID;
        private System.Windows.Forms.DataGridView dgvC;
        private System.Windows.Forms.Label lblCN;
        private System.Windows.Forms.TextBox txtCN;
        private System.Windows.Forms.Label lblCNO;
        private System.Windows.Forms.TextBox txtCNO;
        private System.Windows.Forms.Button btnVA;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Label label1;
    }
}

