using System;

// Напишете програма, която пресмята N!*K!/(N-K)! за дадени N и K (1<K<N).

class Program
{
    static void Main()
    {
        int n = 8;
        int k = 7;
        int nFactorial = 1;
        int kFactorial = 1;

        for (int i = 1; i <= n ; i++)
        {
            nFactorial *= i;
        }
        Console.WriteLine(nFactorial);

        for (int i = 1; i <= k; i++)
        {
            kFactorial *= i;
        }
        Console.WriteLine(kFactorial);
        Console.WriteLine((double)nFactorial * kFactorial /(n - k));
    }
}

