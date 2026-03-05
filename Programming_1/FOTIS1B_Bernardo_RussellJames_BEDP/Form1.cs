using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOTIS1B_Bernardo_RussellJames_BEDP
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnSave_MouseEnter(object sender, EventArgs e)
        {
            btnSave.Text = "Are you sure?";
        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            btnSave.Text = "&Save Record";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Record saved succesfully!");
            txtLastName.Clear();
            txtFirstName.Clear();
            txtAddress.Clear();
            txtPassword.Clear();
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Asterisk.Play();
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Beep.Play();
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Hand.Play();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Exclamation.Play();
        }

        private void txtLastName_DoubleClick(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
        }

        private void txtFirstName_DoubleClick(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void txtAddress_DoubleClick(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
        }

        private void txtPassword_DoubleClick(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }
    }
}
