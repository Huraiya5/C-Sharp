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
    public partial class StudentViewResult : Form
    {
        public StudentViewResult()
        {
            InitializeComponent();
           
        }
        public StudentViewResult(string username) :this()
        {
            this.label2.Text = username;
            string sql = "select * from studentmarks where userid = '" + this.label2.Text + "';";
            DataAccess da = new DataAccess();
            DataSet ds = da.ExecuteQuery(sql);



            this.dataGridView1.AutoGenerateColumns = false;
            //this.dataGridView1.RowsDefaultCellStyle.ForeColor = Color.Black;
            this.dataGridView1.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentProfile sp = new StudentProfile(this.label2.Text);
            sp.Show();
            this.Close();
        }
    }
}
