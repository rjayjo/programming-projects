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
    public partial class ResetPass : Form
    {
        public ResetPass()
        {
            InitializeComponent();
        }

        private void btnResetPass_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kingr\OneDrive\Desktop\FOTIS 1\2nd Term\ISPRGG2\Bernardo_Madayag_MMP\ISPRGG2.mdf;Integrated Security = SSPI";

            cn.Open();


            SqlDataAdapter sda = new SqlDataAdapter("SELECT Password from Login Where Username ='"+ txtRUsername.Text+"'", cn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count.ToString() == "1")
            {
                if (txtNewPass1.Text == txtNewPass2.Text)
                {
                    
                    SqlCommand cmd = new SqlCommand("UPDATE Login SET Password='" + txtNewPass2.Text + "' WHERE Username= '" + txtRUsername.Text +"'", cn);
                    cmd.ExecuteNonQuery();                   
                    cn.Close();

                    MessageBox.Show("Your password is sucessfully updated!");
                    this.Hide();
                    LoginForm loginform = new LoginForm();
                    loginform.Show();

                }
                
                else
                {}

            }

            else
            {
                MessageBox.Show("Please make sure that your username exists in the database!");
                txtNewPass1.Clear();
                txtNewPass2.Clear();
                txtRUsername.Clear();
            }
            


        }
    }
}
