using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using deliverywindows.entities;

namespace deliverywindows.models
{
    class ModelTravel: Model
    {
        public EntityTravel travel;

        public ModelTravel() {
            travel = new EntityTravel();
        }

        public override int add()
        {
            throw new NotImplementedException();
        }

        public override bool update()
        {
            throw new NotImplementedException();
        }

        public override Entity find(int prkey)
        {
            
            var querySupplier = from viajecamion in Data.Viajes_Camions
                                where viajecamion.CODIGOVIAJE == prkey
                                select viajecamion;

            foreach (Viajes_Camion viaje in querySupplier)
            {
                this.travel.Codigo = viaje.Viaje.CODIGO;
                this.travel.Fechaviaje = viaje.Viaje.FECHAVIAJE;
                this.travel.Codigoempleado = viaje.CODIGOEMPLEADO;
                this.travel.Empleado = viaje.Empleado.NOMBRE;
                this.travel.Codigocamion = viaje.CODIGOCAMION;
                this.travel.Camion = viaje.Camione.DESCRIPCION;
            }

            return travel;
        }

        public IQueryable findAll()
        {
            var querySupplier = from viajecamion in Data.Viajes_Camions
                                select new { viajecamion.Viaje.CODIGO, viajecamion.Viaje.FECHAVIAJE, CODIGOEMPLEADO = viajecamion.CODIGOEMPLEADO,NOMBREEMPLEADO = viajecamion.Empleado.NOMBRE,CODIGOCAMION = viajecamion.CODIGOCAMION,NOMBRECAMION = viajecamion.Camione.DESCRIPCION};
            return querySupplier;
        }

        public override bool delete()
        {
            throw new NotImplementedException();
        }
    }
}
