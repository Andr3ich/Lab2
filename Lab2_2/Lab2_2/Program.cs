using System;

namespace Lab2_2
{
    class Program
    {

        static void Main(string[] args)
        {
            Converter converter = new Converter(36.94, 36.96, 0.61);
            Converter1 converter1 = new Converter1(0.027, 0.027, 1.64);


            Console.WriteLine("Оберiть операцiю \n1.З гривнi у iншу валюту \n2.З iншої валюти у гривню");
            int vol2 = Convert.ToInt32(Console.ReadLine());
            switch (vol2)
            {
                case 1:
                    converter.Print();
                    break;
                case 2:
                    converter1.Print1();
                    break;
            }
            Console.ReadKey();
        }
    }

    class Converter1
    {
        private double uah { get; set; }
        private double uah1 { get; set; }
        private double uah2 { get; set; }
        public Converter1(double uah, double uah1, double uah2)
        {
            this.uah = uah;
            this.uah1 = uah1;
            this.uah2 = uah2;
        }
        public void Print1()
        {
            Console.WriteLine("Виберiть валюту: \n1.Долари у гривнi \n2.Євро у гривнi \n3.Рублi у гривнi");
            int vol1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введiть суму: ");
            double money = Convert.ToInt32(Console.ReadLine());

            switch (vol1)
            {
                case 1:
                    double resu = money / uah;
                    Console.WriteLine("Ваша сума у гривнях: " + resu);
                    break;

                case 2:
                    double rese1 = money / uah1;
                    Console.WriteLine("Ваша сума у гривнях: " + rese1);
                    break;
                case 3:
                    double resr1 = money / uah2;
                    Console.WriteLine("Ваша сума у гривнях: " + resr1);
                    break;
            }
        }
    }

    class Converter
    {
        private double usd { get; set; }
        private double eur { get; set; }
        private double rub { get; set; }


        public Converter(double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;

        }
        public void Print()
        {
            Console.WriteLine("Оберiть валюту: \n1.Долар \n2.Євро \n3.Рубль");
            int vol = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введiть вашу суму в гривнях: ");
            double uan = Convert.ToInt32(Console.ReadLine());

            switch (vol)
            {
                case 1:
                    double resd = uan / usd;
                    Console.WriteLine("Ваша сума в доларах: " + resd);
                    break;

                case 2:
                    double rese = uan / eur;
                    Console.WriteLine("Ваша сумма в євро: " + rese);
                    break;
                case 3:
                    double resr = uan / rub;
                    Console.WriteLine("Ваша сума в рублях: " + resr);
                    break;
            }
        }
    }
}