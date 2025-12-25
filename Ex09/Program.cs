using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int prev = int.Parse(Console.ReadLine());
        bool cresc = true, descresc = true;

        for (int i = 1; i < n; i++)
        {
            int x = int.Parse(Console.ReadLine());
            if (x < prev) cresc = false;
            if (x > prev) descresc = false;
            prev = x;
        }

        Console.WriteLine(cresc || descresc ? "DA" : "NU");
    }
}