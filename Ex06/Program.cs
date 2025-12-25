using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int prev = int.Parse(Console.ReadLine());
        bool crescatoare = true;

        for (int i = 1; i < n; i++)
        {
            int x = int.Parse(Console.ReadLine());
            if (x < prev)
                crescatoare = false;
            prev = x;
        }

        Console.WriteLine(crescatoare ? "DA" : "NU");
    }
}
