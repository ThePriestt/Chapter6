using System;

// Напишете програма, която по дадено число N отпечатва числата от 1 до N, разбъркани в случаен ред. 

class Program
{
    static void Main()
    {
        int n = 100;
        int[] myArray = new int[n];

        for (int i = 0; i < myArray.Length; i++)
        {
            myArray[i] = i;
            Console.WriteLine(myArray[i]);
        }
        Random generator = new Random();

        for (int i = 0; i < 50; i++)
        {
            Console.WriteLine(generator.Next(50));
        }
    }
}

