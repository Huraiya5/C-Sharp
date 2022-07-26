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
    public partial class DeleteTeacher : Form
    {
        public DeleteTeacher()
        {
            InitializeComponent();
            string sql = "select * from teacher;";
            DataAccess da = new DataAccess();
            DataSet ds = da.ExecuteQuery(sql);



            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.RowsDefaultCellStyle.ForeColor = Color.Black;
            this.dataGridView1.DataSource = ds.Tables[0];

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from teacher where userid like '" + this.textBox1.Text + "%';";
            DataAccess da = new DataAccess();
            DataSet ds = da.ExecuteQuery(sql);



            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string username = this.dataGridView1.CurrentRow.Cells["userid"].Value.ToString();



                string sql = "delete from teacher where userid = '" + username + "' ;";
                DataAccess da = new DataAccess();
                DataSet ds = da.ExecuteQuery(sql);



                MessageBox.Show("Deleted", "SUCCESSFUL", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            string sql = "select * from teacher;";
            DataAccess da = new DataAccess();
            DataSet ds = da.ExecuteQuery(sql);


            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = ds.Tables[0];

        }
    }
}
