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

namespace Bernardo___Client_Server_NET_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new();
            cn.ConnectionString = @"Server=198.38.83.33; Database=eisensy_csbintepro;" +
            "UID=eisensy_student; PWD= Benilde@2020; TrustServerCertificate = true;";

            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "INSERT INTO Avatars VALUES (@a, @b, @c, @d)";
            cmd.Parameters.AddWithValue("@a", txtAID.Text);
            cmd.Parameters.AddWithValue("@b", txtAL.Text);
            cmd.Parameters.AddWithValue("@c", txtN.Text);
            cmd.Parameters.AddWithValue("@d", txtBP.Text);
            cmd.ExecuteNonQuery();

            cn.Close();
            cn.Dispose();
            MessageBox.Show("You have succesfully created an avatar!");
            txtAID.Clear();
            txtAL.Clear();
            txtN.Clear();
            txtBP.Clear();

            btnVA_Click(sender, e);

        }

        private void btnVA_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Server=198.38.83.33; Database=eisensy_csbintepro;" +
            "UID=eisensy_student; PWD= Benilde@2020; TrustServerCertificate = true;";


            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "SELECT * FROM Avatars";

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvAvatars.DataSource = dt;

            cmd.Dispose();
            da.Dispose();
            cn.Close();
            cn.Dispose();
        }

        int aID = 0;

        private void dgvAvatars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAID.Text = dgvAvatars.SelectedRows[0].Cells[0].Value.ToString();
            txtAL.Text = dgvAvatars.SelectedRows[0].Cells[1].Value.ToString();
            txtN.Text = dgvAvatars.SelectedRows[0].Cells[2].Value.ToString();
            txtBP.Text = dgvAvatars.SelectedRows[0].Cells[3].Value.ToString();
            aID = (int)dgvAvatars.SelectedRows[0].Cells[0].Value;
           
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Server=198.38.83.33; Database=eisensy_csbintepro;" +
            "UID=eisensy_student; PWD= Benilde@2020; TrustServerCertificate = true;";

            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "DELETE Avatars WHERE AvatarID = @eid";
            cmd.Parameters.AddWithValue("@eid", aID);
            cmd.ExecuteNonQuery();

            cn.Close();
            cn.Dispose();
            MessageBox.Show("You have deleted an avatar.");
            txtAID.Clear();
            txtAL.Clear();
            txtN.Clear();
            txtBP.Clear();

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
            "UID=eisensy_student; PWD= Benilde@2020; TrustServerCertificate = true;";

            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "UPDATE Avatars " +
                "SET AvatarID = @newid," +
                "   AvatarLevel = @al," +
                "   Name = @n," +
                "   BattlePower = @bp" +
                "   WHERE AvatarID = @eid";

            cmd.Parameters.AddWithValue("@newid", txtAID.Text);
            cmd.Parameters.AddWithValue("@al", txtAL.Text);
            cmd.Parameters.AddWithValue("@n", txtN.Text);
            cmd.Parameters.AddWithValue("@bp", txtBP.Text);
            cmd.Parameters.AddWithValue("@eid", aID);
            cmd.ExecuteNonQuery();


            cn.Dispose();
            cn.Close();
            cn.Dispose();
            MessageBox.Show("Avatar updated succesfully!");
            txtAID.Clear();
            txtAL.Clear();
            txtN.Clear();
            txtBP.Clear();

            btnVA_Click(sender, e);
        }
    }
}
