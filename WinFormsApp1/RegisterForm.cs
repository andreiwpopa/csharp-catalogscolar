using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace WinFormsApp1
{
    public partial class RegisterForm : Form
    {
        StudentClass student = new StudentClass();

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void button_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Photo(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
                pictureBox_student.Image = Image.FromFile(opf.FileName);
        }

        bool verify()
        {
            if ((textBox_nume.Text == "") || (textBox_prenume.Text=="") || (textBox_telefon.Text=="") || (textBox_adresa.Text=="") || (pictureBox_student.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            string nume = textBox_nume.Text;
            string prenume = textBox_prenume.Text;
            DateTime dataNasterii = dateTimePicker1_dataNasterii.Value;
            string phone = textBox_telefon.Text;
            string adresa = textBox_adresa.Text;
            string sex = radioButton_masculin.Checked ? "Masculin" : "Feminin";

            int born_year = dateTimePicker1_dataNasterii.Value.Year;
            int this_year = DateTime.Now.Year;
            if((this_year - born_year) < 10 || (this_year - born_year) > 100)
            {
                MessageBox.Show("Studentul trebuie sa aibe intre 10 si 100 ani", "Data Nasterii Invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verify())
            {
                try
                {
                    MemoryStream ms = new MemoryStream();
                    pictureBox_student.Image.Save(ms, pictureBox_student.Image.RawFormat);
                    byte[] img = ms.ToArray();

                    if (student.insertStudent(nume, prenume, phone, dataNasterii, sex, img, adresa))
                    {
                        showTable();
                        MessageBox.Show("Studentul a fost adaugat", "Student adaugat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Campurile libere trebuie completate", "Adauga Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_nume.Clear();
            textBox_prenume.Clear();
            textBox_telefon.Clear();
            textBox_adresa.Clear();
            pictureBox_student.Image = null;
        }

        public void showTable()
        {
            dataGridView_student.DataSource = student.GetData(new MySqlCommand("SELECT * FROM `student`"));
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)dataGridView_student.Columns[6];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            showTable();
        }
    }
}
