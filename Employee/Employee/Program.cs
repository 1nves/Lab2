using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(name: "Illya", surname: "Vlasenko");
            Print(employee);
        }
        static void Print(Employee employee)
        {
            (int salary, int taxCollection) SalaryTax = employee.CountSalaryAndTax();
            Console.WriteLine($"Name={employee.Name},\nSurname={employee.Surname},\nJob={employee.Job},\nWork role={employee.workRole},\nSalary={SalaryTax.salary},\nTax collection={SalaryTax.taxCollection}");
            Console.ReadLine();
        }
    }
}
