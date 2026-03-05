using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Intepro.DataAccess;
using Microsoft.Data.SqlClient;
using System.ComponentModel.DataAnnotations;

namespace Intepro.BusinessLogic
{
    public class AlbumBLL
    {
        public int AlbumID { get; set; }
        [Required(ErrorMessage = "Album Name is a required Field")]
        public string AlbumName { get; set; }
        [Required(ErrorMessage = "Artists is a required Field")]
        public string Artists { get; set; }
        [Range(1900, 2022, ErrorMessage =  "Year Released must range from 1900 to 2022")]
        public int YearReleased { get; set; }

        private SQLDAL dal = new SQLDAL();

        public void Add()
        {
               
            dal.Open();
            dal.SetSql("INSERT INTO Albums " +
                "(AlbumName, " +               
                "Artists, " +
                "YearReleased) " +
                "VALUES (@b, " +               
                "@c, " +
                "@d)");

            dal.AddParameter("@b", AlbumName);
            dal.AddParameter("@c", Artists);
            dal.AddParameter("@d", YearReleased);

            dal.Execute();
            dal.Close();

        }

        public List<AlbumBLL> GetAll()
        {
            List<AlbumBLL> list = new List<AlbumBLL>();
            dal.Open();
            dal.SetSql("SELECT * FROM Albums");
            SqlDataReader dr = dal.GetReader();
            while (dr.Read() == true)
            {
                AlbumBLL album = new AlbumBLL();
                album.AlbumID = (int)dr["AlbumID"];
                album.AlbumName = dr["AlbumName"].ToString();
                album.Artists = dr["Artists"].ToString();
                album.YearReleased = (int)dr["YearReleased"];

                list.Add(album);

            }
            dr.Close();
            dal.Close();

            return list;

        }

        public AlbumBLL Get(int id)
        {
            AlbumBLL album = new AlbumBLL();
            dal.Open();
            dal.SetSql("SELECT * FROM Albums WHERE AlbumID = @id");
            dal.AddParameter("@id", id);
            SqlDataReader dr = dal.GetReader();
            if (dr.Read() == true)
            {
                album.AlbumID = (int)dr[0];
                album.AlbumName = dr[1].ToString();
                album.Artists = dr[2].ToString();
                album.YearReleased = (int)dr[3];
            }
            dr.Close();
            dal.Close();
            return album;
        }

        public void Edit()
        {
            dal.Open();
            dal.SetSql("UPDATE Albums " +
                "SET  AlbumName = @b, " +
                "   Artists = @c, " +
                "   YearReleased = @d " +
                "WHERE AlbumID = @id");

            dal.AddParameter("@id", AlbumID);
            dal.AddParameter("@b", AlbumName);
            dal.AddParameter("@c", Artists);
            dal.AddParameter("@d", YearReleased);

            dal.Execute();
            dal.Close();
        }

        public void Delete()
        {
            dal.Open();
            dal.SetSql("DELETE Albums WHERE AlbumID = @id");
            dal.AddParameter("@id", AlbumID);
            dal.Execute();
            dal.Close();
        }

    }



}   