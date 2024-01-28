﻿using System;
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
    public partial class CourseForm : Form
    {
        CourseClass course = new CourseClass();

        public CourseForm()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (textBox_Cname.Text == "" || textBox_Chour.Text == "")
            {
                MessageBox.Show("Toate campurile trebuie completate", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string cName = textBox_Cname.Text;
                int chr = Convert.ToInt32(textBox_Chour.Text);
                string desc = textBox_description.Text;

                if (course.insertCourse(cName, chr, desc))
                {
                    showData();
                    MessageBox.Show("Cursul a fost adaugat", "Adauga curs", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    button_clear.PerformClick();
                }
                else
                {
                    MessageBox.Show("Cursul nu a fost adaugat", "Adauga curs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_Cname.Clear();
            textBox_Chour.Clear();
            textBox_description.Clear();
        }

        private void CourseForm_Load(object sender, EventArgs e)
        {
            showData();
        }

        private void showData()
        {
            dataGridView_course.DataSource = course.GetData(new MySqlCommand("SELECT * FROM `course`"));

        }
    }
}
