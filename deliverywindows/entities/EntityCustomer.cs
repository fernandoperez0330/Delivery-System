using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace deliverywindows.entities
{
    class EntityCustomer:Entity
    {
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
        private String direccion1;

        public String Direccion1
        {
            get { return direccion1; }
            set { direccion1 = value; }
        }
        private String direccion2;

        public String Direccion2
        {
            get { return direccion2; }
            set { direccion2 = value; }
        }
        private int idCiudad;

        public int IdCiudad
        {
            get { return idCiudad; }
            set { idCiudad = value; }
        }

        private String nombreCiudad;

        public String NombreCiudad
        {
            get { return nombreCiudad; }
            set { nombreCiudad = value; }
        }

        private String telefono;

        public String Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
    }
}
