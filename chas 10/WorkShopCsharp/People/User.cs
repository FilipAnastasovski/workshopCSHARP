using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShopCsharp
{
    public class User
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine("First Name: {0}, Last Name: {1}, Role: {2}", FirstName, LastName , Role );
        }

    }
}
