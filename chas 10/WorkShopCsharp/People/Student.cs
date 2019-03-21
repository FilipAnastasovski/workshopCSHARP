using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShopCsharp
{
    public class Student : User
    {

        public Subject CurrentSubject { get; set; }
        public int Grade { get; set; }

        public Student()
        {

        }

        public Student(string firstName, string lastName, string password, Subject currentSub , int ocenka)
        {
            FirstName = firstName;
            LastName = lastName;
            Password = password;
            Role = Role.Student;
            CurrentSubject = currentSub;
            Grade = ocenka;
        }

    }
}
