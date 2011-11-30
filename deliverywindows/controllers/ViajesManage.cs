using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace deliverywindows.controllers
{
    using models;

    class ViajesManage:ManagersInterface
    {
        TravelsManager tmanager;
        TravelsEditor teditor;
        DATABASEDataContext data;

        public ViajesManage(TravelsManager mgr)
        {
            data = DataConexion.getInstance();
            setManager(ref mgr);
        }
        public void setManager(ref TravelsManager mgr)
        {
            tmanager = mgr;
        }
        public void setEditor(TravelsEditor  edtr) 
        {
            teditor = edtr;
        }
        public void Guardar()
        {
            toDGV();
        }
        public void toDGV()
        {
            var query = from viajes in data.Viajes
                        select viajes;
            tmanager.DGV.DataSource = query;
        }
    }
}
