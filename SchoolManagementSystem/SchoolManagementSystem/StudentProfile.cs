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
    public partial class StudentProfile : Form
    {
        public StudentProfile()
        {
            InitializeComponent();
        }
        public StudentProfile(string username) : this()
        {
            this.label1.Text = username;
            string sql = "select * from studentmarks where userid = '" + this.label1.Text + "';";
            DataAccess da = new DataAccess();
            DataSet ds = da.ExecuteQuery(sql);
            label2.Text = ds.Tables[0].Rows[0][2].ToString();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SProfile stp = new SProfile(this.label1.Text);
            stp.Show();
            this.Close();
        }

        private void viewResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentViewResult sv = new StudentViewResult(this.label1.Text);
            sv.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
