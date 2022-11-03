using System;
class Lab1
{
    static public void Main(string[] args)
    {
        /*Test 1
         * x = a; n = 1;
         * Expected value error
         * Test 2
         * x = 1; n = b;
         * Expected value error
         * Test 3
         * x = a; n = b;
         * Expected value error
         * Test 4
         * x = 5; n = -2;
         * Expected value error
         * Test 5
         * x = 2; n = 5;
         * Expected value (120,32)
         * Test 6
         * x = 5; n = 2;
         * Expected value (2,25)
         */
        int n, x;
        int resfactorial = 1;
        int xinpown = 1;
        Console.WriteLine(resfactorial);
        Console.WriteLine(xinpown);
    }
}
using System;
class Lab1
{
    static public void Main(string[] args)
    {
        /*Test 1
         * x = a; n = 1;
         * Expected value error
         * Test 2
         * x = 1; n = b;
         * Expected value error
         * Test 3
         * x = a; n = b;
         * Expected value error
         * Test 4
         * x = 5; n = -2;
         * Expected value error
         * Test 5
         * x = 2; n = 5;
         * Expected value (120,32)
         * Test 6
         * x = 5; n = 2;
         * Expected value (2,25)
         */
                int n, x;
        int resfactorial = 1;
        int xinpown = 1;
        bool IsNInt, IsXInt;
        Console.WriteLine("Enter the number n");
        IsNInt = int.TryParse(Console.ReadLine(), out n);
        if (!IsNInt || n < 1)
        {
            Console.WriteLine("Enter the right number n");
            return;
        }
        Console.WriteLine("Enter the number x");
        IsXInt = int.TryParse(Console.ReadLine(), out x);
        if (!IsXInt)
        {
            Console.WriteLine("Enter the right");
            return;
        }
        for (int i = 1; i <= n; i++)
        {
            resfactorial *= i;
            xinpown *= x;

        }
        Console.WriteLine(resfactorial);
        Console.WriteLine(xinpown);
    }
}

