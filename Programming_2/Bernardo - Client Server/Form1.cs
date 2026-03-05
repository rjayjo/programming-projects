using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bernardo___Client_Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Server=198.38.83.33; Database=eisensy_csbintepro;" +
            "UID=eisensy_student; PWD= Benilde@2020;";

            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "INSERT INTO Recipes VALUES (@a, @b, @c, @d)";
            cmd.Parameters.AddWithValue("@a", txtRID.Text);
            cmd.Parameters.AddWithValue("@b", txtR.Text);
            cmd.Parameters.AddWithValue("@c", txtD.Text);
            cmd.Parameters.AddWithValue("@d", txtSS.Text);
            cmd.ExecuteNonQuery();

            cn.Close();
            cn.Dispose();
            MessageBox.Show("Succesfully created a new recipe!");
            txtRID.Clear();
            txtR.Clear();
            txtD.Clear();
            txtSS.Clear();
            
            btnVA_Click(sender, e);

        }

        private void btnVA_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Server=198.38.83.33; Database=eisensy_csbintepro;"+ 
            "UID=eisensy_student; PWD= Benilde@2020;";


            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "SELECT * FROM Recipes";

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvRecipes.DataSource = dt;

            cmd.Dispose();
            da.Dispose();
            cn.Close();
            cn.Dispose();

            
        }
        
        int rID = 0;
        int sS = 0;


        private void dgvRecipes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtRID.Text = dgvRecipes.SelectedRows[0].Cells[0].Value.ToString();
            txtR.Text = dgvRecipes.SelectedRows[0].Cells[1].Value.ToString();
            txtD.Text = dgvRecipes.SelectedRows[0].Cells[2].Value.ToString();
            txtSS.Text = dgvRecipes.SelectedRows[0].Cells[3].Value.ToString();
            rID = (int)dgvRecipes.SelectedRows[0].Cells[0].Value;
            sS = (int)dgvRecipes.SelectedRows[0].Cells[3].Value;

        }

        private void btnD_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Server=198.38.83.33; Database=eisensy_csbintepro;" +
            "UID=eisensy_student; PWD= Benilde@2020;";

            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "DELETE Recipes WHERE RecipeID = @eid";
            cmd.Parameters.AddWithValue("@eid", rID);
            cmd.ExecuteNonQuery();

            cn.Close();
            cn.Dispose();
            MessageBox.Show("You have deleted a recipe.");
            txtRID.Clear();
            txtR.Clear();
            txtD.Clear();
            txtSS.Clear();

            btnVA_Click(sender, e);




        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnVA_Click(sender, e);
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Server=198.38.83.33; Database=eisensy_csbintepro;" +
            "UID=eisensy_student; PWD= Benilde@2020;";

            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "UPDATE Recipes " +
                "SET RecipeID = @newid," +
                "   RecipeName = @r," +
                "   Description = @d," +
                "   ServingSize = @ss" +
                "   WHERE RecipeID = @eid";

            cmd.Parameters.AddWithValue("@newid", txtRID.Text);
            cmd.Parameters.AddWithValue("@r", txtR.Text);
            cmd.Parameters.AddWithValue("@d", txtD.Text);
            cmd.Parameters.AddWithValue("@ss", txtSS.Text);
            cmd.Parameters.AddWithValue("@eid", rID);
            cmd.ExecuteNonQuery();


            cn.Dispose();
            cn.Close();
            cn.Dispose();
            MessageBox.Show("Recipe updated succesfully!");
            txtRID.Clear();
            txtR.Clear();
            txtD.Clear();
            txtSS.Clear();

            btnVA_Click(sender, e);
        }
    }
}
