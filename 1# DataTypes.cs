using System;

namespace Exercises1and5_DataTypes
{
    class Program
    {
            static void Main(string[] args)
            {
                Console.WriteLine("Add first name: ");
                string firstname = Console.ReadLine();
                Console.WriteLine("Add last name: ");
                string lastname = Console.ReadLine();
                Console.WriteLine("Age: ");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine("Gender: ");
                char gender = char.Parse(Console.ReadLine());
                Console.WriteLine("PESEL: ");
                long pesel = long.Parse(Console.ReadLine());
                Console.WriteLine("Id number: ");
                long id = long.Parse(Console.ReadLine());


                Console.WriteLine($"Pracownik {firstname} {lastname} ma {age} lat jest płci {gender} posiada nr pesel: {pesel} a jego id: {id}");
                Console.ReadKey();

            }
    }
}

####################################################

namespace Exercises2_DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1 letter: ");
            char fletter = char.Parse(Console.ReadLine());
            Console.WriteLine("2 letter: ");
            char sletter = char.Parse(Console.ReadLine());
            Console.WriteLine("3 letter: ");
            char tletter = char.Parse(Console.ReadLine());



            Console.WriteLine($" {tletter} {sletter} {fletter}");
            Console.ReadKey();

        }
    }
}

####################################################

namespace Exercises3_DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj długość prostokąta: ");
            int dlugosc = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj szerokość prostokąta: ");
            int szerokosc = int.Parse(Console.ReadLine());

            double przekatna = Math.Sqrt(Math.Pow(dlugosc, szerokosc));
          

            Console.WriteLine($"Długość przekątnej to: {przekatna}");
            Console.ReadKey();
        }
    }
}

####################################################

namespace Exercises4_DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string tekst;
            short liczba;
            double zprzecinkiem;

            Console.WriteLine("Podaj tekst: ");
            tekst = Console.ReadLine();
            Console.WriteLine("podaj liczbe: ");
            liczba = short.Parse(Console.ReadLine());
            Console.WriteLine("podaj liczbe z przecinkiem: ");
            zprzecinkiem = double.Parse(Console.ReadLine());


            Console.WriteLine($"tekst: {tekst} liczba: {liczba} liczba z przecinkiem {zprzecinkiem}");
            Console.ReadKey();
        }
    }
}



