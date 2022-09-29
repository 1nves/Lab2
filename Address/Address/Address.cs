using System;

namespace address
{
    class Address
    {
        private int index, apartment; //using 'int' beacuse it can inculde numbers
        private string country, city, street, house;

        public int Index
        {
            get { return index; }
            set { index = value; }
        }
        public string Country
        { get { return country; } set { country = value; } }

        public string City
        { get { return city; } set { city = value; } }

        public string Street
        { get { return street; } set { street = value; } }

        public string House
        { get { return house; } set { house = value; } }

        public int Apartment
        {
            get { return apartment; }
            set
            {
                if (value > 0)
                    apartment = value;
                else
                    Console.WriteLine("The apartment cannot be with a zero digit");
            }
        }

        public void Print()
        {
            Console.WriteLine($"\nIndex={index}, Country={country}, City={city}, Street={street}, House={house}, Apartment={apartment}");
            Console.ReadLine();
        }
    }
}