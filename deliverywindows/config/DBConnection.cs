﻿using System;
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
                this.connection = new SqlConnection(this.strcon);
                return true;
            }
            catch (Exception exc) {
                Utils.logExceptionError(exc);
                return false;
            }
        }
    }
}
