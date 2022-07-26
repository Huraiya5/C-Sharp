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
    public partial class Course : Form
    {
        public Course()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {
                    string sql = "insert into course values('" + textBox1.Text + "');";
                    DataAccess da = new DataAccess();
                    DataSet ds = da.ExecuteQuery(sql);
                    MessageBox.Show("Course added successful");
                }
                else
                {

                }
            }
            catch (Exception)
            {
                MessageBox.Show("This course is already insert");
            }
        }
    }
}
