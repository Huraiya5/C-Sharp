using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void btnstudent_Click(object sender, EventArgs e)
        {
            
                if (textName.Text != "" && textPass.Text != "" && combGender.Text != "" && dateTimePicker.Text != "" && textPhn.Text != "" && textmail.Text != "" && textAdd.Text != "")
                {
                    string sql = "insert into student values('" + textName.Text + "','" + textPass.Text + "','" + combGender.Text + "','" + dateTimePicker.Text + "','" + textPhn.Text + "','" + textmail.Text + "','" + textAdd.Text + "');";
                    DataAccess da = new DataAccess();
                    DataSet ds = da.ExecuteQuery(sql);
                    MessageBox.Show("Student added successful");

                }
                else
                {
                    MessageBox.Show("Fill all the information");
                }
            
        }

        
    }
}
