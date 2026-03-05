using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Intepro.DataAccess;

namespace Bernardo___2_Layer_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SQLDAL dal = new SQLDAL();
        
        private void btnA_Click(object sender, EventArgs e)
        {
            dal.Open();

            dal.SetSql("INSERT INTO Customers VALUES " +
                "(@a, @b, @c)");
            dal.AddParameter("@a", txtCID.Text);
            dal.AddParameter("@b", txtCN.Text);
            dal.AddParameter("@c", txtCNO.Text);
            dal.Execute();
            
            dal.Close();

            MessageBox.Show("Succesfully added a new record!");
            Reconfig();
        }

        private void Reconfig()
        {
            txtCID.Clear();
            txtCN.Clear();
            txtCNO.Clear();
            btnVA_Click(new object(), new EventArgs());
        }

        private void btnVA_Click(object sender, EventArgs e)
        {
            dal.Open();

            dal.SetSql("SELECT * FROM Customers");
            dgvC.DataSource = dal.GetData();

            dal.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Reconfig();
        }

        private int cID = 0;

        private void dgvC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCID.Text = dgvC.SelectedRows[0].Cells[0].Value.ToString();
            txtCN.Text = dgvC.SelectedRows[0].Cells[1].Value.ToString();
            txtCNO.Text = dgvC.SelectedRows[0].Cells[2].Value.ToString();
            cID = (int)dgvC.SelectedRows[0].Cells[0].Value;
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            dal.Open();

            dal.SetSql("DELETE Customers WHERE CustomerID = @id");
            dal.AddParameter("@id", cID);
            dal.Execute();

            dal.Close();

            MessageBox.Show("Succesfully deleted a record!");
            Reconfig();
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            dal.Open();

            dal.SetSql("UPDATE Customers " +
                "SET CustomerID = @id, " +
                "   CompanyName = @cn, " +
                "   ContactNo = @cno " +
                "WHERE CustomerID = @oid");
            dal.AddParameter("@id", txtCID.Text);
            dal.AddParameter("@cn", txtCN.Text);
            dal.AddParameter("@cno", txtCNO.Text);
            dal.AddParameter("@oid", cID);
            dal.Execute();

            dal.Close();

            MessageBox.Show("Succesfully edited a record!");
            Reconfig();
        }
    }
}
