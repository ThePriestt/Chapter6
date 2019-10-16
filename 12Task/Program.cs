using System;

// Напишете програма, която преобразува дадено число от десетична в двоична бройна система. 

class Program
{
    static void Main()
    {
        int n = 12538;

        //Console.WriteLine(n % 2);
        //n /= 2;
        //Console.WriteLine(n % 2);
        //n /= 2;
        //Console.WriteLine(n % 2);
        //n /= 2;
        //Console.WriteLine(n % 2);
        //n /= 2;
        //Console.WriteLine(n % 2);
        //n /= 2;
        //Console.WriteLine(n % 2);

        //Console.WriteLine(n / 2);

        while (n > 2)
        {
            Console.WriteLine(n % 2);
            n /= 2;    
        }
        Console.WriteLine(n);
    }
}

