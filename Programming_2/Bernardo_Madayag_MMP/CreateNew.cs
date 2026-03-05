using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
namespace Bernardo_Madayag_MMP
{
    public partial class CreateNew : Form
    {
        public CreateNew()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new();
            cn.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kingr\OneDrive\Desktop\FOTIS 1\2nd Term\ISPRGG2\Bernardo_Madayag_MMP\ISPRGG2.mdf;Integrated Security = SSPI";

            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "INSERT INTO Login VALUES (@a, @b)";
            cmd.Parameters.AddWithValue("@a", txtNewUser.Text);
            cmd.Parameters.AddWithValue("@b", txtNewPass.Text);
            cmd.ExecuteNonQuery();

            cn.Close();
            cn.Dispose();
            MessageBox.Show("You have succesfully created a new user!");
            txtNewUser.Clear();
            txtNewPass.Clear();
            this.Hide();
            LoginForm loginform = new LoginForm();
            loginform.Show();

        }
    }
}
