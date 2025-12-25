using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        if (n == 1)
        {
            Console.WriteLine(0);
            return;
        }
        if (n == 2)
        {
            Console.WriteLine(1);
            return;
        }

        long f1 = 0, f2 = 1, f = 0;

        for (int i = 3; i <= n; i++)
        {
            f = f1 + f2;
            f1 = f2;
            f2 = f;
        }

        Console.WriteLine(f);
    }
}
