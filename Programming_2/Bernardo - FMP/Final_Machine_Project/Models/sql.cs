using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Students.DataAccess
{
    class sql
    {
        private const string ConnectionString =
            @"Server=LAPTOP-0FS0B40Q\SQLEXPRESS;" +
            "Database=ISPRGG2; UID = sa; PWD=123qwe; TrustServerCertificate=true";
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
        public SqlDataReader GetReader()
        {
            return cmd.ExecuteReader();
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
