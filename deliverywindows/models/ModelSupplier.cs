using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using deliverywindows.entities;
using System.Collections;
using deliverywindows.utils;

namespace deliverywindows.models
{
    class ModelSupplier: Model
    {
        public EntitySupplier supplier;

        public ModelSupplier() {
            Entity = new EntitySupplier();
            supplier = (EntitySupplier)Entity;

        }


        public override int add()
        {
            try {
                Suplidore datasuplidor = new Suplidore
                {
                    NOMBRE = supplier.Nombre,
                    CIUDAD = supplier.Ciudad,
                    ESTADO = supplier.Estado,
                    DIRECCION1 = supplier.Direccion,
                    NOMBRECORTO = supplier.Nombrecorto,
                    TELEFONO = supplier.Telefono
                };
                Data.Suplidores.InsertOnSubmit(datasuplidor);
                Data.SubmitChanges();
                return 1;
            }
            catch(Exception exc){
                Utils.logExceptionError(exc);
                return 0;
            }
        }

        public override bool update()
        {
            try
            {

                var query = from suplidor in Data.Suplidores
                            where suplidor.CODIGO == supplier.Codigo
                            select suplidor;

                Suplidore s = query.First<Suplidore>();
                s.NOMBRE = supplier.Nombre;
                s.CIUDAD = Convert.ToInt32(supplier.Ciudad);
                s.ESTADO = supplier.Estado;
                s.DIRECCION1 = supplier.Direccion;
                s.NOMBRECORTO = supplier.Nombrecorto;
                s.TELEFONO = supplier.Telefono;

                Data.SubmitChanges();
                return true;
            }
            catch (Exception exc) {
                Utils.logExceptionError(exc);
                return false;
            }

        }

        public override Entity find(int prkey)
        {
            var query = from suplidor in Data.Suplidores
                        where suplidor.CODIGO == prkey
                        select suplidor;
            foreach(Suplidore e in query){
                Console.WriteLine(e.CODIGO);
                supplier.Codigo = e.CODIGO;
                supplier.Nombre = e.NOMBRE;
                supplier.Direccion = e.DIRECCION1;
                supplier.Estado = e.ESTADO;
                supplier.Nombrecorto = e.NOMBRECORTO;
                supplier.Telefono = e.TELEFONO;
                supplier.Ciudad = e.CIUDAD;
            }

            return supplier;
        }



        public IQueryable findByName(String name) {
            var querySupplier = from suplidor in Data.Suplidores
                                where suplidor.NOMBRE.Contains(name)
                                select suplidor;
            return querySupplier;
        }

        public IQueryable findAll()
        {
            var querySupplier = from suplidor in Data.Suplidores
                                select new { suplidor.CODIGO, suplidor.NOMBRE, CIUDAD = suplidor.Ciudade.NOMBRE, suplidor.ESTADO, suplidor.TELEFONO, suplidor.DIRECCION1, suplidor.NOMBRECORTO }; ;
            return querySupplier;
        }


        public override bool delete()
        {
            try {
                var query = from suplidor in Data.Suplidores
                            where suplidor.CODIGO == Convert.ToInt32(suplidor.CODIGO)
                            select suplidor;

                Suplidore s = query.First<Suplidore>();
                Data.Suplidores.DeleteOnSubmit(s);
                Data.SubmitChanges();

                return true;
            }catch(Exception exc){
                return false;
            }
        }


    }
}
