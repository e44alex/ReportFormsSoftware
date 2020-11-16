using System;
using System.Collections.Generic;
using System.Text;

namespace Diplom.Shared.Model
{
    class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronym { get; set; }
        public string Address { get; set; }
        public Organisation Organisation { get; set; }
    }
}
