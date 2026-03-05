using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Suppliers.BussinessLogic;


namespace Bernardo___3_Layer_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private BLL supplier = new BLL();

        private void btnVA_Click(object sender, EventArgs e)
        {
            dgvS.DataSource = supplier.GetAll();
        }

        private void Reconfig()
        {
            txtAddress.Clear();
            txtCN.Clear();
            txtCNO.Clear();
            txtCP.Clear();
            txtSID.Clear();
            btnVA_Click(new object(), new EventArgs());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Reconfig();
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            try
            {
                supplier.SupplierID = int.Parse(txtSID.Text);
                supplier.CompanyName = txtCN.Text;
                supplier.Address = txtAddress.Text;
                supplier.ContactPerson = txtCP.Text;
                supplier.ContactNo = txtCNO.Text;
                supplier.Validate();
                supplier.Add();
                

                MessageBox.Show("Record Added Succesfully!");
                Reconfig();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private int sID = 0;
        private void dgvS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSID.Text = dgvS.SelectedRows[0].Cells[0].Value.ToString();
            txtCN.Text = dgvS.SelectedRows[0].Cells[1].Value.ToString();
            txtAddress.Text = dgvS.SelectedRows[0].Cells[2].Value.ToString();
            txtCP.Text = dgvS.SelectedRows[0].Cells[3].Value.ToString();
            txtCNO.Text = dgvS.SelectedRows[0].Cells[4].Value.ToString();
            sID = (int)dgvS.SelectedRows[0].Cells[0].Value;
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            supplier.SupplierID = sID;
            supplier.Delete();

            MessageBox.Show("Record Deleted Succesfully!");
            Reconfig();
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            try
            {
                supplier.SupplierID = int.Parse(txtSID.Text);
                supplier.CompanyName = txtCN.Text;
                supplier.Address = txtAddress.Text;
                supplier.ContactPerson = txtCP.Text;
                supplier.ContactNo = txtCNO.Text;
                supplier.Validate();
                supplier.Edit(sID);

                MessageBox.Show("Record Edited Succesfully!");
                Reconfig();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }

        }
    }
}
