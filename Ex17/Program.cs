using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int nivel = 0;
        int nivelMax = 0;
        bool corecta = true;

        for (int i = 0; i < n; i++)
        {
            int x = int.Parse(Console.ReadLine());

            if (x == 0)
                nivel++;
            else
                nivel--;

            if (nivel < 0)
                corecta = false;

            if (nivel > nivelMax)
                nivelMax = nivel;
        }

        if (nivel != 0)
            corecta = false;

        if (corecta)
            Console.WriteLine("Corecta, nivel maxim = " + nivelMax);
        else
            Console.WriteLine("Incorecta");
    }
}
