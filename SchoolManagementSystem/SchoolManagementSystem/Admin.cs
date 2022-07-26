using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddStudent add = new AddStudent();
            add.Show();
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeleteStudent ds = new DeleteStudent();
            ds.Show();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTeacher ad = new AddTeacher();
            ad.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteTeacher dt = new DeleteTeacher();
            dt.Show();
        }

        private void updateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UpdateStudent us = new UpdateStudent();
            us.Show();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateTeacher ut = new UpdateTeacher();
            ut.Show();
        }

        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Course c = new Course();
            c.Show();
        }

        private void teacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTeacherCourse atc = new AddTeacherCourse();
            atc.Show();
        }

        private void studentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddStudentCourse asc = new AddStudentCourse();
            asc.Show();
        }

        private void tToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
