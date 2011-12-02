using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace deliverywindows.entities
{
    class Users : Entity
    {
        private int code;

        public int Code
        {
            get { return code; }
            set { code = value; }
        }
        private String username;

        public String Username
        {
            get { return username; }
            set { username = value; }
        }
        private String password;

        public String Password
        {
            get { return password; }
            set { password = value; }
        }
        private String type;

        public String Type
        {
            get { return type; }
            set { type = value; }
        }
        private Boolean sync;

        public Boolean Sync
        {
            get { return sync; }
            set { sync = value; }
        }
    }
}
