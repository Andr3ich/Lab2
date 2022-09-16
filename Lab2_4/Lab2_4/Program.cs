using System;

namespace Lab2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Andrew123", "Andrii", "Tymoshyk", 18);
            user.Print();
        }
    }

    class User
    {
        private string login;
        private string name;
        private string surname;
        private int age;
        private string data = "14.09.2022";

        public User(string login, string name, string surname, int age)
        {
            this.login = login;
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.data = data;
        }
        public void Print()
        {
            Console.WriteLine($"Логiн: {login} \nIм'я: {name} \nПрiзвище: {surname} \nВiк: {age} \nДата заповнення анкети: {data}");
        }
    }
}