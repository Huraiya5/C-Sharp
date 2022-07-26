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
    public partial class SProfile : Form
    {
        public SProfile()
        {
            InitializeComponent();

        }
        public SProfile(string username) : this()
        {
            this.outuser.Text = username;
            string sql = "select * from student where userid = '" + this.outuser.Text + "';";
            DataAccess da = new DataAccess();
            DataSet ds = da.ExecuteQuery(sql);
            outName.Text = ds.Tables[0].Rows[0][1].ToString();
            outphn.Text = ds.Tables[0].Rows[0][5].ToString();
            outemail.Text = ds.Tables[0].Rows[0][6].ToString();
            outAdd.Text = ds.Tables[0].Rows[0][7].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentProfile sp = new StudentProfile(this.outuser.Text);
            sp.Show();
            this.Close();
        }
    }
}
