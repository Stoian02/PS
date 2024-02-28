using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Welcome.Others;

namespace Welcome.Model
{
    class User
    {
        public string _fakNum { get; set; }
        public string _name { set; get; }
        public string _password { set; get; }
        public string _email { get; set; }
        public UserRolesEnum _role { set; get; }

        public User(string fakNum, string name, string pass, string email,  UserRolesEnum role)
        {
            _fakNum = fakNum;
            _name = name;
            _password = pass;
            _email = email;
            _role = role;
        }
    }
}
