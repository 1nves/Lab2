using System;

namespace user
{
    class User
    {
        private string login, name, surname;
        private int age;
        private readonly string dateOfFilling = "22.09.2022";

        public string Login { get { return login; } set { login = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Surname { get { return surname; } set { surname = value; } }

        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0 || value < 120)
                    age = value;
                else
                    Console.WriteLine("You entered the wrong age");
            }
        }
        public string DateOfFilling { get { return dateOfFilling; } }

        public void Print()
        {
            Console.WriteLine($"\nLogin = {login}, Name = {name}, Surname = {surname}, Age = {age}, Date = {dateOfFilling} ");
        }
    }
}
