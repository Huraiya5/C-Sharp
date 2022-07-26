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
    public partial class uploadMarks : Form
    {
        public uploadMarks()
        {
            InitializeComponent();
        }
        public uploadMarks(string username) : this()
        {
            this.label3.Text = username;

            string sql = "select * from tcourse where userid = '" + this.label3.Text + "';";
            DataAccess da = new DataAccess();
            DataSet ds = da.ExecuteQuery(sql);
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.DataSource = ds.Tables[0];


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = @"update studentmarks 
                            set marks  = '" + textBox1.Text + @"'
                            where userid ='" + this.textBox2.Text + @"' and course = '"+ this.label4.Text + @"';";
            DataAccess da = new DataAccess();
            DataSet ds = da.ExecuteQuery(sql);
            MessageBox.Show("Upload", "SUCCESSFUL", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            string userid = this.dataGridView1.CurrentRow.Cells["userid"].Value.ToString();
            textBox2.Text = userid;
        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            string course = this.dataGridView2.CurrentRow.Cells["course"].Value.ToString();
            label4.Text = course;

            string sql = "select * from studentmarks where course = '" + this.label4.Text + "';";
            DataAccess da = new DataAccess();
            DataSet ds = da.ExecuteQuery(sql);
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = ds.Tables[0];

        }
    }
}
