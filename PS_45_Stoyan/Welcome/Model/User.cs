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
        public string Name { set; get; }
        public string Password { set; get; }
        public UserRolesEnum Role { set; get; }

        public User(string name, string pass, UserRolesEnum role)
        {
            Name = name;
            Password = pass;
            Role = role;
        }
    }
}
