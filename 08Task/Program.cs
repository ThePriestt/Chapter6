using System;

// В комбинаториката числата на Каталан (Catalan’s numbers) се изчис­ляват по следната формула: clip_image012, за n ≥ 0. 
// Напи­шете програма, която изчислява n-тото число на Каталан за дадено n.

class Program
{
    static void Main()
    {
        int n = 8;
        int nFactorial = 1;
        int n2Factorial = 1;
        int nPlus1Factorial = 1;
        
        for (int i = 1; i <= n; i++)
        {
            nFactorial *= i;
        }
        Console.WriteLine(nFactorial);

        for (int i = 1; i <= 2*n ; i++)
        {
            n2Factorial *= i;
        }
        Console.WriteLine(n2Factorial);

        for (int i = 1; i <= n + 1; i++)
        {
            nPlus1Factorial *= i;
        }
        Console.WriteLine(nPlus1Factorial);
        Console.WriteLine(n2Factorial / nPlus1Factorial * nFactorial);
    }
}

