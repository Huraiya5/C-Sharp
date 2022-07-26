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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(50, 0, 0, 0);
        }

        

        private void btnlogin_Click(object sender, EventArgs e)
        {


            if(label4.Text=="Admin")
            {
                if (textBox1.Text == "Admin" && textBox2.Text == "Admin")
                {

                    MessageBox.Show("Successful");
                    Admin ad = new Admin();
                    ad.Show();
                    textBox1.Text = "";
                    textBox2.Text = "";

                }
                else
                {
                    MessageBox.Show("Login Invalid");
                    textBox1.Text = "";
                    textBox2.Text = "";

                }
            }
            else if(label4.Text=="Student")
            {
                string sql = "select * from student where userid = '" + this.textBox1.Text + "' and password = '" + this.textBox2.Text + "';";
                DataAccess da = new DataAccess();
                DataSet ds = da.ExecuteQuery(sql);
                if (ds.Tables[0].Rows.Count == 1)
                {
                    MessageBox.Show("Login approved for " + ds.Tables[0].Rows[0][1].ToString());
                    StudentProfile sp = new StudentProfile(this.textBox1.Text);
                    sp.Show();
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
                else
                {
                    MessageBox.Show("Login Invalid");
                    textBox1.Text = "";
                    textBox2.Text = "";

                }
            }
            else if(label4.Text=="Teacher")
            {
                string sql = "select * from teacher where userid = '" + this.textBox1.Text + "' and password = '" + this.textBox2.Text + "';";
                DataAccess da = new DataAccess();
                DataSet ds = da.ExecuteQuery(sql);
                if (ds.Tables[0].Rows.Count == 1)
                {
                    MessageBox.Show("Login approved for " + ds.Tables[0].Rows[0][1].ToString());
                    TeacherProfile tp = new TeacherProfile(this.textBox1.Text);
                    tp.Show();
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
                else
                {
                    MessageBox.Show("Login Invalid");
                    textBox1.Text = "";
                    textBox2.Text = "";

                }
            }
            else
            {
                MessageBox.Show("Try Again");
                textBox1.Text = "";
                textBox2.Text = "";
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label4.Text = radioButton1.Text.ToString();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label4.Text = radioButton2.Text.ToString();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label4.Text = radioButton3.Text.ToString();
        }
    }
}
