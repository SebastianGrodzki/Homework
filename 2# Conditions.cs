using System;

namespace Exercises1_Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 5;

            if (a == b)
            {
                Console.WriteLine($" Liczby {a} i {b} są równe.");
            }
            else
            {
                Console.WriteLine($" Liczby {a} i {b} nie są równe.");
            }
        }
        
    }
}

#################################################

namespace Exercises2_Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Podaj liczbę: ");
            int a = int.Parse(Console.ReadLine());

            int wynik = a % 2;
            if (a == 0)
            {
                Console.WriteLine($"Zero to zero.");
                Console.ReadKey();
            }
            else
            {
                if (wynik == 0)
                {
                    Console.WriteLine($"Liczba {a} jest parzysta.");
                }

                else
                {
                    Console.WriteLine($" Liczby {a} jest nieparzysta.");
                    Console.ReadKey();
                }
            }
        }
    }
}

#################################################

namespace Exercises3_Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Podaj liczbę: ");
            int a = int.Parse(Console.ReadLine());

            if (a > 0)
            {
                Console.WriteLine($"Liczba {a} jest dodatnia");
                Console.ReadKey();
            }
            else if (a == 0)
            {
                Console.WriteLine($"Liczba {a} jest najmniejszą nieujemną liczbą");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"Liczba {a} jest ujemna");
                Console.ReadKey();
            }
        }
    }
}

#################################################

namespace Exercises4_Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Podaj rok: ");
            int rok = int.Parse(Console.ReadLine());
            
            int przestepny = rok % 4;

            if (przestepny == 0)
            {
                Console.WriteLine($"Rok {przestepny} jest przestępny.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"Rok {przestepny} jest nieprzestępny.");
                Console.ReadKey();
            }
        }
    }
}

#################################################

namespace Exercises5_Conditions
{
    class Program
    {
        static void Main(string[] args)
        {

            //poseł 21 lat, senator 30 lat , prezydent 35 lat, premier 21?
            
            Console.WriteLine($"Podaj wiek: ");
            int wiek = int.Parse(Console.ReadLine());

            if (wiek < 21)
            {
                Console.WriteLine($"Nie możesz pełnić żadnej z wybranych funkcji");
            }
            else if (wiek >=21 && wiek < 30)
            {
                Console.WriteLine($"Możesz zostać posłem");
            }
            else if (wiek > 29 && wiek < 35)
            {
                Console.WriteLine($"Możesz zostać posłem oraz senatorem");
            }
            else if (wiek > 34 )
            {
                Console.WriteLine($"Możesz zostać posłem, senatorem oraz prezydentem");
                Console.ReadKey();
            }

        }
    }
}

#################################################

namespace Exercises6_Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj wzrost: ");
            int wzrost = int.Parse(Console.ReadLine());

        if (wzrost <= 0)
            {
                Console.WriteLine("Nie ma Cie.");
            }
            else if (wzrost >= 1 && wzrost < 80)
            {
                Console.WriteLine("baby.");
            }
            else if (wzrost >= 80 && wzrost < 140)
            {
                Console.WriteLine("jesteś karłem.");
            }
            else if ( wzrost >=140 && wzrost < 150)
            {
                Console.WriteLine("Jesteś krasnoludem.");
            }
            else if (wzrost >= 150 && wzrost < 160)
            {
                Console.WriteLine("Jesteś wzrostu napoleona.");
            }
            else if (wzrost >= 160 && wzrost < 170)
            {
                Console.WriteLine("Jesteś dzikiem.");
            }
            else if (wzrost >= 170 && wzrost < 180)
            {
                Console.WriteLine("Jesteś średniego wzrostu.");
            }
            else if (wzrost >= 180 && wzrost < 190)
            {
                Console.WriteLine("Jesteś wysoki.");
            }
            else if (wzrost >= 190 && wzrost < 200)
            {
                Console.WriteLine("Jesteś bocian.");
            }
            else if (wzrost >= 200 && wzrost < 230)
            {
                Console.WriteLine("Masz predyspozycje na koszykarza");
            }
            else 
            {
                Console.WriteLine("Nie żartuj ;) ");
            }
        }
    }
}

#################################################

namespace Exercises7_Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Podaj pierwszą liczbę: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj trzecią liczbę: ");
            c = int.Parse(Console.ReadLine());

            if (a > b && b > c && c < a)
            {
                Console.WriteLine($"{a} + {b} + {c}");
            }
            else if (a > b && b < c && c < a)
            {
                Console.WriteLine($"{a} + {c} + {b}");
            }
            else if (b > a && a > c && b > a)
            {
                Console.WriteLine($"{b} + {a} + {c}");
            }
            else if (b > a && a < c && c < b)
            {
                Console.WriteLine($"{b} + {c} + {a}");                       
            }
            else if (c > a && a > b && c > a)
            {
                Console.WriteLine($"{c} + {a} + {b}");
            }
            else if (c > a && a < b && c > b)
            {
                Console.WriteLine($"{c} + {b} + {a}");
            }
        }
    }
}

#################################################

