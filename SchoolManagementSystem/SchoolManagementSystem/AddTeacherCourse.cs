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
    public partial class AddTeacherCourse : Form
    {
        public AddTeacherCourse()
        {
            InitializeComponent();
            string sql = "select * from course;";
            DataAccess da = new DataAccess();
            DataSet ds = da.ExecuteQuery(sql);



            this.dataGridView1.AutoGenerateColumns = false;
            //this.dataGridView1.RowsDefaultCellStyle.ForeColor = Color.Black;
            this.dataGridView1.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from teacher where userid = '" + textBox1.Text + "';";
                DataAccess da = new DataAccess();
                DataSet ds = da.ExecuteQuery(sql);

                textBox3.Text = ds.Tables[0].Rows[0][1].ToString();

                
            }
            catch (Exception)
            {
                MessageBox.Show("Not found", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                string sql = @"insert into tcourse values('" + textBox1.Text + "','"+ textBox2.Text +"');";
                DataAccess da = new DataAccess();
                DataSet ds = da.ExecuteQuery(sql);




                MessageBox.Show("Saved", "SUCCESSFUL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
            else
            {
                MessageBox.Show("You didn't enter any Userid", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            string course = this.dataGridView1.CurrentRow.Cells["course"].Value.ToString();
            textBox2.Text = course; 
        }

        
    }
}
