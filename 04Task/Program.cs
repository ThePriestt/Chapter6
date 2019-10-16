using System;

// Напишете програма, която отпечатва всички възможни карти от стан­дартно тесте карти без джокери (имаме 52 карти: 4 бои по 13 карти).

class Program
{
    static void Main()
    {
        for (int i = 2; i < 15; i++)
        {
            if (i < 11)
            {
                Console.WriteLine("Пика {0}", i);
            }
            else if (i == 11)
            {
                Console.WriteLine("Вале {0}", "Пика");
            }
            else if (i == 12)
            {
                Console.WriteLine("Дама {0}", "Пика");
            }
            else if (i == 13)
            {
                Console.WriteLine("Поп {0}", "Пика");
            }
            else if (i == 14)
            {
                Console.WriteLine("Туз {0}", "Пика");
            }          
        }

        for (int i = 2; i < 15; i++)
        {
            if (i < 11)
            {
                Console.WriteLine("Спатия {0}", i);
            }
            else if (i == 11)
            {
                Console.WriteLine("Вале {0}", "Спатия");
            }
            else if (i == 12)
            {
                Console.WriteLine("Дама {0}", "Спатия");
            }
            else if (i == 13)
            {
                Console.WriteLine("Поп {0}", "Спатия");
            }
            else if (i == 14)
            {
                Console.WriteLine("Туз {0}", "Спатия");
            }
        }

        for (int i = 2; i < 15; i++)
        {
            if (i < 11)
            {
                Console.WriteLine("Каро {0}", i);
            }
            else if (i == 11)
            {
                Console.WriteLine("Вале {0}", "Каро");
            }
            else if (i == 12)
            {
                Console.WriteLine("Дама {0}", "Каро");
            }
            else if (i == 13)
            {
                Console.WriteLine("Поп {0}", "Каро");
            }
            else if (i == 14)
            {
                Console.WriteLine("Туз {0}", "Каро");
            }
        }

        for (int i = 2; i < 15; i++)
        {
            if (i < 11)
            {
                Console.WriteLine("Купа {0}", i);
            }
            else if (i == 11)
            {
                Console.WriteLine("Вале {0}", "Купа");
            }
            else if (i == 12)
            {
                Console.WriteLine("Дама {0}", "Купа");
            }
            else if (i == 13)
            {
                Console.WriteLine("Поп {0}", "Купа");
            }
            else if (i == 14)
            {
                Console.WriteLine("Туз {0}", "Купа");
            }
        }
    }
}

