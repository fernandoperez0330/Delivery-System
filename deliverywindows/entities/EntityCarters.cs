using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace deliverywindows.entities
{
    /// <summary>
    /// entidad para los carreros
    /// </summary>
    class EntityCarters: Entity
    {

        public EntityCarters() {
            Usuario = new EntityUser();
        }
        private int codigo;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private String direccion;

        public String Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        private String ciudad;

        public String Ciudad
        {
            get { return ciudad; }
            set { ciudad = value; }
        }



        private String telefono;

        public String Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        private int tipo;

        public int Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        private EntityUser usuario;

        internal EntityUser Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }



    }
}
