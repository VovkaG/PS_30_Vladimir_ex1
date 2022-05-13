using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            LoginValidation loginVal = new LoginValidation();
            if (loginVal.ValidateUserInput()) {
                Console.WriteLine(UserData.TestUser.username);
                Console.WriteLine(UserData.TestUser.password);
                Console.WriteLine(UserData.TestUser.facNum);
                Console.WriteLine(UserData.TestUser.userRole);

            }
            
        }
    }
}
