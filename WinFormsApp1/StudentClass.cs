using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace WinFormsApp1
{
    class StudentClass : DBOPAbstractClass
    {

        public int Id { get; set; } 

        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Telefon { get; set; }
        public DateTime DataNasterii { get; set; }
        public string Sex { get; set; }
        public byte[] Img { get; set; }
        public string Adresa { get; set; }

        // Constructor implicit
        public StudentClass()
        {
        }


        public bool insertStudent(string nume, string prenume, string telefon, DateTime dataNasterii, string sex, byte[] img, string adresa)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO student(`StdNume`, `StdPrenume`, `Telefon`, `DataNasterii`, `Sex`, `Photo`, `Adresa`) VALUES (@fn, @ln, @ph, @bd, @gd, @img, @adr)", connect.getConnection);

            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = nume;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = prenume;
            command.Parameters.Add("@bd", MySqlDbType.Date).Value = dataNasterii;
            command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = telefon;
            command.Parameters.Add("@gd", MySqlDbType.VarChar).Value = sex;
            command.Parameters.Add("@img", MySqlDbType.Blob).Value = img;
            command.Parameters.Add("@adr", MySqlDbType.VarChar).Value = adresa;


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

        public bool updateStudent(int id, string nume, string prenume, string telefon, DateTime dataNasterii, string sex, byte[] img, string adresa)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `student` SET `StdName`=@fn, `StdPrenume`=@ln, `Telefon`=@ph, `DataNasterii`=@bd , `Sex`=@gd , `Photo`=@img , `Adresa`=@adr WHERE `id`=@id", connect.getConnection);

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = nume;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = prenume;
            command.Parameters.Add("@bd", MySqlDbType.Date).Value = dataNasterii;
            command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = telefon;
            command.Parameters.Add("@gd", MySqlDbType.VarChar).Value = sex;
            command.Parameters.Add("@img", MySqlDbType.Blob).Value = img;
            command.Parameters.Add("@adr", MySqlDbType.VarChar).Value = adresa;


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

        public bool deleteStudent(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `student` WHERE `id`=@id", connect.getConnection);
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


        public string exeCount(string query)
        {
            MySqlCommand command = new MySqlCommand(query, connect.getConnection);
            connect.openConnect();
            string count = command.ExecuteScalar().ToString();
            connect.closeConnect();
            return count;
        }

        public string totalStudent()
        {
            return exeCount("SELECT COUNT(*) FROM student");
        }

        public DataTable searchStudent(string search)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `student` WHERE CONCAT(`StdNume`, `StdPrenume`, `Adresa`) LIKE '%"+ search +"%'", connect.getConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

    }
}
