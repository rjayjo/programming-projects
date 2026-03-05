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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                using (SqlConnection cn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kingr\OneDrive\Desktop\FOTIS 1\2nd Term\ISPRGG2\Bernardo_Madayag_MMP\ISPRGG2.mdf;Integrated Security = SSPI"))
                {
                    string query = "SELECT * FROM Login WHERE Username = '" + txtUsername.Text.Trim() +
                        "' AND Password = '" + txtPassword.Text.Trim() + "'";
                    SqlDataAdapter sd = new SqlDataAdapter(query, cn);
                    DataTable dt = new DataTable();
                    sd.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        Form1 form1 = new Form1();
                        this.Hide();
                        form1.Show();
                    }
                    else if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Please enter a valid username and password!");
                    }

                }
            }
        }
        
        private bool isValid()
        {
            if (txtUsername.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Please enter a valid username!");
                return false;
            }
            else if (txtPassword.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Please enter a valid password!");
                return false;
            }

            return true;
        }

        private void lblCreateNew_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateNew createnew = new CreateNew();
            createnew.Show();
        }

        private void lblResetPass_Click(object sender, EventArgs e)
        {
            this.Hide();
            ResetPass resetpass = new ResetPass();
            resetpass.Show();
        }
    }
}
