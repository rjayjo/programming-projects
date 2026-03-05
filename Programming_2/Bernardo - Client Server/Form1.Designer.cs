
namespace Bernardo___Client_Server
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
            this.lblRID = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvRecipes = new System.Windows.Forms.DataGridView();
            this.btnVA = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.txtRID = new System.Windows.Forms.TextBox();
            this.txtR = new System.Windows.Forms.TextBox();
            this.txtD = new System.Windows.Forms.TextBox();
            this.txtSS = new System.Windows.Forms.TextBox();
            this.lblR = new System.Windows.Forms.Label();
            this.lblD = new System.Windows.Forms.Label();
            this.lblSS = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRID
            // 
            this.lblRID.AutoSize = true;
            this.lblRID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRID.Location = new System.Drawing.Point(26, 94);
            this.lblRID.Name = "lblRID";
            this.lblRID.Size = new System.Drawing.Size(74, 16);
            this.lblRID.TabIndex = 0;
            this.lblRID.Text = "Recipe I.D.";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(29, 275);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(127, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvRecipes
            // 
            this.dgvRecipes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecipes.Location = new System.Drawing.Point(183, 13);
            this.dgvRecipes.Name = "dgvRecipes";
            this.dgvRecipes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecipes.Size = new System.Drawing.Size(387, 373);
            this.dgvRecipes.TabIndex = 2;
            this.dgvRecipes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecipes_CellClick);
            // 
            // btnVA
            // 
            this.btnVA.Location = new System.Drawing.Point(29, 304);
            this.btnVA.Name = "btnVA";
            this.btnVA.Size = new System.Drawing.Size(127, 23);
            this.btnVA.TabIndex = 1;
            this.btnVA.Text = "View All";
            this.btnVA.UseVisualStyleBackColor = true;
            this.btnVA.Click += new System.EventHandler(this.btnVA_Click);
            // 
            // btnE
            // 
            this.btnE.Location = new System.Drawing.Point(29, 333);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(127, 23);
            this.btnE.TabIndex = 1;
            this.btnE.Text = "Edit";
            this.btnE.UseVisualStyleBackColor = true;
            this.btnE.Click += new System.EventHandler(this.btnE_Click);
            // 
            // btnD
            // 
            this.btnD.Location = new System.Drawing.Point(29, 362);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(127, 23);
            this.btnD.TabIndex = 1;
            this.btnD.Text = "Delete";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // txtRID
            // 
            this.txtRID.Location = new System.Drawing.Point(29, 113);
            this.txtRID.Name = "txtRID";
            this.txtRID.Size = new System.Drawing.Size(127, 20);
            this.txtRID.TabIndex = 3;
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(29, 155);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(127, 20);
            this.txtR.TabIndex = 3;
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(29, 197);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(127, 20);
            this.txtD.TabIndex = 3;
            // 
            // txtSS
            // 
            this.txtSS.Location = new System.Drawing.Point(29, 239);
            this.txtSS.Name = "txtSS";
            this.txtSS.Size = new System.Drawing.Size(127, 20);
            this.txtSS.TabIndex = 3;
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblR.Location = new System.Drawing.Point(26, 136);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(52, 16);
            this.lblR.TabIndex = 0;
            this.lblR.Text = "Recipe";
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblD.Location = new System.Drawing.Point(26, 178);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(76, 16);
            this.lblD.TabIndex = 0;
            this.lblD.Text = "Description";
            // 
            // lblSS
            // 
            this.lblSS.AutoSize = true;
            this.lblSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSS.Location = new System.Drawing.Point(26, 220);
            this.lblSS.Name = "lblSS";
            this.lblSS.Size = new System.Drawing.Size(83, 16);
            this.lblSS.TabIndex = 0;
            this.lblSS.Text = "Serving Size";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "RECIPES";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 409);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSS);
            this.Controls.Add(this.txtD);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.txtRID);
            this.Controls.Add(this.dgvRecipes);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnE);
            this.Controls.Add(this.btnVA);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblSS);
            this.Controls.Add(this.lblD);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.lblRID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRID;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvRecipes;
        private System.Windows.Forms.Button btnVA;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.TextBox txtRID;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.TextBox txtSS;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.Label lblSS;
        private System.Windows.Forms.Label label1;
    }
}

