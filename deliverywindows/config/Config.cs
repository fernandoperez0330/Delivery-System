using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using deliverywindows.entities;

namespace deliverywindows.config
{
    class Config
    {
        /// <summary>
        /// nombre de la aplicacion
        /// </summary>
        public static String nameProgram = "DeliverySystem";
        /// <summary>
        /// entidad del usuario logueado
        /// </summary>
        public static EntityUser loggedUser = new EntityUser();

    }
}
