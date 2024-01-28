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
    public partial class ManageScoreForm : Form
    {
        CourseClass course = new CourseClass();
        ScoreClass score = new ScoreClass();

        public ManageScoreForm()
        {
            InitializeComponent();
        }

        private void ManageScoreForm_Load(object sender, EventArgs e)
        {
            comboBox_course.DataSource = course.GetData(new MySqlCommand("SELECT * FROM `course`"));
            comboBox_course.DisplayMember = "name";
            comboBox_course.ValueMember = "name";

            showScore();
        }

        public void showScore()
        {
            dataGridView_score.DataSource = score.GetData(new MySqlCommand("SELECT note.studentId, student.StdNume, student.StdPrenume, note.course, note.score, note.description FROM student INNER JOIN note ON note.studentId=student.id"));

        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (textBox_stdId.Text == "" || textBox_score.Text == "")
            {
                MessageBox.Show("Toate campurile trebuie completate", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int sid = Convert.ToInt32(textBox_stdId.Text);
                //string course = comboBox_course.Text;
                double sc = Convert.ToInt32(textBox_score.Text);
                string desc = textBox_description.Text;

                    if (score.updateScore(sid, sc, desc))
                    {
                        showScore();
                        MessageBox.Show("Nota a fost actualizata", "Actualizare nota", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        button_clear.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Nota nu a fost actualizata", "Actualizare nota", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (textBox_stdId.Text == "")
            {
                MessageBox.Show("ID Student este obligatoriu", "Stergere Nota", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int id = Convert.ToInt32(textBox_stdId.Text);
                    if (score.deleteScore(id))
                    {
                        showScore();
                        MessageBox.Show("Nota a fost sters", "Stergere Nota", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        button_clear.PerformClick();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Stergere Nota", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_stdId.Clear();
            textBox_score.Clear();
            textBox_description.Clear();
            textBox_search.Clear();
        }
    }
}
