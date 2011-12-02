using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using deliverywindows.config;
using deliverywindows.entities;

namespace deliverywindows.models
{
    abstract class Model
    {
        /// <summary>
        /// 
        /// </summary>
        public DBConnection dbConnection;
        /// <summary>
        /// 
        /// </summary>
        public Model() {
            this.dbConnection = new DBConnection();
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public abstract Boolean add(Entity entity);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public abstract Boolean update(Entity entity);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="prkey"></param>
        /// <returns></returns>
        public abstract Entity find(int prkey);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public abstract Boolean remove(Entity entity);
    }
}
