using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    internal class User
    {
        public string username { get; set; }
        public string password { get; set; }   
        public string facNum { get; set; }
        public int userRole { get; set; }

        public User(string username, string password, string facNum, int userRole) {
            this.username = username;
            this.password = password;
            this.facNum = facNum; ;
            this.userRole = userRole;
            
        }

    }
}
