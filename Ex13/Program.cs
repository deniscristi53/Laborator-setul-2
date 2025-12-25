using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int first = int.Parse(Console.ReadLine());
        int prev = first;
        int scaderi = 0;

        for (int i = 1; i < n; i++)
        {
            int x = int.Parse(Console.ReadLine());

            if (x < prev)
                scaderi++;

            prev = x;
        }

        if (first < prev)
            scaderi++;

        if (scaderi <= 1)
            Console.WriteLine("DA");
        else
            Console.WriteLine("NU");
    }
}
