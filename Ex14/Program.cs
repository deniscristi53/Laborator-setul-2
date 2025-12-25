using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int prev = int.Parse(Console.ReadLine());
        int rupturi = 0;

        for (int i = 1; i < n; i++)
        {
            int x = int.Parse(Console.ReadLine());

            if (x < prev)
                rupturi++;

            prev = x;
        }

        if (rupturi <= 1)
            Console.WriteLine("DA");
        else
            Console.WriteLine("NU");
    }
}