namespace Exercises8_Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("wyniki z matury: \n");
            Console.WriteLine("Podaj wynik z matematyki: ");
            short mat = short.Parse(Console.ReadLine());

            Console.WriteLine("Podaj wynik z chemii : ");
            short chem = short.Parse(Console.ReadLine());

            Console.WriteLine("Podaj wyniki z fizyki: ");
            short fiz = short.Parse(Console.ReadLine());

            short min = 180;

            int wynik = mat + chem + fiz;

            if ((mat > 70 && fiz > 55 && chem > 45) && wynik > min)
            {
                Console.WriteLine("Kandydat dopuszczony do rekrutacji.");
            }
            else if (mat + fiz > 150 || mat + chem > 150)
            {
                Console.WriteLine("Kandydat dopuszczony do rekrutacji.");
            }
            else
            {
                Console.WriteLine("Spróbuj w drugiej turze.");
            }
        }
    }
}

#################################################

namespace Exercises9_Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj temperature \n");
            
            short temp = short.Parse(Console.ReadLine());

            

            if (temp < 0)
            {
                Console.WriteLine("cholernie pizdzi");
            }
            else if (temp >= 0 && temp < 10 )
            {
                Console.WriteLine("zimno");
            }
            else if (temp >= 10 && temp < 20)
            {
                Console.WriteLine("chlodno");
            }
            else if (temp >= 20 && temp < 30)
            {
                Console.WriteLine("w sam raz");
            }
            else if (temp >= 30 && temp < 40)
            {
                Console.WriteLine("zaczyna byc slabo, bo goraco");
            }
            else 
            {
                Console.WriteLine("a wez wyprowadzam sie na Alaske.");
            }
        }
    }
}

#################################################

namespace Exercises10_Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj długość pierwszego boku \n");

            short boka = short.Parse(Console.ReadLine());

            Console.WriteLine("Podaj długość drugiego boku \n");

            short bokb = short.Parse(Console.ReadLine());

            Console.WriteLine("Podaj długość trzeciego boku \n");

            short bokc = short.Parse(Console.ReadLine());


            if (((boka > bokb) && (boka > bokc)) && ((bokb + bokc) > boka))
            {
                Console.WriteLine("Można zbudować trójkąt");
            }
            else if (((bokb > bokc) && (bokb > boka)) && ((bokc + boka) > bokb))
            {
                Console.WriteLine("Można zbudować trójkąt");
            }
            else if (((bokc > boka) && (bokc > bokb)) && ((boka + bokb) > bokc))
            {
                Console.WriteLine("Można zbudować trójkąt");
            }
            else 
            {
                Console.WriteLine("Niestety nie");
            }

        }
    }
}

#################################################

namespace Exercises11_Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj ocenę (cyfra): ");

            short ocena = short.Parse(Console.ReadLine());


            if (ocena == 1)
            {
                Console.WriteLine("Niedostateczny");
            }
            else if (ocena == 2)
            {
                Console.WriteLine("Dopuszczający");
            }
            else if (ocena == 3)
            {
                Console.WriteLine("Dostateczny");
            }
            else if (ocena == 4)
            {
                Console.WriteLine("Dobry");
            }
            else if (ocena == 5)
            {
                Console.WriteLine("Bardzo dobry");
            }
            else if (ocena == 6)
            {
                Console.WriteLine("Celujący");
            }
            else
            {
                Console.WriteLine("Brak oceny");
            }
        }
    }
}

#################################################

namespace Exercises12_Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj numer dnia tygodnia: ");

            short dtyg = short.Parse(Console.ReadLine());


            if (dtyg == 1)
            {
                Console.WriteLine("Poniedziałek");
            }
            else if (dtyg == 2)
            {
                Console.WriteLine("Wtorek");
            }
            else if (dtyg == 3)
            {
                Console.WriteLine("Środa");
            }
            else if (dtyg == 4)
            {
                Console.WriteLine("Czwartek");
            }
            else if (dtyg == 5)
            {
                Console.WriteLine("Piątek");
            }
            else if (dtyg == 6)
            {
                Console.WriteLine("Sobota");
            }
            else if (dtyg == 7)
            {
                Console.WriteLine("Niedziela");
            }
            else
            {
                Console.WriteLine("Nie żartuj");
            }
        }
    }
}

#################################################

namespace Exercises13_Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwszą liczbę: ");

            double a = short.Parse(Console.ReadLine());

            Console.WriteLine("Podaj drugą liczbę: ");

            double b = short.Parse(Console.ReadLine());

            Console.WriteLine("Podaj numer operacji do wykonania: ");
            Console.WriteLine("1. Dodawanie \n2. Odejmowanie \n3. Mnożenie \n4. Dzielenie");

            short c = short.Parse(Console.ReadLine());

            double wynik;

            if (c == 1)
            {
                wynik = a + b;
                Console.WriteLine($"Twój wynik to: {wynik}");
            }
            else if (c == 2)
            {
                wynik = a - b;
                Console.WriteLine($"Twój wynik to: {wynik}");
            }
            else if (c == 3)
            {
                wynik = a * b;
                Console.WriteLine($"Twój wynik to: {wynik}");
            }
            else if (c == 4)
            {
                wynik = a / b;
                Console.WriteLine($"Twój wynik to: {wynik}");
            }
            else
            {
                Console.WriteLine("Podałeś zły numer.");
            }
        }
    }
}
