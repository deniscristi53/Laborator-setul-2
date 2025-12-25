using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int prev = int.Parse(Console.ReadLine());
        int schimbari = 0;

        for (int i = 1; i < n; i++)
        {
            int x = int.Parse(Console.ReadLine());

            if ((x > prev && schimbari == 2) || (x < prev && schimbari == 1))
                schimbari++;

            prev = x;
        }

        if (schimbari <= 2)
            Console.WriteLine("DA");
        else
            Console.WriteLine("NU");
    }
}
