using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User = user.User;

namespace oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();

            Console.Write("Enter the login=");
            user.Login = Console.ReadLine();

            Console.Write("Enter the name=");
            user.Name = Console.ReadLine();

            Console.Write("Enter the surname=");
            user.Surname = Console.ReadLine();

            Console.Write("Enter the age=");
            user.Age = int.Parse(Console.ReadLine());

            Console.WriteLine($"Date of filling the questionnaire={user.DateOfFilling}");

            user.Print();
            Console.ReadLine();
        }
    }
}
