using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace deliverywindows.controllers
{
    using models;

    class UserValidation
    {
        DATABASEDataContext data;
        string UserName;
        string UserType;
        bool inTheSystem = false;

        public UserValidation(string username,string password) 
        {
            data = DataConexion.getInstance();
            if(ValidateUser(username,password))
            {
                MessageBox.Show("YEAP!");
            }
            else MessageBox.Show("Nop :s");
            
        }

         bool ValidateUser(string username,string password) 
         {
             var check = from usuarios in data.Usuarios
                         where usuarios.USUARIO1 == username
                          && usuarios.CLAVE == MD5.Create(password).ToString()
                         select usuarios;
             if (check.Count() > 0)
             {
                 inTheSystem = true;
                 UserName = check.First<Usuario>().USUARIO1;
                 UserType = check.First<Usuario>().TIPOUSUARIO;
                 return true;
             }
             else return false;
         }
    }
}
