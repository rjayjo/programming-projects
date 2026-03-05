using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Intepro.DataAccess
{
    public class SQLDAL
    {
        private const string ConnectionString = @"Data Source=LAPTOP-0FS0B40Q\SQLEXPRESS;Initial Catalog = ISPRGG2; User ID = teammember; Password=123qwe; TrustServerCertificate=True";

        private SqlConnection cn = new SqlConnection(ConnectionString);
        private SqlCommand cmd;

        public void Open()
        {
            if (cn.State == ConnectionState.Closed)
                cn.Open();
        }

        public void Close()
        {
            if (cn.State == ConnectionState.Open)
                cn.Close();
        }

        public void SetSql(string CommandText)
        {
            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = CommandText;
        }

        public void AddParameter(string ParamName, object ParamValue)
        {
            cmd.Parameters.AddWithValue(ParamName, ParamValue);
        }

        public void ClearParameters()
        {
            cmd.Parameters.Clear();
        }

        public void Execute()
        {
            cmd.ExecuteNonQuery();
        }

        public DataTable GetData()
        {
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }

}