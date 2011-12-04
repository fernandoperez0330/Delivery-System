using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using deliverywindows.entities;

namespace deliverywindows.models
{
    abstract class Model
    {

        /// <summary>
        /// 
        /// </summary>
        private DATABASEDataContext data;

        /// <summary>
        /// 
        /// </summary>
        private Entity entity;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public abstract int add();
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public abstract Boolean update();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="prkey"></param>
        /// <returns></returns>
        public abstract Entity find(int prkey);
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public abstract Boolean delete();

        /// <summary>
        /// 
        /// </summary>
        public Model()
        {
            this.Data = DataConexion.getInstance();
        }

        public Entity Entity
        {
            get { return entity; }
            set { entity = value; }
        }
        public DATABASEDataContext Data
        {
            get { return data; }
            set { data = value; }
        }

        
    }
}
