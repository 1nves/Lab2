using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Employee
{
    public enum Jobs
    {
        teacher,
        doctor,
        policeofficer
    }

    public enum WorkRole
    {
        junior,
        middle,
        senior
    }
    private string name, surname;
    private WorkRole workrole = WorkRole.middle;
    private Jobs job = Jobs.doctor;
    private int taxPercentage = 8;

    public string Name { get { return name; } set { name = value; } }
    public string Surname { get { return surname; } set { surname = value; } }
    public WorkRole workRole { get { return workrole; } set { workrole = value; } }
    public Jobs Job { get { return job; } set { job = value; } }
    public int TaxPercentage { get { return taxPercentage; } set { taxPercentage = value; } }


    public Employee(string name, string surname)
    {
        this.name = name;
        this.surname = surname;
    }

    public Employee()
    {
    }

    public (int salary, int taxCollection) CountSalaryAndTax()
    {
        int salary = 0;
        int taxCollection = 0;

        switch (job)
        {
            case Jobs.teacher:
                salary = 10000;
                break;
            case Jobs.doctor:
                salary = 20000;
                break;
            case Jobs.policeofficer:
                salary = 30000;
                break;
        }

        switch (workrole)
        {
            case WorkRole.junior:
                salary += 1000;
                break;
            case WorkRole.middle:
                salary += 1500;
                break;
            case WorkRole.senior:
                salary += 2000;
                break;
        }

        taxCollection = salary * taxPercentage / 100;

        salary = salary - taxCollection;

        return (salary, taxCollection);
    }

}