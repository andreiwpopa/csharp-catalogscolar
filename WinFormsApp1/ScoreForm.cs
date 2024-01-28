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
    public partial class ScoreForm : Form
    {
        ScoreClass score = new ScoreClass();
        StudentClass student = new StudentClass();
        CourseClass course = new CourseClass();

        public ScoreForm()
        {
            InitializeComponent();
        }

        private void showScore()
        {
            dataGridView_score.DataSource = score.GetData(new MySqlCommand("SELECT * FROM `note`"));
        }

        private void ScoreForm_Load(object sender, EventArgs e)
        {
            comboBox_course.DataSource = course.GetData(new MySqlCommand("SELECT * FROM `course`"));
            comboBox_course.DisplayMember = "name";
            comboBox_course.ValueMember = "name";

            showScore();

            dataGridView_student.DataSource = student.GetData(new MySqlCommand("SELECT `id`,`StdNume`,`StdPrenume` FROM `student`"));

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (textBox_stdId.Text == "" || textBox_score.Text == "")
            {
                MessageBox.Show("Toate campurile trebuie completate", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int sid = Convert.ToInt32(textBox_stdId.Text);
                string course = comboBox_course.Text;
                double sc = Convert.ToInt32(textBox_score.Text);
                string desc = textBox_description.Text;

                if (!score.checkScore(sid, course))
                {
                    if (score.insertScore(sid, course, sc, desc))
                    {
                        showScore();
                        MessageBox.Show("Nota a fost adaugat", "Adauga nota", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        button_clear.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Nota nu a fost adaugat", "Adauga nota", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Exista deja o nota pentru acest curs", "Adauga Nota", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_stdId.Clear();
            textBox_score.Clear();
            comboBox_course.SelectedIndex = 0;
            textBox_description.Clear();
        }

        private void dataGridView_student_Click(object sender, EventArgs e)
        {
            textBox_stdId.Text = dataGridView_student.CurrentRow.Cells[0].Value.ToString();

        }
    }
}
