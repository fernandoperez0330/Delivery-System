using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace deliverywindows.controllers
{
    using models;

    public class SupplierManage:ManagersInterface
    {
        DATABASEDataContext data;
        SupplierManager smanager;
        SupplierEditor seditor;

        public SupplierManage() 
        {
            data = DataConexion.getInstance();
        }

        public void Borrar()
        {
            var query = from suplidor in data.Suplidores
                        where suplidor.CODIGO == Convert.ToInt32(smanager.DGV.SelectedCells[0].Value.ToString())
                        select suplidor;

            Suplidore s = query.First<Suplidore>();
            data.Suplidores.DeleteOnSubmit(s);
            data.SubmitChanges();
            ToDGV();
        }
        public void Guardar()
        {
            //Inserta
            if (seditor.ID < 0)
            {
                Suplidore s = new Suplidore
                                {
                                    NOMBRE = seditor.Nombre,
                                    CIUDAD = seditor.Ciudad,
                                    ESTADO = seditor.Estado,
                                    DIRECCION1 = seditor.Direccion,
                                    NOMBRECORTO = seditor.NombreCorto,
                                    TELEFONO = seditor.Telefono
                                    
                                };
                data.Suplidores.InsertOnSubmit(s);
            }
            //Modifica
            else
            {
                var query = from suplidor in data.Suplidores
                            where suplidor.CODIGO == seditor.ID
                            select suplidor;

                Suplidore s = query.First<Suplidore>();
                s.NOMBRE = seditor.Nombre;
                s.CIUDAD = seditor.Ciudad;
                s.ESTADO = seditor.Estado;
                s.DIRECCION1 = seditor.Direccion;
                s.NOMBRECORTO = seditor.NombreCorto;
                s.TELEFONO = seditor.Telefono;
            }

            data.SubmitChanges();
            
        }
        public void setUpdateFieldData(int id,string nombre,string ciudad,string estado,string telefono,string direccion,string nombrecoto)
        {
            seditor.ID = id;
            seditor.Nombre = nombre;
            seditor.Ciudad = ciudad;
            seditor.Estado = estado;
            seditor.Telefono = telefono;
            seditor.Direccion = direccion;
            seditor.NombreCorto = nombrecoto;
        }
        public void ToDGV()
        {
            var query = from suplidores in data.Suplidores
                        select suplidores;
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
