using System;

class FibonacciNumbers
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        Fin(n);
    }

    private static void Fin(int n)
    {
        var f1 = 1;
        var f2 = 0;
        var nextNumber = 0;
        for (int i = 0; i <= n; i++)
        {
            nextNumber = f1 + f2;
            f1 = f2;
            f2 = nextNumber;
        }
        Console.WriteLine(f2);
    }
}

