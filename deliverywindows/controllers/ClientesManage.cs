using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace deliverywindows.controllers
{
    using models;

  public  class ClientesManage
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

        public void safeClient() 
        {
            MessageBox.Show(ceditor.Nombre +
                ceditor.Ciudad + ceditor.Direccion1 + ceditor.Direccion2 + ceditor.Telefono);
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

    }
}
