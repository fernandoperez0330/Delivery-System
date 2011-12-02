using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using deliverywindows.utils;

namespace deliverywindows.config
{
    class DBConnection
    {
        /// <summary>
        /// 
        /// </summary>
        private String strcon;
        /// <summary>
        /// 
        /// </summary>
        private SqlConnection connection;

        public SqlConnection Connection
        {
            get { return connection; }
            set { connection = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public DBConnection() {
            this.strcon = ConfigurationManager.ConnectionStrings["conexionSQL"].ConnectionString;
            this.connect();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private Boolean connect(){
            try
            {
                this.Connection = new SqlConnection(this.strcon);
                return true;
            }
            catch (Exception exc) {
                Utils.logException(exc);
                return false;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        public void open(){
            try{
                this.Connection.Open();
            }catch(SqlException exc){
                Utils.logException(exc);
                this.Connection.Close();
                this.Connection.Open();
            }
        
        }

        public void close() {
            try { 
                this.Connection.Close();
            }
            catch(SqlException exc){
                Utils.logException(exc);
            }
        }


    }
}
