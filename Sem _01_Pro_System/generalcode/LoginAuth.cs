using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInterface.FormClasses
{
    internal class LoginAuth
    {
        public string Id { get; set; }
        public string UserType { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public static LoginAuth loggedUser { get; set; }
    }
}
