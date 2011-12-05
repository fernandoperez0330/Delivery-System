using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace deliveryweb.models
{
    class DataConexion
    {
        static DATABASEDataContext data;
        private DataConexion()
        {
            data = new DATABASEDataContext();
        }

        public static DATABASEDataContext getInstance()
        {
            if (data == null)
            {
                data = new DATABASEDataContext();
            }
             return data;
            
        }
    }
}
