using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using deliverywindows.entities;
using deliverywindows.utils;
using deliverywindows.config;

namespace deliverywindows.models
{
    class ModelUsers: Model
    {
        public EntityUser user;

        /// <summary>
        /// constructor del modelo de los usuarios
        /// </summary>
        public ModelUsers() {
            user = new EntityUser();
        }

        public override int add()
        {
            try
            {
                Usuario dataUsuario = new Usuario
                {
                    USUARIO1 = user.Usuario,
                    CLAVE = user.Clave,
                    TIPOUSUARIO = user.Tipousuario,
                    SINCRONIZA = user.Sincroniza,
                    CODIGOEMPLEADO = user.CodigoEmpleado
                };
                Data.Usuarios.InsertOnSubmit(dataUsuario);
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
                var query = from usuario in Data.Usuarios
                            where usuario.CODIGO == usuario.CODIGO
                            select usuario;

                Usuario us = query.First<Usuario>();
                us.CODIGO = this.user.Codigo;
                us.USUARIO1 = this.user.Usuario;
                us.CLAVE = this.user.Clave;
                us.TIPOUSUARIO = this.user.Tipousuario;
                us.SINCRONIZA = this.user.Sincroniza;
                us.CODIGOEMPLEADO = this.user.CodigoEmpleado;
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
            var query = from usuario in Data.Usuarios
                        where usuario.CODIGO == prkey
                        select usuario;
            foreach (Usuario us in query)
            {
                user.Codigo = us.CODIGO;
                user.Usuario = us.USUARIO1;
                user.Clave = us.CLAVE;
                user.Tipousuario = us.TIPOUSUARIO;
                user.Sincroniza = us.SINCRONIZA;
            }

            return user;
        }

        public override bool delete()
        {
            throw new NotImplementedException();
        }

        public Boolean login(String usuario,String clave) {
            try {
                var query = from us in Data.Usuarios
                            where us.USUARIO1.Equals(usuario) && us.CLAVE.Equals(clave)
                            select us;
                foreach (Usuario us in query)
                {
                    Config.loggedUser.Codigo = us.CODIGO;
                    Config.loggedUser.Usuario = us.USUARIO1;
                    Config.loggedUser.Clave = "";
                    Config.loggedUser.Tipousuario = us.TIPOUSUARIO;
                    Config.loggedUser.Sincroniza = us.SINCRONIZA;
                    return true;
                }
            }catch(Exception exc){
                Utils.logExceptionError(exc);
            }
            return false;
        }


    }
}
