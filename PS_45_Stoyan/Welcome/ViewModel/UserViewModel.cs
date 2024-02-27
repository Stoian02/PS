using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Welcome.Others;
using Welcome.Model;


namespace Welcome.ViewModel
{
    class UserViewModel
    {
        public User _user;

        public UserViewModel(User user)
        {
            _user = user;
        }
        public string Name 
        {
            get { return _user.Name; }
            set { _user.Name = value; }
        }
        public string Password
        {
            get { return _user.Password; }
            set { _user.Password = value; }
        }

        public UserRolesEnum Role
        {
            get { return _user.Role; }
            set { _user.Role = value; }
        }
    }
}
