using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int cnt = 0;

        for (int i = 0; i < n; i++)
        {
            int x = int.Parse(Console.ReadLine());
            if (x == i)
                cnt++;
        }

        Console.WriteLine(cnt);
    }
}