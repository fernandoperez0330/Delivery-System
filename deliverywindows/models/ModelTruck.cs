using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using deliverywindows.entities;
using deliverywindows.utils;

namespace deliverywindows.models
{
    class ModelTrucks: Model
    {
        public EntityTruck truck;

        /// <summary>
        /// constructor crear la instancia de la entidad camion en cuestion
        /// </summary>
        public ModelTrucks() {
            truck = new EntityTruck();
        }

        public override int add()
        {
            try
            {
                Camione dataCamion = new Camione
                {
                    CODIGO = truck.Codigo,
                    NOMBRE = truck.Nombre,
                    DESCRIPCION = truck.Descripcion
                };
                Data.Camiones.InsertOnSubmit(dataCamion);
                Data.SubmitChanges();
                return 1;
            }
            catch (Exception exc)
            {
                Utils.logExceptionError(exc);
                return 0;
            }
        }

        public override bool update()
        {
            try
            {

                var query = from camion in Data.Camiones
                            where camion.CODIGO == truck.Codigo
                            select camion;

                Camione cam = query.First<Camione>();
                cam.CODIGO = truck.Codigo;
                cam.NOMBRE = truck.Nombre;
                cam.DESCRIPCION = truck.Descripcion;
                Data.SubmitChanges();
                return true;
            }
            catch (Exception exc)
            {
                Utils.logExceptionError(exc);
                return false;
            }
        }


        public override bool delete()
        {
            try
            {
                var query = from camion in Data.Camiones
                            where camion.CODIGO == camion.CODIGO
                            select camion;

                Camione cam = query.First<Camione>();
                Data.Camiones.DeleteOnSubmit(cam);
                Data.SubmitChanges();

                return true;
            }
            catch (Exception exc)
            {
                Utils.logExceptionError(exc);
                return false;
            }
        }

        public override Entity find(int prkey)
        {
            var query = from camion in Data.Camiones
                        where camion.CODIGO == prkey
                        select camion;
            foreach (Camione cam in query)
            {
                truck.Codigo = cam.CODIGO;
                truck.Nombre = cam.NOMBRE;
                truck.Descripcion = cam.DESCRIPCION;
            }
            return truck;
        }
    }
}
