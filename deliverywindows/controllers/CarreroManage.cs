using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using deliverywindows.utils;

namespace deliverywindows.controllers
{
    using models;
    using deliverywindows.utils;

   public class CarreroManage:ManagersInterface
    {
        DATABASEDataContext data;
        CartersManager cmanager;
        CartersEditor ceditor;

        public CarreroManage(CartersManager mgr)
        {
            data = DataConexion.getInstance();
            cmanager = mgr;
        }
        public void setModifyFieldData()
        {
            try {
                ceditor.ID = Convert.ToInt32(cmanager.DGV.SelectedCells[0].Value.ToString());
                ceditor.Nombre = cmanager.DGV.SelectedCells[1].Value.ToString();
                ceditor.Direccion = cmanager.DGV.SelectedCells[2].Value.ToString();
                ceditor.Ciudad = cmanager.DGV.SelectedCells[3].Value.ToString();
                ceditor.Telefono = cmanager.DGV.SelectedCells[4].Value.ToString();
            }catch(Exception exc){
                Utils.logExceptionError(exc);
            }
        }
        public void toDGV()
        {
            var query = from carreros in data.Empleados
                        select carreros;
            cmanager.DGV.DataSource = query;
        }

        public void setEditor(CartersEditor edtr)
        {
            ceditor = edtr;
        }


        public void Guardar()
        {
            if (ceditor.ID < 0)
            {
                Empleado em = new Empleado 
                            {
                                NOMBRE = ceditor.Nombre,
                                CIUDAD = ceditor.Ciudad,
                                DIRECCION = ceditor.Direccion,
                                TELEFONO = ceditor.Telefono
                            };
                data.Empleados.InsertOnSubmit(em);

            }
            else
            {
                var query = from carrero in data.Empleados
                            where carrero.CODIGO == ceditor.ID
                            select carrero;
                Empleado em = query.First<Empleado>();
                em.NOMBRE = ceditor.Nombre;
                em.DIRECCION = ceditor.Direccion;
                em.CIUDAD = ceditor.Ciudad;
                em.TELEFONO = ceditor.Telefono;

            }
            data.SubmitChanges();
            toDGV();
        }
        public void Borrar()
        {
            try
            {
                var query = from carrero in data.Empleados
                            where carrero.CODIGO == Convert.ToInt32(cmanager.DGV.SelectedCells[0].Value.ToString())
                            select carrero;
                Empleado em = query.First<Empleado>();
                data.Empleados.DeleteOnSubmit(em);
                data.SubmitChanges();
            }
            catch (Exception exc) {
                Utils.logExceptionError(exc);
            }
        }
    }
}
