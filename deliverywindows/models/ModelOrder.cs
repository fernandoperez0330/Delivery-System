using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using deliverywindows.entities;
using deliverywindows.utils;


namespace deliverywindows.models
{
    class ModelOrder: Model
    {
        public EntityOrder order;

        public ModelOrder() {
            order = new EntityOrder();
        }

        public override int add()
        {
            try
            {
                Ordene dataorden = new Ordene
                {
                    CODIGO = order.Codigo,
                    CODIGOSUPLIDOR = order.Codigosuplidor,
                    CODIGOCLIENTE = order.Codigocliente,
                    CODIGOVIAJE = order.Codigoviaje,
                    FECHAORDEN = order.Fechaorden,
                    FECHAENTREGA = order.Fechaentrega,
                    MENSAJE = order.Mensaje,
                    PO_NOMBRE = order.Po_box,
                    CANTIDADCAJAS = order.Cantidad_cajas,
                    PESOORDEN = order.Peso_orden,
                    NOMBRERECIBIDOR = order.Nombrerecibidor,
                };
                Data.Ordenes.InsertOnSubmit(dataorden);
                Data.SubmitChanges();
                return 1;
            }
            catch (Exception exc) { 
                Utils.logExceptionError(exc);
                return 0;
            }
        }

        public override bool update()
        {
            try
            {
                var query = from orden in Data.Ordenes
                            where orden.CODIGO == orden.CODIGO
                            select orden;

                Ordene o = query.First<Ordene>();
                o.CODIGO = order.Codigo;
                o.CODIGOSUPLIDOR = order.Codigosuplidor;
                o.CODIGOCLIENTE = order.Codigocliente;
                o.CODIGOVIAJE = order.Codigoviaje;
                o.FECHAORDEN = order.Fechaorden;
                o.FECHAENTREGA = order.Fechaentrega;
                o.MENSAJE = order.Mensaje;
                o.PO_NOMBRE = order.Po_box;
                o.CANTIDADCAJAS = order.Cantidad_cajas;
                o.PESOORDEN = order.Peso_orden;
                o.NOMBRERECIBIDOR = order.Nombrerecibidor;

                Data.SubmitChanges();
                return true;
            }
            catch (Exception exc) {
                return false;
            }
        }

        public override entities.Entity find(int prkey)
        {
            var queryOrder = from orden in Data.Ordenes
                        where orden.CODIGO == prkey
                        select orden;
            foreach (Ordene e in queryOrder)
            {
                
                order.Codigo = e.CODIGO;
                order.Codigocliente = e.CODIGOCLIENTE;
                order.Codigoviaje = e.CODIGOVIAJE;
                order.Codigosuplidor = e.CODIGOSUPLIDOR;
                order.Po_box = e.PO_NOMBRE;
                order.Peso_orden = e.PESOORDEN;
                order.Cantidad_cajas = e.CANTIDADCAJAS;
                order.Fechaentrega = e.FECHAENTREGA;
                order.Fechaorden = e.FECHAORDEN;
                order.Mensaje = e.MENSAJE;
                order.Nombrerecibidor = e.NOMBRERECIBIDOR;
            }

            return order;
        }

        public override bool delete()
        {
            throw new NotImplementedException();
        }

        public IQueryable findAll()
        {
            var queryOrders = from orden in Data.Ordenes
                                select orden;
            return queryOrders;
        }

        public IQueryable findtoDataSource() {
            var queryOrders = from orden in Data.Ordenes
                              select new { orden.CODIGO,orden.CODIGOVIAJE,orden.CODIGOSUPLIDOR,NOMBRESUPLIDOR = orden.Suplidore.NOMBRE,orden.PO_NOMBRE,orden.CANTIDADCAJAS,PESOORDEN = orden.PESOORDEN + "Kg",orden.FECHAORDEN,orden.MENSAJE};
            return queryOrders;
        }

    }
}
