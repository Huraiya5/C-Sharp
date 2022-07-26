using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem
{
    class DataAccess
    {
        private SqlConnection sqlcon;
        private SqlCommand sqlcom;
        private SqlDataAdapter sda;
        private DataSet ds;
        public SqlConnection Sqlcon
        {
            get { return this.sqlcon; }
            set { this.sqlcon = value; }
        }


        public SqlCommand Sqlcom
        {
            get { return this.sqlcom; }
            set { this.sqlcom = value; }
        }


        public SqlDataAdapter Sda
        {
            get { return this.sda; }
            set { this.sda = value; }
        }


        public DataSet Ds
        {
            get { return this.ds; }
            set { this.ds = value; }
        }
        public DataAccess()
        {
            this.Sqlcon = new SqlConnection(@"Data Source=DESKTOP-3TRTNKC;Initial Catalog=Student;Persist Security Info=True;User ID=sa;Password=L@boni522");
            this.Sqlcon.Open();
        }



        private void QueryText(string query)
        {
            this.Sqlcom = new SqlCommand(query, this.Sqlcon);
        }

        public DataSet ExecuteQuery(string sql)
        {
            this.QueryText(sql);
            this.Sda = new SqlDataAdapter(this.Sqlcom);
            this.Ds = new DataSet();
            this.Sda.Fill(this.Ds);
            return this.Ds;
        }
    }
}
