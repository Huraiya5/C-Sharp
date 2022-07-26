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
    public partial class AddStudentCourse : Form
    {
        public AddStudentCourse()
        {
            InitializeComponent();
            string sql = "select * from course;";
            DataAccess da = new DataAccess();
            DataSet ds = da.ExecuteQuery(sql);



            this.dataGridView1.AutoGenerateColumns = false;
            //this.dataGridView1.RowsDefaultCellStyle.ForeColor = Color.Black;
            this.dataGridView1.DataSource = ds.Tables[0];
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from student where userid = '" + textsearch.Text + "';";
                DataAccess da = new DataAccess();
                DataSet ds = da.ExecuteQuery(sql);

                textname.Text = ds.Tables[0].Rows[0][1].ToString();

               

            }
            catch (Exception)
            {
                MessageBox.Show("Not found", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                
                string sql = @"insert into studentmarks values('" + textsearch.Text + "','" + textBox3.Text +"','"+ textBox1.Text +"');";
                DataAccess da = new DataAccess();
                DataSet ds = da.ExecuteQuery(sql);

                MessageBox.Show("Saved", "SUCCESSFUL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textname.Text = "";
                textsearch.Text = "";
                textBox3.Text = "";
            }
            else
            {
                MessageBox.Show("You didn't enter any course", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textname.Text = "";
                textsearch.Text = "";
                textBox3.Text = "";
            }
        }

       

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            string course = this.dataGridView1.CurrentRow.Cells["course"].Value.ToString();
            string sql = "select * from studentmarks where userid = '" + textsearch.Text + "' and  course = '"+course+"';";
            DataAccess da = new DataAccess();
            DataSet ds = da.ExecuteQuery(sql);

            if (ds.Tables[0].Rows.Count == 1)
            {
                MessageBox.Show("this course already enrolled");
            }
            else
            {
                textBox3.Text = course;
            }
            
        }
    }
}
