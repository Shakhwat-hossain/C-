using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;


namespace ComputerShop
{
    class DataAccess
    {
        private SqlConnection sqlcon;


        //The fields have been declared of the respected four class to use further anywhere in the code 
        public SqlConnection Sqlcon
        {
            get { return this.sqlcon; }
            set { this.sqlcon = value; }
        }
        private SqlCommand sqlcom;
        public SqlCommand Sqlcom
        {
            get { return this.sqlcom; }
            set { this.sqlcom = value; }
        }
        private SqlDataAdapter sda;
        public SqlDataAdapter Sda
        {
            get { return this.sda; }
            set { this.sda = value; }
        }
        private DataSet ds;
        public DataSet DS
        {
            get { return this.ds; }
            set { this.ds = value; }
        }
        //internal datatable dt:
        // DataAccess construction is calling because the object of dataAccess class has been created
        // Default Constructor 
        public DataAccess()

        {
            this.Sqlcon = new SqlConnection(@"Data Source=ARABI;Initial Catalog=pcdb;Integrated Security=True");
            this.sqlcon.Open();

        }
        // step 1 has been completed when the constructor was called 
        private void QueryText(string query)
        {
            this.Sqlcom = new SqlCommand(query, this.Sqlcon);
        }

        //step 2:
        public DataSet ExecuteQuery(string sql)
        {
            try
            {
                this.QueryText(sql);
                this.Sda = new SqlDataAdapter(this.Sqlcom);//step 3: we need to create object to write the query and give the Sqlcom to the  parameter to
                this.ds = new DataSet(); //step 4: To save the result we need to create the object of DataSet method h
                this.Sda.Fill(this.ds);
                return this.ds;

            }
            catch (Exception exc)
            {
                return null; // if doesnt work properly we will return null value
            }
        }
        public DataTable ExecuteQueryTable(string sql)
        {
            this.ExecuteQuery(sql);
            if (this.ds != null)
                return this.ds.Tables[0];
            else
                return null;

        }
        public int ExecuteUpdateQuery(string sql)
        {
            this.QueryText(sql);
            int u = this.Sqlcom.ExecuteNonQuery();
            return u;
        }

        //  public int ExecuteUpdateQuery(string sql)
    }
}
