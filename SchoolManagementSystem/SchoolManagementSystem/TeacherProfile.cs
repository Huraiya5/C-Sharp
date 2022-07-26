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
    public partial class TeacherProfile : Form
    {
        public TeacherProfile()
        {
            InitializeComponent();
        }

        public TeacherProfile(string username) : this()
        {
            this.label1.Text = username;
            
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TProfile tpo = new TProfile(this.label1.Text);
            tpo.Show();
        }

        private void uploadMarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uploadMarks up = new uploadMarks(this.label1.Text);
            up.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
