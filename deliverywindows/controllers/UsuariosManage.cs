using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace deliverywindows.controllers
{
    using models;

    public class UsuariosManage:ManagersInterface
    {
        UsersManager umanager;

        public UsuariosManage(UsersManager mgr)
        {
            umanager = mgr;
        }
        public void Guardar() { }
        public void Borrar() { }
    }
}
