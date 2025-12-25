using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        long suma = 0, produs = 1;

        for (int i = 1; i <= n; i++)
        {
            suma += i;
            produs *= i;
        }

        Console.WriteLine(suma);
        Console.WriteLine(produs);
    }
}
