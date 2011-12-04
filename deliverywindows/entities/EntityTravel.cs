using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace deliverywindows.entities
{
    class EntityTravel:Entity
    {
        /// <summary>
        /// 
        /// </summary>
        private int codigo;

        /// <summary>
        /// 
        /// </summary>
        private DateTime fechaviaje;

        /// <summary>
        /// 
        /// </summary>
        private int estatus;

        /// <summary>
        /// 
        /// </summary>
        private int codigocamion;

        /// <summary>
        /// 
        /// </summary>
        private int codigoempleado;


        /// <summary>
        /// 
        /// </summary>
        private String empleado;

        public String Empleado
        {
            get { return empleado; }
            set { empleado = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        private String camion;

        public String Camion
        {
            get { return camion; }
            set { camion = value; }
        }


        public int Codigoempleado
        {
            get { return codigoempleado; }
            set { codigoempleado = value; }
        }

        public int Codigocamion
        {
            get { return codigocamion; }
            set { codigocamion = value; }
        }

        public int Estatus
        {
            get { return estatus; }
            set { estatus = value; }
        }

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public DateTime Fechaviaje
        {
            get { return fechaviaje; }
            set { fechaviaje = value; }
        }


    }
}
