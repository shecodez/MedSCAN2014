using System;
using System.Data;
using System.Data.SqlClient;

namespace MedSCANLibrary
{
    /*----------------------------------------------------------------------------
    * Author: J. Nobles
    * Date: 3/23/2014
    * MedSCAN SQL Lib
    *///-------------------------------------------------------------------------
    public class DBWrapper
    {
        private SqlConnection oSqlCon;
        private SqlCommand oSqlCmd;
        private SqlDataAdapter oSqlDtAdptr;
        private SqlDataReader oSqlDrRdr;

        private SqlConnectionStringBuilder oConSB;

        // Constructors
        public DBWrapper(string SqlServerInstanceName, string DBName)
        {
            oConSB = new SqlConnectionStringBuilder();
            oConSB.DataSource = SqlServerInstanceName;
            oConSB.InitialCatalog = DBName;

            //must - enable integratgedsecurity
            oConSB.IntegratedSecurity = true;

            //create obj from the SqlConnectionClass
            oSqlCon = new SqlConnection();

            //set the connection string
            oSqlCon.ConnectionString = oConSB.ConnectionString;
           
        }

        public DBWrapper(string SqlServerInstanceName, string DBName, string DbUN, string DbPW)
        {
            oConSB = new SqlConnectionStringBuilder();
            oConSB.DataSource = SqlServerInstanceName;
            oConSB.InitialCatalog = DBName;

            oConSB.UserID = DbUN;
            oConSB.Password = DbPW;

            //optional - disable integrated security
            oConSB.IntegratedSecurity = false;

            //create obj from the SqlConnectionClass
            oSqlCon = new SqlConnection();

            //set the connection string
            oSqlCon.ConnectionString = oConSB.ConnectionString;


        }

        public DBWrapper(string SqlConnectionStr)
        {
            oSqlCon = new SqlConnection(SqlConnectionStr);
        }

        //INSERT UPDATE and DELETE 
        public int InsertUpdateDelete(string sqlCmdAsStr)
        {
            try
            {
                //check id con is not open
                if (oSqlCon.State != ConnectionState.Open)
                {
                    oSqlCon.Open();
                }

                using (oSqlCmd = new SqlCommand())
                {
                    //set con for cmd
                    oSqlCmd.Connection = oSqlCon;

                    //assign insert query as text to sql cmd
                    oSqlCmd.CommandText = sqlCmdAsStr;

                    //will return # of rows affected, by query
                    return oSqlCmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (oSqlCon.State == ConnectionState.Open)
                {
                    oSqlCon.Close();
                }
            }
        }

        public DataSet FillDataSet(string sqlSelectCmdAsStr)
        {
            try
            {
                //check con
                if (oSqlCon.State != ConnectionState.Open)
                {
                    oSqlCon.Open();
                }

                DataSet ds = new DataSet();
                using (oSqlCmd = new SqlCommand())
                {
                    //set con for cmd
                    oSqlCmd.Connection = oSqlCon;

                    //assign insert query as text to the sql cmd
                    oSqlCmd.CommandText = sqlSelectCmdAsStr;

                    using (oSqlDtAdptr = new SqlDataAdapter())
                    {
                        oSqlDtAdptr.SelectCommand = oSqlCmd;
                        oSqlDtAdptr.Fill(ds);
                        return ds;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (oSqlCon.State == ConnectionState.Open)
                {
                    oSqlCon.Close();
                }
            }
        }

    }//Class
}//NS
