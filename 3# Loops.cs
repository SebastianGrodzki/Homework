using System;

namespace Exercises2_Loops
{
    class Program
    {
        static void Main(string[] args)
        {

                int n = 0;
                do
                {
                    if (n % 2 != 0)
                    Console.WriteLine(n);
                    n++;
                }
                while (n <= 1000);
            
        }
    }
}

#####################################################

namespace Exercises3_Loops
{
    class Program
    {

        //  0	1	1	2	3	5	8	13	21	34	55	89	144	233	377	610	987	1597
        static void Main(string[] args)
        {
            int pierwsza = 0;
            int druga = 1;
            int zmienialna = 0;

                for (int i = 2; i <= 17; i++)
                {
                zmienialna = pierwsza + druga;                   
                pierwsza = druga;
                druga = zmienialna;
                Console.WriteLine(zmienialna);
            }
        }
    }
}

#####################################################

namespace Exercises4_Loops
{

    /*Napisz program, który po podaniu liczby całkowitej wyświetli piramidę liczb od 1 do podanej
    liczby w formie jak poniżej:*/

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbe calkowita: ");
            int lcal = int.Parse(Console.ReadLine());
            int k = 0;

            for (int i = 0; i <= lcal; i++)
            {
                Console.Write("\n");

                for (int j = 1; j < i; j++)
                {
                    k++;
                    Console.Write(" "+k);
                }
            }
        }
    }
}

#####################################################

namespace Exercises5_Loops
{
    class Program
    {
        static void Main(string[] args)
        {   
            for (int liczby = 1; liczby <= 20; liczby++)
            {
                Console.WriteLine(Math.Pow(liczby, 3));
            }
        }
    }
}

#####################################################

namespace Exercises6_Loops
{
    class Program
    {

        //Napisz program, który dla liczb od 0 do 20 obliczy sumę wg wzoru:
        //1 + ½ + 1/3 + ¼ itd.

        static void Main(string[] args)
        {

            double wynik = 0;

            for (int i = 1; i <= 20; i++)
            {
                wynik += 1.0 / i;

                Console.WriteLine(wynik);
            }
        }
    }
}

#####################################################

namespace Exercises7_Loops
{
    public class Program
    {

        public static void Main()
        {
            Console.WriteLine("Podaj długość boku:");
            int dlugosc, i, k;
            dlugosc = int.Parse(Console.ReadLine());

            int ilosc = dlugosc - 1;

            for (k = 1; k <= dlugosc; k++)
            {
                for (i = 1; i <= ilosc; i++)
                    Console.Write(" ");
                ilosc--;
                for (i = 1; i <= 2 * k - 1; i++)
                    Console.Write("*");
                Console.WriteLine();
            }

            ilosc = 1;
            for (k = 1; k <= dlugosc - 1; k++)
            {
                for (i = 1; i <= ilosc; i++)
                    Console.Write(" ");
                ilosc++;
                for (i = 1; i <= 2 * (dlugosc - k) - 1; i++)
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

#####################################################

namespace Exercises8_Loops
{

    /* 8. Napisz program, który odwróci wprowadzony przez użytkownika ciąg znaków. Np.
        Testowe dane:
                Abcdefg

                Rezultat
                Gfedcba */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj ciag znakow: ");
            string ciag = Console.ReadLine();

            for (int i = ciag.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(ciag[i]);
            }
            Console.ReadKey();
        }
    }
}

#####################################################

namespace Exercises9_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbe dziesietna ktora ma byc zamieniona na binarna: ");
        
            int liczbad = int.Parse(Console.ReadLine());

            Console.WriteLine($"Liczba dziesietna: {liczbad}");

            int[] tablica = new int[8];

            string liczbab = "";

            for (int i = 0; i < tablica.Length; i = i + 1)
            {
                tablica[7 - i] = liczbad % 2;
                liczbad = liczbad / 2;
            }
            for (int i = 0; i < tablica.Length; i = i + 1)
            {
                liczbab += tablica[i].ToString();
            }
            Console.WriteLine($"Liczba binarna {liczbab}");
        }
    }
}

#####################################################

namespace Exercises10_Loops
{

    // Napisz program, który znajdzie najmniejszą wspólną wielokrotność dla zadanych 2 liczb
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwsza liczbe: ");
            int liczba1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj druga liczbe: ");
            int liczba2 = int.Parse(Console.ReadLine());


            for (int i = 1; ; i++)
            {
                if ((i % liczba1 == 0) && (i % liczba2 == 0))
                {
                    Console.WriteLine($"Najmniejsza wspolna wielokrotnosc to: {i}");
                    Console.ReadKey();

                }
            }
        }
    }
}
