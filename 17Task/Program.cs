using System;

// Напишете програма, която за дадени две числа, намира най-големия им общ делител (НОД) и най-малкото им общо кратно (НОК). 
// Можете да използвате формулата НОК(a, b) = |a*b| / НОД(а, b). 
// http://www.informatika.bg/lectures/gcd-and-lcm

class Program
{
    static void Main()
    {
        int a = 39;
        int b = 75;
        int nod = 0;

        // Наивен алгоритъм. Проверяваме за всяко число по-малко от а дали дели и двете.
        for (int i = Math.Min(a, b); i >= 1; i--)
        {
            if (a % i == 0 && b % i == 0)
            {
                Console.WriteLine("Най-големият общ делител е {0}", i);
                nod = i;
                break;
            }
        }

        Console.WriteLine("Най-малкото общо кратно е {0}", Math.Abs(a * b) / nod);
    }
}

