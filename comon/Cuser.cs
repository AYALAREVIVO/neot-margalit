using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comon
{
    public class Cuser
    {
        public Cuser(string userName, string password, string lastName, string firstName, int permission)
        {
            this.userName = userName;
            this.password = password;
            this.lastName = lastName;
            this.firstName = firstName;
            this.permission = permission;
        }
        public string userName { get; set; }
        public string password { get; set; }
        public int permission { get; set; }
        public string firstName { get; set; }
        public string lastName
        {
            get; set;
        }

        
}
}
