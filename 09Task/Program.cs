using System;

// Напишете програма, която за дадено цяло число n, пресмята сумата: clip_image014

class Program
{
    static void Main()
    {
        int n = 10;
        int factoriel = 1;
        double power = 1;
        double sum = 1;

        for (int i = 1; i < n; i++)
        {
            factoriel *= i;
            power = Math.Pow(i, i);
            sum += factoriel / power;
        }
        Console.WriteLine(sum);
    }
}

