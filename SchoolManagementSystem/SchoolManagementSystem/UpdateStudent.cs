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
    public partial class UpdateStudent : Form
    {
        public UpdateStudent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from student where userid = '" + txtUser.Text + "';";
                DataAccess da = new DataAccess();
                DataSet ds = da.ExecuteQuery(sql);




                textName.Text = ds.Tables[0].Rows[0][1].ToString();
                
                dateTimePicker.Text = ds.Tables[0].Rows[0][4].ToString();
                textPhn.Text = ds.Tables[0].Rows[0][5].ToString();
                textmail.Text = ds.Tables[0].Rows[0][6].ToString();
                textAdd.Text = ds.Tables[0].Rows[0][7].ToString();
                
            }
            catch (Exception)
            {
                MessageBox.Show("Not found", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnstudent_Click(object sender, EventArgs e)
        {
            if (txtUser.Text != "")
            {
                string sql = @"update student 
                            set name  = '" + textName.Text + @"',
                            dateofbirth  = '" + dateTimePicker.Text + @"',
                            phone  = '" + textPhn.Text + @"',
                            email  = '" + textmail.Text + @"',
                            address  = '" + textAdd.Text + @"'
                            where userid ='" + txtUser.Text + @"';";
                DataAccess da = new DataAccess();
                DataSet ds = da.ExecuteQuery(sql);




                MessageBox.Show("Saved", "SUCCESSFUL", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("You didn't enter any Userid", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        
    }
}
