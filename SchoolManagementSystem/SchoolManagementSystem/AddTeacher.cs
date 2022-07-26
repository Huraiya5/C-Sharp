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
    public partial class AddTeacher : Form
    {
        public AddTeacher()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textName.Text != "" && textPass.Text != "" && comboGender.Text != "" && dateTimePicker.Text != "" && textPhn.Text != "" && textmail.Text != "" && textAdd.Text != "")
                {
                    string sql = "insert into teacher values('" + textName.Text + "','" + textPass.Text + "','" + comboGender.Text + "','" + dateTimePicker.Text + "','" + textPhn.Text + "','" + textmail.Text + "','" + textAdd.Text + "');";
                    DataAccess da = new DataAccess();
                    DataSet ds = da.ExecuteQuery(sql);
                    MessageBox.Show("Teacher added successful");
                }
                else
                {

                }
            }
            catch (Exception)
            {
                MessageBox.Show("This user name already used");
            }
        }
    }
}
