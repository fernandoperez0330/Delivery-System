using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace deliverywindows.controllers
{
    using models;

  public  class ClientesManage: ManagersInterface
    {
        DATABASEDataContext data;
        CustomersEditor ceditor;
        CustomersManager manager;
       

        public ClientesManage()
        {
            data = DataConexion.getInstance();
        }

        public void fillDGV()
        {
            var query = from s in data.Clientes
                        select s ;
            manager.DGV.DataSource = query;
        }

        public void setEditor(ref CustomersEditor editor)
        { 
            ceditor = editor;
        }
        public void setManager(CustomersManager mgr)
        {
            manager = mgr;
            fillDGV();
        }
        public void setEditorValues() 
        {
            MessageBox.Show(ceditor.Nombre+
                ceditor.Ciudad+ceditor.Direccion1+ceditor.Direccion2+ceditor.Telefono);
            Cliente c = new Cliente 
            {
                NOMBRE = ceditor.Nombre,
                CIUDAD = ceditor.Ciudad,
                DIRECCION1 = ceditor.Direccion1,
                DIRECCION2 = ceditor.Direccion2,
                TELEFONO = ceditor.Telefono
            };
            data.Clientes.InsertOnSubmit(c);
            data.SubmitChanges();

            fillDGV();
        }

        public void Borrar()
        {
            var query = from cliente in data.Clientes
                        where cliente.CODIGO == Convert.ToInt32(manager.DGV.SelectedCells[0].Value.ToString())
                        select cliente;

            Cliente c = query.First<Cliente>();
            data.Clientes.DeleteOnSubmit(c);
            data.SubmitChanges();
            fillDGV();
            
        }
        public void Guardar() 
        {
            MessageBox.Show(ceditor.Nombre + ceditor.Ciudad + ceditor.Direccion1 + ceditor.Direccion2 + ceditor.Telefono);

            if (ceditor.Id < 0)
            {
                Cliente c = new Cliente 
                    {
                        NOMBRE = ceditor.Nombre,
                        CIUDAD = ceditor.Ciudad,
                        DIRECCION1 = ceditor.Direccion1,
                        DIRECCION2 = ceditor.Direccion2,
                        TELEFONO = ceditor.Telefono
                    };
                data.Clientes.InsertOnSubmit(c);
            }
            else
            {
                var query = from cliente in data.Clientes
                            where cliente.CODIGO == ceditor.Id
                            select cliente;

                Cliente c = query.First<Cliente>();
                c.NOMBRE = ceditor.Nombre;
                c.DIRECCION1 = ceditor.Direccion1;
                c.DIRECCION2 = ceditor.Direccion2;
                c.CIUDAD = ceditor.Ciudad;
                c.TELEFONO = ceditor.Telefono;
                
            }
            
                    
                    data.SubmitChanges();

                    fillDGV();
        }

    }
}
