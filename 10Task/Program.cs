using System;

// Напишете програма, която чете от конзолата положително цяло число N (N < 20) и отпечатва матрица с числа като на фигурата по-долу:

class Program
{
    static void Main()
    {
        Console.WriteLine("Моля въвъдете число");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            for (int j = i; j <= i + 2 ; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }      
    }
}

