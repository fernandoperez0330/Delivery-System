using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using deliverywindows.entities;
using deliverywindows.utils;

namespace deliverywindows.models
{
    class ModelCarters: Model
    {
        public EntityCarters carter;

        public ModelCarters() {
            Entity = new EntityCarters();
            carter = (EntityCarters)Entity;

        }
        public override int add()
        {
            try
            {
                Empleado dataCarrero = new Empleado
                {
                    NOMBRE = carter.Nombre,
                    DIRECCION = carter.Direccion,
                    TELEFONO = carter.Telefono,
                    CIUDAD = carter.Ciudad,
                    TIPO = 2
                };
                Data.Empleados.InsertOnSubmit(dataCarrero);
                Data.SubmitChanges();

                
                ModelUsers modelUser = new ModelUsers();
                //datos para agregar usuario
                modelUser.user.CodigoEmpleado = dataCarrero.CODIGO;
                modelUser.user.Usuario = carter.Usuario.Usuario;
                modelUser.user.Clave = carter.Usuario.Clave;
                modelUser.user.Tipousuario = carter.Usuario.Tipousuario;
                modelUser.user.Sincroniza = carter.Usuario.Sincroniza;
                
                modelUser.add();


                return 1;
            }
            catch (Exception exc)
            {
                Utils.logExceptionError(exc);
                return 0;
            }
        }

        public IQueryable findAlltoDataSource()
        {
            var querySupplier = from carrero in Data.Usuarios
                                select new { carrero.Empleado.CODIGO, carrero.Empleado.NOMBRE, carrero.Empleado.TELEFONO, carrero.Empleado.DIRECCION, carrero.Empleado.CIUDAD,carrero.USUARIO1,CLAVE = "*********" };
            return querySupplier;
        }

        public override bool update()
        {
            try
            {
                var query = from empleado in Data.Empleados
                            where empleado.CODIGO == carter.Codigo
                            select empleado;
                Empleado emp = query.First<Empleado>();
                emp.NOMBRE = carter.Nombre;
                emp.DIRECCION = carter.Direccion;
                emp.TELEFONO = carter.Telefono;
                emp.CIUDAD = carter.Ciudad;
                emp.TIPO = 2;
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
            var query = from empleado in Data.Usuarios
                        where empleado.Empleado.CODIGO == prkey
                        select empleado;
            foreach (Usuario emp in query)
            {
                carter.Codigo = emp.Empleado.CODIGO;
                carter.Nombre = emp.Empleado.NOMBRE;
                carter.Direccion = emp.Empleado.DIRECCION;
                carter.Telefono = emp.Empleado.TELEFONO;
                carter.Ciudad = emp.Empleado.CIUDAD;
                carter.Tipo = emp.Empleado.TIPO;
                carter.Usuario.Codigo = emp.CODIGO;
                carter.Usuario.Usuario = emp.USUARIO1;
                carter.Usuario.Clave = emp.CLAVE;
                carter.Usuario.Tipousuario = emp.TIPOUSUARIO;
                carter.Usuario.Sincroniza = emp.SINCRONIZA;
            }

            return carter;
        }

        public override bool delete()
        {
            try
            {
                var query = from empleado in Data.Empleados
                            where empleado.CODIGO == empleado.CODIGO
                            select empleado;

                Empleado emp = query.First<Empleado>();
                Data.Empleados.DeleteOnSubmit(emp);
                Data.SubmitChanges();
                return true;
            }
            catch (Exception exc)
            {
                Utils.logExceptionError(exc);
                return false;
            }
        }



    }
}
