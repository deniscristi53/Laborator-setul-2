using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int grupuri = 0;
        bool inGrup = false;

        for (int i = 0; i < n; i++)
        {
            int x = int.Parse(Console.ReadLine());

            if (x != 0 && !inGrup)
            {
                grupuri++;
                inGrup = true;
            }

            if (x == 0)
                inGrup = false;
        }

        Console.WriteLine(grupuri);
    }
}
