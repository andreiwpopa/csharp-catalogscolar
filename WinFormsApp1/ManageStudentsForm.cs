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
    public partial class ManageStudentsForm : Form
    {
        StudentClass student = new StudentClass();
        public ManageStudentsForm()
        {
            InitializeComponent();
        }

        private void ManageStudentsForm_Load(object sender, EventArgs e)
        {
            showTable();
        }

        public void showTable()
        {
            dataGridView_student.DataSource = student.GetData(new MySqlCommand("SELECT * FROM `student`"));
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)dataGridView_student.Columns[6];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        bool verify()
        {
            if ((textBox_nume.Text == "") || (textBox_prenume.Text == "") || (textBox_telefon.Text == "") || (textBox_adresa.Text == "") || (pictureBox_student.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private void dataGridView_student_Click(object sender, EventArgs e)
        {
            textBox_id.Text = dataGridView_student.CurrentRow.Cells[0].Value.ToString();
            textBox_nume.Text = dataGridView_student.CurrentRow.Cells[1].Value.ToString();
            textBox_prenume.Text = dataGridView_student.CurrentRow.Cells[2].Value.ToString();
            textBox_telefon.Text = dataGridView_student.CurrentRow.Cells[3].Value.ToString();
            dateTimePicker1_dataNasterii.Value = (DateTime)dataGridView_student.CurrentRow.Cells[4].Value;

            if (dataGridView_student.CurrentRow.Cells[5].Value.ToString() == "Masculin")
                radioButton_masculin.Checked = true;
            else
                radioButton_feminin.Checked = true;

            textBox_adresa.Text = dataGridView_student.CurrentRow.Cells[7].Value.ToString();
            byte[] img = (byte[])dataGridView_student.CurrentRow.Cells[6].Value;
            MemoryStream ms = new MemoryStream(img);
            pictureBox_student.Image = Image.FromStream(ms);


        }

        private void button_update_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox_id.Text);
            string nume = textBox_nume.Text;
            string prenume = textBox_prenume.Text;
            DateTime dataNasterii = dateTimePicker1_dataNasterii.Value;
            string phone = textBox_telefon.Text;
            string adresa = textBox_adresa.Text;
            string sex = radioButton_masculin.Checked ? "Masculin" : "Feminin";

            int born_year = dateTimePicker1_dataNasterii.Value.Year;
            int this_year = DateTime.Now.Year;
            if ((this_year - born_year) < 10 || (this_year - born_year) > 100)
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

                    if (student.updateStudent(id, nume, prenume, phone, dataNasterii, sex, img, adresa))
                    {
                        showTable();
                        MessageBox.Show("Studentul a fost actualizat", "Student actualizat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Campurile libere trebuie completate", "Actualizeaza Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_nume.Clear();
            textBox_prenume.Clear();
            textBox_telefon.Clear();
            textBox_adresa.Clear();
            radioButton_masculin.Checked = true;
            dateTimePicker1_dataNasterii.Value = DateTime.Now;
            pictureBox_student.Image = null;
        }

        private void button_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Photo(*.jpg;*.png;*.gif|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
                pictureBox_student.Image = Image.FromFile(opf.FileName);
        }

        private void button_cauta_Click(object sender, EventArgs e)
        {
            dataGridView_student.DataSource = student.searchStudent(textBox_search.Text);
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)dataGridView_student.Columns[6];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (textBox_id.Text.Equals(""))
            {
                MessageBox.Show("ID-ul studentului este obligatoriu", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int id = Convert.ToInt32(textBox_id.Text);
                    if (student.deleteStudent(id))
                    {
                        showTable();
                        MessageBox.Show("Studentul a fost sters", "Stergere student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        button_clear.PerformClick();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Stergere student", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
    }
}
