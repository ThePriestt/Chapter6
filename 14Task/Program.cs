using System;

// Напишете програма, която преобразува дадено число от десетична в шестнайсетична бройна система. 

class Program
{
    static void Main()
    {
        int n = 15367;

        //Console.WriteLine(n / 16);
        //Console.WriteLine(n % 16);

        //n = n / 16;
        //Console.WriteLine(n / 16);
        //Console.WriteLine(n % 16);

        //n = n / 16;
        //Console.WriteLine(n / 16);
        //Console.WriteLine(n % 16);

        while (n > 16)
        {
            Console.WriteLine(n % 16);
            n /= 16; // n = n / 16
        }
        Console.WriteLine(n); // Остатък
    }
}

