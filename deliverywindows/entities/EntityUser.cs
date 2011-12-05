using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace deliverywindows.entities
{
    class EntityUser: Entity
    {

        private int codigo;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }


        private String usuario;

        public String Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        private String clave;

        public String Clave
        {
            get { return clave; }
            set { clave = value; }
        }
        private String tipousuario;

        public String Tipousuario
        {
            get { return tipousuario; }
            set { tipousuario = value; }
        }
        private int sincroniza;

        public int Sincroniza
        {
            get { return sincroniza; }
            set { sincroniza = value; }
        }

        private int? codigoEmpleado;

        public int? CodigoEmpleado
        {
            get { return codigoEmpleado; }
            set { codigoEmpleado = value; }
        }


    }
}
