using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace deliverywindows.entities
{
    class EntityOrder : Entity
    {
        /// <summary>
        /// 
        /// </summary>
        private int codigo;

        /// <summary>
        /// 
        /// </summary>
        private int codigosuplidor;

        /// <summary>
        /// 
        /// </summary>
        private int codigocliente;

        /// <summary>
        /// 
        /// </summary>
        private int codigoviaje;

        /// <summary>
        /// 
        /// </summary>
        private DateTime fechaorden;

        /// <summary>
        /// 
        /// </summary>
        private int estatus;

        /// <summary>
        /// 
        /// </summary>
        private String mensaje;

        /// <summary>
        /// 
        /// </summary>
        private String po_box;

        /// <summary>
        /// 
        /// </summary>
        private int cantidad_cajas;

        /// <summary>
        /// 
        /// </summary>
        private Decimal peso_orden;

        /// <summary>
        /// 
        /// </summary>
        private String nombrerecibidor;

        /// <summary>
        /// 
        /// </summary>
        private DateTime fechaentrega;

        /// <summary>
        /// 
        /// </summary>
        private Object firmaentrega;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public int Codigosuplidor
        {
            get { return codigosuplidor; }
            set { codigosuplidor = value; }
        }

        public int Codigocliente
        {
            get { return codigocliente; }
            set { codigocliente = value; }
        }

        public int Codigoviaje
        {
            get { return codigoviaje; }
            set { codigoviaje = value; }
        }

        public DateTime Fechaorden
        {
            get { return fechaorden; }
            set { fechaorden = value; }
        }    

        public int Estatus
        {
            get { return estatus; }
            set { estatus = value; }
        }

        public String Mensaje
        {
            get { return mensaje; }
            set { mensaje = value; }
        }

        public String Po_box
        {
            get { return po_box; }
            set { po_box = value; }
        }

        public int Cantidad_cajas
        {
            get { return cantidad_cajas; }
            set { cantidad_cajas = value; }
        }

        public Decimal Peso_orden
        {
            get { return peso_orden; }
            set { peso_orden = value; }
        }

        public String Nombrerecibidor
        {
            get { return nombrerecibidor; }
            set { nombrerecibidor = value; }
        }

        public DateTime Fechaentrega
        {
            get { return fechaentrega; }
            set { fechaentrega = value; }
        }

        public Object Firmaentrega
        {
            get { return firmaentrega; }
            set { firmaentrega = value; }
        }
    }
}
