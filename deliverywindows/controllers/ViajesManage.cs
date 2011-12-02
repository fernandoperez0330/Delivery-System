using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace deliverywindows.controllers
{
    using models;

   public class ViajesManage:ManagersInterface
    {
        TravelsManager tmanager;
        TravelsEditor teditor;
        DATABASEDataContext data;

        public ViajesManage(TravelsManager mgr)
        {
            data = DataConexion.getInstance();
            setManager(ref mgr);
            toDGV();
        }
        public void setFieldValues()
        {
            teditor.ID = Convert.ToInt32(tmanager.DGV.SelectedCells[0].Value.ToString());
            teditor.Fecha = Convert.ToDateTime(tmanager.DGV.SelectedCells[1].Value.ToString());
            if(Convert.ToInt32(tmanager.DGV.SelectedCells[2].Value.ToString()) == 1) teditor.Activo =  true;
            if (Convert.ToInt32(tmanager.DGV.SelectedCells[2].Value.ToString()) == 0) teditor.Inactivo = true;
        }
        public void setManager(ref TravelsManager mgr)
        {
            tmanager = mgr;
        }
        public void setEditor(TravelsEditor  edtr) 
        {
            teditor = edtr; 
        }

        public void Borrar()
        {
            var query = from viajes in data.Viajes
                        where viajes.CODIGO == Convert.ToInt32(tmanager.DGV.SelectedCells[0].Value.ToString())
                        select viajes;
            Viaje viaje = query.First<Viaje>();
            data.Viajes.DeleteOnSubmit(viaje);

            data.SubmitChanges();
        }
        public void Guardar()
        {
            int status = 0;

            if (teditor.Activo) status = 1;
            if (teditor.Inactivo) status = 0;

            if (teditor.ID < 0)//inserta
            {
                Viaje viaje = new Viaje
                {
                    FECHAVIAJE = teditor.Fecha
                ,
                    ESTATUS = status
                };
                data.Viajes.InsertOnSubmit(viaje);

            }
            else//modifica
            {
                var query = from viajes in data.Viajes
                            where viajes.CODIGO == teditor.ID
                            select viajes;
                Viaje viaje = query.First<Viaje>();
                viaje.ESTATUS = status;
                viaje.FECHAVIAJE = teditor.Fecha;
            }

            data.SubmitChanges();
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
