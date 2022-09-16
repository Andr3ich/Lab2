using System;

namespace Lab2_1
{
    class Address
    {
        public string Index { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Apartment { get; set; }

    }
    class Program
    {
        static void Main()
        {
            Address address = new Address
            {
                Index = "07402",
                Country = "Ukraine",
                City = "Brovary",
                Street = "Kyivska Street",
                House = "221",
                Apartment = "1"
            };

            Console.WriteLine($"Index: {address.Index} \nCountry: {address.Country} \nCity: {address.City} \nStreet: {address.Street} \nHouse: {address.House} \nApartment: {address.Apartment}");
            Console.ReadKey();
        }
    }
}
