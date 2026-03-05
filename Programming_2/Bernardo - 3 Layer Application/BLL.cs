using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Intepro.DataAccess;
using System.Data;

namespace Suppliers.BussinessLogic
{
    class BLL
    {
        public int SupplierID { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string ContactPerson { get; set; }
        public string ContactNo { get; set; }

        private SQLDAL dal = new SQLDAL();

        public void Add()
        {
            dal.Open();

            dal.SetSql("INSERT INTO Suppliers VALUES (@a, @b, @c, @d, @e)");
            dal.AddParameter("@a", SupplierID);
            dal.AddParameter("@b", CompanyName);
            dal.AddParameter("@c", Address);
            dal.AddParameter("@d", ContactPerson);
            dal.AddParameter("@e", ContactNo);
            dal.Execute();

            dal.Close();

        }

        public DataTable GetAll()
        {
            dal.Open();
            dal.SetSql("SELECT * FROM Suppliers");
            DataTable dt = dal.GetData();
            dal.Close();

            return dt;
        }

        public void Delete()
        {
            dal.Open();
            dal.SetSql("DELETE Suppliers WHERE SupplierID = @id");
            dal.AddParameter("@id", SupplierID);
            dal.Execute();
            dal.Close();

        }

        public void Edit(int oldID)
        {
            dal.Open();

            dal.SetSql("UPDATE Suppliers " +
                "SET SupplierID = @id, " +
                "   CompanyName = @cn, " +
                "   Address = @ad, " +
                "   ContactPerson = @cp, " +
                "   ContactNo = @cno " +
                "WHERE SupplierID = @oldID");
            dal.AddParameter("@id", SupplierID);
            dal.AddParameter("@cn", CompanyName);
            dal.AddParameter("@ad", Address);
            dal.AddParameter("@cp", ContactPerson);
            dal.AddParameter("@cno", ContactNo);
            dal.AddParameter("@oldid", oldID);
            dal.Execute();

            dal.Close();

        }

        public void Validate()
        {
            if (SupplierID > 100000000 || SupplierID < 9999999)
            {
                Exception error = new Exception("Supplier ID must strictly be a unique 8 digit pin!");
                    error.Source = "Supplier Business Rules";
                throw error;
            }

            if (CompanyName.Length < 5 || CompanyName.Length > 50)
            {
                Exception error = new Exception("Company name must only range between 5 to 50 characters only!");
                error.Source = "Supplier Business Rules";
                throw error;
            }
        }
    }

}
