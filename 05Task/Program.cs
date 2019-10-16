using System;

// Напишете програма, която чете от конзолата числото N и отпечатва сумата на първите N члена от редицата на Фибоначи: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, ...

class Program
{
    static void Main()
    {
        Console.WriteLine("Моля въведете число");
        int n = int.Parse(Console.ReadLine());
        int first = 0;
        int second = 1;
        int current = first + second;

        if (n == 0)
        {
            Console.WriteLine(0);
        }

        if (n == 1)
        {
            Console.WriteLine(1);
        }
        else
        {
            for (int i = 0; i < n - 1; i++)
            {
                current = first + second;
                Console.WriteLine(current);
                first = second;
                second = current;
            }
        }       
    }
}

