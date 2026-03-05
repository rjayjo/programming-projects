using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Students.DataAccess;
using Microsoft.Data.SqlClient;
using System.ComponentModel.DataAnnotations;

namespace Students.BusinessLogic
{
    public class StudentsBLL
    {
        public int StudentID { get; set; }
        [Required]
        public string Lastname { get; set; }
        [MinLength(5, ErrorMessage = "Artist Name must be at least 5 characters")]
        [StringLength(40, ErrorMessage = "Artist Name cannot exceed 40 Characters")]
        public string Firstname { get; set; }

        private sql dal = new sql();
        public void Add()
        {
            dal.Open();
            dal.SetSql("INSERT INTO Students " + "(Lastname, Firstname) " + "VALUES (@ln, @fn)");
            dal.AddParameter("@ln", Lastname);
            dal.AddParameter("@fn", Firstname);
            dal.Execute();
            dal.Close();
        }
        public List<StudentsBLL> GetAll()
        {
            List<StudentsBLL> list = new List<StudentsBLL>();
            dal.Open();
            dal.SetSql("SELECT * FROM Students");
            SqlDataReader dr = dal.GetReader();
            while (dr.Read() == true)
            {
                StudentsBLL students = new StudentsBLL();
                students.StudentID = (int)dr["StudentID"];
                students.Lastname = dr["Lastname"].ToString();
                students.Firstname = dr["Firstname"].ToString();

                list.Add(students);
            }
            dr.Close();
            dal.Close();

            return list;
        }
        public StudentsBLL Get(int id)
        {
            StudentsBLL students = new StudentsBLL();

            dal.Open();
            dal.SetSql("SELECT * FROM Students WHERE StudentID = @id");
            dal.AddParameter("@id", id);
            SqlDataReader dr = dal.GetReader();
            if (dr.Read() == true)
            {
                students.StudentID = (int)dr[0];
                students.Lastname = dr[1].ToString();
                students.Firstname = dr[2].ToString();
            }
            dr.Close();
            dal.Close();
            return students;
        }
        public void Edit()
        {
            dal.Open();
            dal.SetSql("UPDATE Students " +
                "SET    Lastname = @ln, " +
                "       Firstname = @fn " +
                "WHERE StudentID = @id");
            dal.AddParameter("@ln", Lastname);
            dal.AddParameter("@fn", Firstname);
            dal.AddParameter("@id", StudentID);
            dal.Execute();
            dal.Close();
        }
        public void Delete()
        {
            dal.Open();
            dal.SetSql("DELETE Students WHERE StudentID = @id");
            dal.AddParameter("@id", StudentID);
            dal.Execute();
            dal.Close();
        }
    }

}
