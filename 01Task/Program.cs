using System;

// Напишете програма, която отпечатва на конзолата числата от 1 до N. Числото N трябва да се чете от стандартния вход.

class Program
{
    static void Main()
    {
        Console.WriteLine("Моля въведете N");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i < n; i++)
        {
            Console.WriteLine(i);
        }
    }
}

