using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double suma = 0;

        for (int i = 0; i < n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            suma += 1 / x;
        }

        Console.WriteLine(suma);
    }
}
