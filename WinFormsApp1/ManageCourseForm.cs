using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinFormsApp1
{
    public partial class ManageCourseForm : Form
    {

        CourseClass course = new CourseClass();
        public ManageCourseForm()
        {
            InitializeComponent();
        }

        private void ManageCourseForm_Load(object sender, EventArgs e)
        {
            showData();
        }

        private void showData()
        {
            dataGridView_course.DataSource = course.GetData(new MySqlCommand("SELECT * FROM `course`"));
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_id.Clear();
            textBox_Cname.Clear();
            textBox_Chour.Clear();
            textBox_description.Clear();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if ( textBox_id.Text.Equals(""))
            {
                MessageBox.Show("ID-ul cursului este obligatoriu", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int id = Convert.ToInt32(textBox_id.Text);
                    if (course.deleteCourse(id))
                    {
                        showData();
                        MessageBox.Show("Cursul a fost sters", "Stergere curs", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        button_clear.PerformClick();
                    }
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Stergere curs", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (textBox_Cname.Text == "" || textBox_Chour.Text == "" || textBox_id.Text.Equals(""))
            {
                MessageBox.Show("Toate campurile trebuie completate", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id = Convert.ToInt32(textBox_id.Text);
                string cName = textBox_Cname.Text;
                int chr = Convert.ToInt32(textBox_Chour.Text);
                string desc = textBox_description.Text;

                if (course.updateCourse(id, cName, chr, desc))
                {
                    showData();
                    MessageBox.Show("Cursul a fost actualizat", "Actualizare curs", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    button_clear.PerformClick();
                }
                else
                {
                    MessageBox.Show("Error - Cursul nu a fost actualizat", "Actualizare curs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView_course_Click(object sender, EventArgs e)
        {
            textBox_id.Text = dataGridView_course.CurrentRow.Cells[0].Value.ToString();
            textBox_Cname.Text = dataGridView_course.CurrentRow.Cells[1].Value.ToString();
            textBox_Chour.Text = dataGridView_course.CurrentRow.Cells[2].Value.ToString();
            textBox_description.Text = dataGridView_course.CurrentRow.Cells[3].Value.ToString();
        }

        private void button_cauta_Click(object sender, EventArgs e)
        {
            dataGridView_course.DataSource = course.GetData(new MySqlCommand("SELECT * FROM `course` WHERE CONCAT(`name`) LIKE '%"+textBox_search.Text+"%'"));
            textBox_search.Clear();
        }
    }
}
