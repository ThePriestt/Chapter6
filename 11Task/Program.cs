using System;

// Напишете програма, която пресмята с колко нули завършва факториелът на дадено число. Примери: 
// N = 10 -> N! = 3628800 -> 2   N = 20 -> N! = 2432902008176640000 -> 4 

class Program
{
    static void Main()
    {
        int n = 20;
        int devider = 5;
        int zeros = 0;

        // Console.WriteLine("Броя на нулите е {0}", n / 5 + n / 25 + n / 125 + n / 625);

        while (devider < n)
        {
            zeros +=  n / devider; 
            devider *= 5;
        }

        Console.WriteLine("Броя на нулите е {0}", zeros);
    }
}

