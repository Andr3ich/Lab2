using System;

namespace Lab2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee person1 = new Employee("Andrii", "Tymoshyk", "Manager", 1);
            person1.Wage();
        }
    }

    class Employee
    {
        private string name { get; set; }
        private string surname { get; set; }
        private string spot { get; set; }
        private int experience { get; set; }
        private double wage { get; set; }


        public Employee(string name, string surname, string spot, int experience)
        {
            this.name = name;
            this.surname = surname;
            this.spot = spot;
            this.experience = experience;
        }

        public void Wage()
        {
            double wage0 = 10000;
            double tax = 0.9;

            if ("Trainee" == spot)
            {
                wage = wage0 * 1 * experience * tax;
                Console.WriteLine($"iм'я: {name} \nПрiзвище: {surname} \nПосада: {spot} \nЗарплатня: {wage} \nПодатковий збiр 10%");
            }
            else if ("Employee" == spot)
            {
                wage = wage0 * 2 * experience * tax;
                Console.WriteLine($"iм'я: {name} \nПрiзвище: {surname} \nПосада: {spot} \nЗарплатня: {wage} \nПодатковий збiр 10%");
            }
            else if ("Manager" == spot)
            {
                wage = wage0 * 3 * experience * tax;
                Console.WriteLine($"iм'я: {name} \nПрiзвище: {surname} \nПосада: {spot} \nЗарплатня: {wage} \nПодатковий збiр 10%");
            }
            else
            {
                Console.WriteLine("Такої посади немає у списку");
            }
        }
    }
}