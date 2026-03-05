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

namespace Bernardo_Madayag_MMP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private BLL contacts = new BLL();

        private void Reconfig()
        {
            txtContactNo.Clear();
            txtContactID.Clear();
            txtName.Clear();
            btnViewAll_Click(new object(), new EventArgs());
        }
            
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                                
                isValid();              
                contacts.Add();
                MessageBox.Show("Successfully added a new contact!");
                Reconfig();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
            
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            dgvContacts.DataSource = contacts.GetAll();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Reconfig();
        }

        private int cID = 0;

        private void dgvContacts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtContactID.Text = dgvContacts.SelectedRows[0].Cells[0].Value.ToString();
            txtName.Text = dgvContacts.SelectedRows[0].Cells[1].Value.ToString();
            txtContactNo.Text = dgvContacts.SelectedRows[0].Cells[2].Value.ToString();
            cID = (int)dgvContacts.SelectedRows[0].Cells[0].Value;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            contacts.ContactID = cID;
            contacts.Delete();

            MessageBox.Show("Succesfully deleted a contact!");
            Reconfig();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                contacts.ContactID = int.Parse(txtContactID.Text);
                contacts.Name = txtName.Text;
                contacts.ContactNo = txtContactNo.Text;
                isValid();
                contacts.Edit(cID);

                MessageBox.Show("Succesfully edited a contact record!");
                Reconfig();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }  
        
        }

        
         
        private void isValid()
        {
            var contactIDholder = txtContactID.Text;
            long contactID;
            bool parseTrue = long.TryParse(contactIDholder, out contactID);
            if (parseTrue)
            {
                contacts.ContactID = int.Parse(contactIDholder);
            }
            else
            {
                Exception error = new Exception("ContactID must strictly be a valid integer!");
                error.Source = "Project Guidelines";
                throw error;

            }

            
            if (contactIDholder.Length != 7)
            {
                Exception error = new Exception("ContactID should be exactly 7 digits only!");
                error.Source = "Project Guidelines";
                throw error;
            }


            var nameHolder = txtName.Text;

            if (nameHolder.Length < 5 || nameHolder.Length > 100)
            {
                Exception error = new Exception("Name must range from 5 to 100 characters only!");
                error.Source = "Project Guidelines";
                throw error;
            }
            else
            {
                contacts.Name = txtName.Text;
            }
          

            var contactNoholder = txtContactNo.Text;

            long value;
            bool checkCNO = !long.TryParse(txtContactNo.Text, out value);
            if (checkCNO)
            {
                Exception error = new Exception("ContactNo should be composed of numbers only!");
                error.Source = "Project Guidelines";
                throw error;
            }


            if (contactNoholder.Length == 7 || contactNoholder.Length == 11)
            {
                contacts.ContactNo = txtContactNo.Text;

            }
            else
            {
                Exception error = new Exception("ContactNo must either be a 7 or 11 digit number!");
                error.Source = "Project Guidelines";
                throw error;
            }

            return;
           
        }






    }
}
