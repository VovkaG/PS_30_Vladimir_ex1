using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    internal static class UserData
    {
        private static User _testUser;
        public static User TestUser
        {
            get {
                ResetTestUserData();
                return _testUser;
            }
            set { }
        }

        private static void ResetTestUserData() {
            if (_testUser == null){
                _testUser = new User("Vladimir", "123456", "0051101901", 1);
            }
            else return;
        }
    }
}
