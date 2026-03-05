using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Intepro.DataAccess;
using System.Data;
using Microsoft.Data.SqlClient;
using Bernardo_Madayag_MMP;

namespace Bernardo_Madayag_MMP
{
    class BLL
    {
        public int ContactID { get; set; }
        public string Name { get; set; }
        public string ContactNo { get; set; }

        public SQLDAL dal = new SQLDAL();


        public void Add()
        {
            dal.Open();
            dal.SetSql("INSERT INTO Contacts VALUES (@a, @b, @c)");
            dal.AddParameter("@a", ContactID);
            dal.AddParameter("@b", Name);
            dal.AddParameter("@c", ContactNo);
            dal.Execute();
            dal.Close();
        }

        public DataTable GetAll()
        {
            dal.Open();
            dal.SetSql("SELECT * FROM Contacts");
            DataTable dt = dal.GetData();
            dal.Close();

            return dt;
        }

        public void Delete()
        {
            dal.Open();
            dal.SetSql("DELETE Contacts WHERE ContactID = @id");
            dal.AddParameter("@id", ContactID);
            dal.Execute();
            dal.Close();

        }

        public void Edit(int oldID)
        {
            dal.Open();

            dal.SetSql("UPDATE Contacts " +
                "SET Name = @n, " +
                "   ContactNo = @cno " +
                "WHERE ContactID = @oid");
            dal.AddParameter("@id", ContactID);
            dal.AddParameter("@n", Name);
            dal.AddParameter("@cno", ContactNo);
            dal.AddParameter("@oid", oldID);
            dal.Execute();

            dal.Close();
        }

        





    }

}