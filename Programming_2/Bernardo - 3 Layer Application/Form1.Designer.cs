
namespace Bernardo___3_Layer_Application
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSID = new System.Windows.Forms.TextBox();
            this.dgvS = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCNO = new System.Windows.Forms.TextBox();
            this.btnVA = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvS)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Supplier ID";
            // 
            // txtSID
            // 
            this.txtSID.Location = new System.Drawing.Point(25, 83);
            this.txtSID.Name = "txtSID";
            this.txtSID.Size = new System.Drawing.Size(189, 31);
            this.txtSID.TabIndex = 1;
            // 
            // dgvS
            // 
            this.dgvS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvS.Location = new System.Drawing.Point(246, 71);
            this.dgvS.Name = "dgvS";
            this.dgvS.RowHeadersWidth = 62;
            this.dgvS.RowTemplate.Height = 33;
            this.dgvS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvS.Size = new System.Drawing.Size(625, 502);
            this.dgvS.TabIndex = 2;
            this.dgvS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvS_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Company Name";
            // 
            // txtCN
            // 
            this.txtCN.Location = new System.Drawing.Point(25, 145);
            this.txtCN.Name = "txtCN";
            this.txtCN.Size = new System.Drawing.Size(189, 31);
            this.txtCN.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(25, 207);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(189, 31);
            this.txtAddress.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Contact Person";
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(25, 269);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(189, 31);
            this.txtCP.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Contact No";
            // 
            // txtCNO
            // 
            this.txtCNO.Location = new System.Drawing.Point(25, 331);
            this.txtCNO.Name = "txtCNO";
            this.txtCNO.Size = new System.Drawing.Size(189, 31);
            this.txtCNO.TabIndex = 1;
            // 
            // btnVA
            // 
            this.btnVA.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVA.Location = new System.Drawing.Point(25, 400);
            this.btnVA.Name = "btnVA";
            this.btnVA.Size = new System.Drawing.Size(189, 34);
            this.btnVA.TabIndex = 3;
            this.btnVA.Text = "VIEW ALL";
            this.btnVA.UseVisualStyleBackColor = true;
            this.btnVA.Click += new System.EventHandler(this.btnVA_Click);
            // 
            // btnA
            // 
            this.btnA.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnA.Location = new System.Drawing.Point(25, 440);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(189, 34);
            this.btnA.TabIndex = 3;
            this.btnA.Text = "ADD";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnE
            // 
            this.btnE.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnE.Location = new System.Drawing.Point(25, 480);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(189, 34);
            this.btnE.TabIndex = 3;
            this.btnE.Text = "EDIT";
            this.btnE.UseVisualStyleBackColor = true;
            this.btnE.Click += new System.EventHandler(this.btnE_Click);
            // 
            // btnD
            // 
            this.btnD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnD.Location = new System.Drawing.Point(25, 520);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(189, 34);
            this.btnD.TabIndex = 3;
            this.btnD.Text = "DELETE";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label6.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(448, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(261, 31);
            this.label6.TabIndex = 0;
            this.label6.Text = "S U P P L I E R S";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 616);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnE);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.btnVA);
            this.Controls.Add(this.dgvS);
            this.Controls.Add(this.txtCNO);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSID;
        private System.Windows.Forms.DataGridView dgvS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCNO;
        private System.Windows.Forms.Button btnVA;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Label label6;
    }
}

