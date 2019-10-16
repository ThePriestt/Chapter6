using System;

// Напишете програма, която преобразува дадено число от двоична в десетична бройна система. 

class Program
{
    static void Main()
    {
        string n = "101110101";
        int sum = 0;
        
        sum += 1 * (int)Math.Pow(2, 8);
        sum += 0 * (int)Math.Pow(2, 7);
        sum += 1 * (int)Math.Pow(2, 6);
        sum += 1 * (int)Math.Pow(2, 5);
        sum += 1 * (int)Math.Pow(2, 4);
        sum += 0 * (int)Math.Pow(2, 3);
        sum += 1 * (int)Math.Pow(2, 2);
        sum += 0 * (int)Math.Pow(2, 1);
        sum += 1 * (int)Math.Pow(2, 0);

        Console.WriteLine(sum);
        sum = 0;

        for (int i = 0; i < n.Length; i++)
        {
            sum += int.Parse(n[i].ToString()) * (int)Math.Pow(2, n.Length - i - 1);
        }
        Console.WriteLine(sum);
    }
}

