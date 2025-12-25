using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int prev = int.Parse(Console.ReadLine());
        bool cresc = true;
        bool ok = true;

        for (int i = 1; i < n; i++)
        {
            int x = int.Parse(Console.ReadLine());

            if (cresc)
            {
                if (x < prev)
                    cresc = false;
            }
            else
            {
                if (x > prev)
                    ok = false;
            }

            prev = x;
        }

        if (ok)
            Console.WriteLine("DA");
        else
            Console.WriteLine("NU");
    }
}
