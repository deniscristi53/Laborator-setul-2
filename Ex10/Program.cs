using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int prev = int.Parse(Console.ReadLine());
        int cnt = 1, maxCnt = 1;

        for (int i = 1; i < n; i++)
        {
            int x = int.Parse(Console.ReadLine());
            if (x == prev)
                cnt++;
            else
                cnt = 1;

            if (cnt > maxCnt)
                maxCnt = cnt;

            prev = x;
        }

        Console.WriteLine(maxCnt);
    }
}
