using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using deliverywindows.entities;
using deliverywindows.utils;


namespace deliverywindows.models
{
    class ModelUsers: Model
    {
        /// <summary>
        /// entidad del modelo en cuestion
        /// </summary>
        private Users user;

        internal Users User
        {
            get { return user; }
            set { user = value; }
        }


        public ModelUsers() {
            User = new Users();
        }

        
        public override Boolean add(Entity entity) {
            Users user = (Users) entity;
            //open the db connection
            this.dbConnection.open();
            SqlCommand cmd = this.dbConnection.Connection.CreateCommand();
            //seleccionar el tipo de conexion
            cmd.CommandType = System.Data.CommandType.Text;
            //consulta sql
            string sql = "INSERT INTO USUARIOS(USUARIO,CLAVE,TIPOUSUARIO,SINCRONIZA) VALUES(@Usuario,@Clave,@Tipousuario)";
            cmd.Parameters.AddWithValue("@Usuario",user.Username);
            cmd.Parameters.AddWithValue("@Clave", Utils.encryptPassword(user.Password));
            cmd.Parameters.AddWithValue("@Tipousuario", user.Type);
            cmd.Parameters.AddWithValue("@Sincroniza", user.Sync);
            cmd.CommandText = sql;
            int rowsAffected;
            try
            {
                rowsAffected = cmd.ExecuteNonQuery();
            }catch(SqlException exc){
                Utils.logException(exc);
                return false;
            }
            //close the db connection
            this.dbConnection.close();
            if (rowsAffected != 0) 
                return true;
            else
                return false;
        }

        public override Boolean update(Entity entity)
        {
            return false;

        }

        public override Entity find(int prkey)
        {
            return new Users();

        }

        public override Boolean remove(Entity entity)
        {
            return false;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public Users findByUser(String username) {
            this.dbConnection.Connection.Open();    
            SqlCommand cmd = this.dbConnection.Connection.CreateCommand();
            //seleccionar el tipo de conexion
            cmd.CommandType = System.Data.CommandType.Text;
            //consulta sql
            string sql = "SELECT CODIGO,USUARIO,CLAVE,TIPOUSUARIO,SINCRONIZA FROM Usuarios WHERE USUARIO=@Usuario";
            cmd.Parameters.AddWithValue("@Usuario",username);
            cmd.CommandText = sql;

            //sqldata reader for read the registers
            SqlDataReader dr = cmd.ExecuteReader();

            Users foundUser = new Users();
            while (dr.Read())
            {
                foundUser.Code = dr.GetInt32(0);
                foundUser.Username = dr.GetString(1);
                foundUser.Password = dr.GetString(2);
                foundUser.Type = dr.GetString(3);
                //foundUser.Sync = dr.GetBoolean(4);
            }
            this.dbConnection.Connection.Close();
            return foundUser;
        }

        /// <summary>
        /// login by username and password
        /// </summary>
        /// <returns></returns>
        public Boolean login() {
            Users foundUser = this.findByUser(this.User.Username);
            String encryptedPassword = Convert.ToString(((Users)foundUser).Password);
            if (foundUser != null && encryptedPassword == Utils.encryptPassword(this.User.Password))
                return true;
            else
                return false;
        }

    }
}
