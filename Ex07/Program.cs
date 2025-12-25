using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int x = int.Parse(Console.ReadLine());
        int min = x, max = x;

        for (int i = 1; i < n; i++)
        {
            x = int.Parse(Console.ReadLine());
            if (x < min) min = x;
            if (x > max) max = x;
        }

        Console.WriteLine($"{min} {max}");
    }
}
