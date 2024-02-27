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
        private string _fakNum { get; set; }
        private string _name { set; get; }
        private string _password { set; get; }
        private string _email { get; set; }
        private UserRolesEnum _role { set; get; }

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
