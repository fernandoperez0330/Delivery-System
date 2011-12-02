using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace deliverywindows.controllers
{
    using models;

    public class CamionManage:ManagersInterface
    {
        
        DATABASEDataContext data;
        TrucksManager cmanager;
        TrucksEditor ceditor;

        public CamionManage(TrucksManager mgr)
        {
            data = DataConexion.getInstance();
            cmanager = mgr;
        }
        public void setModifyFieldData()
        {
            ceditor.ID = Convert.ToInt32(cmanager.DGV.SelectedCells[0].Value.ToString());
            ceditor.Nombre = cmanager.DGV.SelectedCells[1].Value.ToString();
            ceditor.Descripcion = cmanager.DGV.SelectedCells[2].Value.ToString();
            
        }
        public void toDGV()
        {
            var query = from camiones in data.Camiones
                        select camiones;
            cmanager.DGV.DataSource = query;
        }
        public void setEditor(TrucksEditor edtr)
        {
            ceditor = edtr;
            var query = from ciudades in data.Ciudades
                        select ciudades.NOMBRE;
            string[] ciudads = query.ToArray();
           
        }
        public void Guardar()
        {
            if (ceditor.ID < 0)
            {
                Camione cm = new Camione 
                            {
                                NOMBRE = ceditor.Nombre,
                                DESCRIPCION = ceditor.Descripcion                                
                            };
                data.Camiones.InsertOnSubmit(cm);

            }
            else
            {
                var query = from c in data.Camiones
                            where c.CODIGO == ceditor.ID
                            select c;
                Camione m = query.First<Camione>();
                m.NOMBRE = ceditor.Nombre;
                m.DESCRIPCION = ceditor.Descripcion;
            

            }
            data.SubmitChanges();
            toDGV();
        }
        public void Borrar()
        {
            var query = from c in data.Camiones
                        where c.CODIGO == Convert.ToInt32(cmanager.DGV.SelectedCells[0].Value.ToString())
                        select c;
            Camione m = query.First<Camione>();
            data.Camiones.DeleteOnSubmit(m);
            data.SubmitChanges();
        }
    }
}
