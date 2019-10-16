using System;

// Напишете програма, която преобразува дадено число от шестнайсетична в десетична бройна система. 

class Program
{
    static void Main()
    {
        int n = 0xD78C;
        int sum = 0;

        sum += 13 * (int)Math.Pow(16, 3);
        sum += 7 * (int)Math.Pow(16, 2);
        sum += 8 * (int)Math.Pow(16, 1);
        sum += 12 * (int)Math.Pow(16, 0);

        Console.WriteLine(sum);

        Console.WriteLine("{0:X}", n / 16);
        Console.WriteLine("{0:X}", n % 16);

        Console.Clear();
        sum = 0;
        int i = 0;
        while (n > 16) 
        {
            //Console.WriteLine("{0:X}", n);
            //Console.WriteLine("{0:X}", n % 16);

            sum += (n % 16) * (int)Math.Pow(16, i);
            n = n / 16;
            i++;           
        }
        sum += n * (int)Math.Pow(16, 3);
        Console.WriteLine(sum);
    }
}

