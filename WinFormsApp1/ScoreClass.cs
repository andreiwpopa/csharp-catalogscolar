using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace WinFormsApp1
{
    class ScoreClass : DBOPAbstractClass
    {

        public int StudentId { get; set; }

        public string NumeCourse { get; set; }
        public double Nota { get; set; }
        public string Description { get; set; }

        // Constructor implicit
        public ScoreClass()
        {
        }

        public bool insertScore(int sid, string course, double sc, string desc)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `note` (`studentId`, `course`, `score`, `description`) VALUES (@sid, @cn, @sc, @desc)", connect.getConnection);

            command.Parameters.Add("@sid", MySqlDbType.Int32).Value = sid;
            command.Parameters.Add("@cn", MySqlDbType.VarChar).Value = course;
            command.Parameters.Add("@sc", MySqlDbType.Int32).Value = sc;
            command.Parameters.Add("@desc", MySqlDbType.VarChar).Value = desc;
            connect.openConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                return true;
            }
            else
            {
                connect.closeConnect();
                return false;
            }
        }

        public bool checkScore(int stdId, string course)
        {
            DataTable table = GetData(new MySqlCommand("SELECT * FROM `note` WHERE `studentId`='"+ stdId +"' AND `course`='"+ course +"'"));
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool updateScore(int sid, double sc, string desc)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `score` SET `score`=@sc, `description`=@desc WHERE `studentId`=@sid", connect.getConnection);
            // 
            command.Parameters.Add("@sid", MySqlDbType.Int32).Value = sid;
            command.Parameters.Add("@sc", MySqlDbType.Int32).Value = sc;
            command.Parameters.Add("@desc", MySqlDbType.VarChar).Value = desc;
            connect.openConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                return true;
            }
            else
            {
                connect.closeConnect();
                return false;
            }
        }

        public bool deleteScore(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `score` WHERE `studentId`=@id", connect.getConnection);
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

            connect.openConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                return true;
            }
            else
            {
                connect.closeConnect();
                return false;
            }
        }
    }
}
