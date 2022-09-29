using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Address = address.Address;

namespace oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address();

            Console.Write("Enter the index=");
            address.Index = int.Parse(Console.ReadLine());

            Console.Write("Enter the country=");
            address.Country = Console.ReadLine();

            Console.Write("Enter the city=");
            address.City = Console.ReadLine();

            Console.Write("Enter the street=");
            address.Street = Console.ReadLine();

            Console.Write("Enter the house=");
            address.House = Console.ReadLine();

            Console.Write("Enter the apartment=");
            address.Apartment = int.Parse(Console.ReadLine());

            address.Print();
            Console.ReadLine();
        }
    }
}