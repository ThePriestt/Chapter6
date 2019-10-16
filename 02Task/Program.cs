using System;

// Напишете програма, която отпечатва на конзолата числата от 1 до N, които не се делят едновременно на 3 и 7. Числото N да се чете от стандартния вход.

class Program
{
    static void Main()
    {
        Console.WriteLine("Моля въведете N");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i < n; i++)
        {
            if (i % 3 == 0 && i % 7 == 0)
            {
                continue;
            }
            Console.WriteLine(i);
        }
    }
}

