
namespace MS_Project1
{
    class DatabaseConnection
    {
        private string oSqlStr;
        private string oSqlCon;
        System.Data.SqlClient.SqlDataAdapter oSqlDtAdptr;

        public string Sql
        {
            set { oSqlStr = value; }
        }

        public string ConStr
        {
            set { oSqlCon = value; } 
        }

        public System.Data.DataSet GetConnection
        {
            get { return MyDataSet(); }
        }

        public System.Data.DataSet MyDataSet()
        {
            System.Data.SqlClient.SqlConnection con = new
                System.Data.SqlClient.SqlConnection(oSqlCon);

            con.Open();
            oSqlDtAdptr = new System.Data.SqlClient.SqlDataAdapter(oSqlStr, con);
            System.Data.DataSet ds = new System.Data.DataSet();
            oSqlDtAdptr.Fill(ds);
            con.Close();

            return ds;
        }

        public void UpdateDatabase(System.Data.DataSet ds)
        {
            System.Data.SqlClient.SqlCommandBuilder oSqlCmdBdr = new
                System.Data.SqlClient.SqlCommandBuilder(oSqlDtAdptr);

            oSqlCmdBdr.DataAdapter.Update(ds.Tables[0]);
        }
    }//Class
}//NS
