using System;

class Lab1
{
    static public void Main(string[] args)
    {
        /*
        * Test 1
        * sinx = b,a = 10
        * Expected value error
        * Test 2
        * sinx = 300,a = b
        * Expected value error
        * Test 3
        * sinx = 0,a = 10
        * Expected value 0
        * Test 4
        * sinx = 90,a = 10
        * Expected value 0,9999
        * Test 5
        * sinx = 150,a = 10
        * Expected value 0,5
        * Test 6
        * sinx = 210,a = 10
        * Expected value -0,5
        * Test 7
        * sinx = 1000,a = 10
        * Expected value -0,9848
        * Test 8
        * sinx = 360,a = 10
        * Expected value 0
        * Test 8
        */
        int a;
        double x, grad = 0;
        double sinx = 0;
        bool IsAInt, IsXInt;
        int c = 1;
        Console.WriteLine("Enter the number x");
        IsXInt = double.TryParse(Console.ReadLine(), out x);
        if (!IsXInt || x < 0)
        {
            Console.WriteLine("Enter the right number");
            return;
        }
        Console.WriteLine("Enter the number a");
        IsAInt = int.TryParse(Console.ReadLine(), out a);
        if (!IsAInt || a < 1)
        {
            Console.WriteLine("Enter the right number");
            return;
        }
        double res = x % 360;
        if (res <= 90) grad = res;
        else if (res > 90 && res <= 180) grad = 180 - res;
        else if (res > 180 && res <= 270) { grad = res - 180; c = -1; }
        else if (res > 180 && res <= 360) { grad = 360 - res; c = -1; }
        for (int n = 0; n < 11; n++)
        {
            int factorial = 1;
            for (int j = 1; j <= 2 * n + 1; j++) factorial *= j;
            sinx += Math.Pow((-1), n) * (Math.Pow((grad * Math.PI) / 180, 2 * n + 1) / factorial);
        }
        Console.WriteLine(sinx * c);
    }
}