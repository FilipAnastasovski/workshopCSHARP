using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShopCsharp
{
    class Program
    {

        static void Login(User[] users, string username, string lastname, string password)
        {
            User user = FindUser(users, username, lastname, password);
            if (user == null)
            {
                Console.WriteLine("User not found!");
                return;
            }
            Console.WriteLine("-------------------------");
            Console.WriteLine($"Welcome {user.FirstName} {user.LastName} who has the role of {user.Role}!");
            Console.WriteLine("-------------------------");
            
        }

        static User FindUser(User[] users, string username, string lastname , string password)
        {
            User someUser = null;
            foreach (User user in users)
            {
                    if (user.FirstName.ToLower() == username.ToLower() && user.LastName.ToLower() == username.ToLower() && user.Password == password)
                    {

                        someUser = user;
                        break;
                    }
            }
            return someUser;
        }


        static void Main(string[] args)
        {
            try
            {

                User[] users = new User[]
                {
                new User(){FirstName = "bob", LastName = "bobsky", Role = Role.Admin, Password="123qwe" },
                new User(){FirstName = "dod", LastName = "dodsky", Role = Role.Admin, Password = "qwe123"},
                new User(){FirstName = "qq", LastName = "qqqqqq", Role = Role.Admin, Password = "qqqqqq"},

                new User(){FirstName = "www", LastName = "www", Role = Role.Trainer, Password="123qwe" },
                new User(){FirstName = "eee", LastName = "eee", Role = Role.Trainer, Password = "qwe123"},
                new User(){FirstName = "rrr", LastName = "rrr", Role = Role.Trainer, Password = "qqqqqq"},

                };

                Student aaa = new Student("aaa", "aaa", "123qwe", Subject.Fizika, 3);
                Student bbb = new Student("bbb", "bbb", "123qwe", Subject.Geografija, 4);
                Student ccc = new Student("ccc", "ccc", "123qwe", Subject.Matematika, 5);

                Dictionary<string, List<Student>> studenti = new Dictionary<string, List<Student>>();
               
    
                studenti.Add("lista", new List<Student>()
                    {
                    new Student("aaa", "aaa", "123qwe", Subject.Fizika, 3),
                    new Student("bbb", "bbb", "123qwe", Subject.Geografija, 4),
                    new Student("ccc", "ccc", "123qwe", Subject.Matematika, 5)
                     } );
            


                //var currentStudent ;

            Console.WriteLine("What role do you have \n 1.Admin \n 2.Trainer \n 3.Student");
                int roleInput = int.Parse(Console.ReadLine());

                if (roleInput == 1)
                {
                    Console.WriteLine("you chose Admin");
                    Console.WriteLine("Login");

                    Console.WriteLine("Name:");
                    string nameInput = Console.ReadLine();

                    Console.WriteLine("Last Name:");
                    string lastNameInput = Console.ReadLine();

                    Console.WriteLine("Enter Password");
                    string passInput = Console.ReadLine();

                    Console.WriteLine($"you are {nameInput} {lastNameInput}");

                    Login(users, nameInput, lastNameInput, passInput);

                }
                else if (roleInput == 2)
                {
                    Console.WriteLine("you chose Trainer");
                    Console.WriteLine("Login");

                    Console.WriteLine("Name:");
                    string nameInput = Console.ReadLine();

                    Console.WriteLine("Last Name:");
                    string lastNameInput = Console.ReadLine();

                    Console.WriteLine("Enter Password");
                    string passInput = Console.ReadLine();

                    Console.WriteLine($"you are {nameInput} {lastNameInput}");

                    Login(users, nameInput, lastNameInput, passInput);
                }
                else if (roleInput == 3)
                {
                    Console.WriteLine("you chose Student");
                    Console.WriteLine("Login");

                    Console.WriteLine("Name:");
                    string nameInput = Console.ReadLine();

                    Console.WriteLine("Last Name:");
                    string lastNameInput = Console.ReadLine();

                    Console.WriteLine("Enter index:");
                    string passInput = Console.ReadLine();

                    Console.WriteLine($"you are {nameInput} {lastNameInput}");

                    var result = studenti
                       .SelectMany(d => d.Value)
                       .Where(d => studenti.All(di => di.Value.Any(v => v.FirstName == nameInput && v.LastName == lastNameInput && v.Password == passInput
                        .ToList())));

                    if (result)
                    {

                    }
                  

                }
                else
                {
                    throw new Exception("choice wasn't found");
                }


            }
            catch(FormatException)
            {
                Console.WriteLine("You did not enter a correct format, need to enter 1,2 or 3 ");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();

        }
    }
}
