﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Main : Form
    {

        StudentClass student = new StudentClass();
        public Main()
        {
            InitializeComponent();
            customizeDesign();
        }


        private void button_std_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_stdsubmenu);
        }
        #region StdSubmenu
        private void button_registration_Click(object sender, EventArgs e)
        {

            openChildForm(new RegisterForm());

            hideSubmenu();
        }

        private void button_manageStudent_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageStudentsForm());

            hideSubmenu();
        }

        private void button_stdPrint_Click(object sender, EventArgs e)
        {

            hideSubmenu();
        }
        #endregion StdSubmenu
        private void button_course_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_courseSubmenu);
        }

        #region CourseSubmenu
        private void button_newCourse_Click(object sender, EventArgs e)
        {
            openChildForm(new CourseForm());

            hideSubmenu();
        }

        private void button_manageCourse_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageCourseForm());

            hideSubmenu();
        }

        private void button_coursePrint_Click(object sender, EventArgs e)
        {

            hideSubmenu();
        }
        #endregion CourseSubmenu
        private void button_score_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_scoreSubmenu);
        }
        #region ScoreSubmenu
        private void button_newScore_Click(object sender, EventArgs e)
        {
            openChildForm(new ScoreForm());

            hideSubmenu();
        }

        private void button_manageScore_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageScoreForm());

            hideSubmenu();
        }

 
        #endregion ScoreSubmenu
        private void button_exit_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            panel_main.Controls.Add(panel_cover);
            studentCount();
        }


        private void Main_Load(object sender, EventArgs e)
        {
            studentCount();
        }

        private void studentCount()
        {
            label_totalStd.Text = "Total Studenti: " + student.totalStudent();
        }

        private void customizeDesign()
        {
            panel_stdsubmenu.Visible = false;
            panel_courseSubmenu.Visible = false;
            panel_scoreSubmenu.Visible = false;
        }

        private void hideSubmenu()
        {
            if (panel_stdsubmenu.Visible == true)
                panel_stdsubmenu.Visible = false;
            if (panel_courseSubmenu.Visible == true)
                panel_courseSubmenu.Visible = false;
            if (panel_scoreSubmenu.Visible == true)
                panel_scoreSubmenu.Visible = false;
        }

        private void showSubmenu (Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }


        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panel_main.Controls.Add(childForm);
            panel_main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
