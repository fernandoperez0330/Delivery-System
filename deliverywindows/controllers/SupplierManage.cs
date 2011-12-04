using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace deliverywindows.controllers
{
    using models;
    using deliverywindows.utils;

    public class SupplierManage
    {
        DATABASEDataContext data;
        SupplierManager smanager;
        public SupplierEditor seditor;

        ModelSupplier model;



        public SupplierManage() 
        {
            data = DataConexion.getInstance();
            model = new ModelSupplier();
        }

        public Boolean Borrar()
        {
            try
            {
                this.model.supplier.Codigo = Convert.ToInt32(smanager.DGV.SelectedCells[0].Value);
            }
            catch (Exception exc) {
                Utils.logExceptionError(exc);
                return false;
            }

            if (this.model.delete())
            {
                ToDGV();
                return true;
            }
            else
                return false;
            
        }
        public Boolean Guardar()
        {
            //Inserta
            if (seditor.ID < 0)
            {
                model.supplier.Nombre = seditor.Nombre;
                model.supplier.Ciudad = Convert.ToInt32(seditor.Ciudad);
                model.supplier.Estado = seditor.Estado;
                model.supplier.Estado = seditor.Direccion;
                model.supplier.Nombrecorto = seditor.NombreCorto;
                model.supplier.Telefono = seditor.Telefono;

                return (model.add() == 1);
                 

            } 
            //actualizacion de suplidor
            else
            {
                model.supplier.Codigo = seditor.ID;
                model.supplier.Nombre = seditor.Nombre;
                model.supplier.Ciudad = Convert.ToInt32(seditor.Ciudad);
                model.supplier.Estado = seditor.Estado;
                model.supplier.Estado = seditor.Direccion;
                model.supplier.Nombrecorto = seditor.NombreCorto;
                model.supplier.Telefono = seditor.Telefono;
                return model.update();
            }
        }
        public void setUpdateFieldData(int id,string nombre,int ciudad,string estado,string telefono,string direccion,string nombrecorto)
        {
            seditor.ID = id;
            seditor.Nombre = nombre;
            seditor.Ciudad = ciudad;
            seditor.Estado = estado;
            seditor.Telefono = telefono;
            seditor.Direccion = direccion;
            seditor.NombreCorto = nombrecorto;
        }


        public void ToDGV()
        {
            var query = from suplidores in data.Suplidores
                        select new { suplidores.CODIGO, suplidores.NOMBRE, CIUDAD = suplidores.Ciudade.NOMBRE,suplidores.ESTADO, suplidores.TELEFONO, suplidores.DIRECCION1,suplidores.NOMBRECORTO};
            smanager.DGV.DataSource = query;
            
        }

        public void setManager(SupplierManager mgr)
        {
            smanager = mgr;
        }

        public void setEditor(ref SupplierEditor edtr)
        {
            seditor = edtr;
        }
    }
}
