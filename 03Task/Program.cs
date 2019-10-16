using System;

// Напишете програма, която чете от конзолата поредица от цели числа и отпечатва най-малкото и най-голямото от тях.

class Program
{
    static void Main()
    {
        Console.WriteLine("Моля въведете броя на числата n");
        int n = int.Parse(Console.ReadLine());

        int currentNumber;
        int min = 0;
        int max = 0;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Моля въведете число");
            currentNumber = int.Parse(Console.ReadLine());

            if (i == 0)
            {
                min = currentNumber;
                max = currentNumber; 
            }

            if (currentNumber < min)
            {
                min = currentNumber;
            }

            if (currentNumber > max)
            {
                max = currentNumber;
            }
        }
        Console.WriteLine("Най-малкото число е {0}", min);
        Console.WriteLine("Най-голямото число е {0}", max);

    }
}

