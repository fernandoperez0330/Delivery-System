using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace deliverywindows.entities
{
    class EntitySupplier: Entity
    {
        /// <summary>
        /// 
        /// </summary>
        private int codigo;

        /// <summary>
        /// 
        /// </summary>
        private String nombre;

        /// <summary>
        /// 
        /// </summary>
        private int ciudad;

        /// <summary>
        /// 
        /// </summary>
        private String estado;

        /// <summary>
        /// 
        /// </summary>
        private String telefono;

        /// <summary>
        /// 
        /// </summary>
        private String direccion;

        /// <summary>
        /// 
        /// </summary>
        private String nombrecorto;

        public String Nombrecorto
        {
            get { return nombrecorto; }
            set { nombrecorto = value; }
        }

        public String Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }


        public String Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }



        public String Estado
        {
            get { return estado; }
            set { estado = value; }
        }



        public int Ciudad
        {
            get { return ciudad; }
            set { ciudad = value; }
        }

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }



    }
}
