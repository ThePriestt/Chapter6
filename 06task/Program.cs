using System;

// Напишете програма, която пресмята N!/K! за дадени N и K (1<K<N).

class Program
{
    static void Main()
    {
        int n = 5;
        int k = 3;
        int nFactorial = 1;
        int kFactorial = 1;

        for (int i = 1; i <= n; i++)
        {
            nFactorial *=  i;  // nFactorial = nFactorial * i;
        }
        Console.WriteLine(nFactorial);

        for (int i = 1; i <= k ; i++)
        {
            kFactorial = kFactorial * i;
        }
        Console.WriteLine(kFactorial);
        Console.WriteLine(nFactorial / kFactorial);
    }
}

