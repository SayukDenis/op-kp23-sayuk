using System;
class Lab1
{
    public static void Main(string[] args)
    {
        /*Test1
         * n = a
         * Expected values is error
         * Test 2
         * n= -1
         * Expected values is error
         *Test 3
         * n= 0.5
         * Expected values is error
         * Test 4
         * n= 0
         * Expected values is error
         * Test 5
         * n= 17
         * Expected values is "prime number"
         * Test 6
         * n= 16
         * Expected values is "not prime number"
         */
        int n;
        Console.WriteLine("Enter the number");
        bool nIsInt = int.TryParse(Console.ReadLine(), out n);
        if (!nIsInt || n < 1)
        {
            Console.WriteLine("Enter the right number");
            return;
        }
        for (int i = 2; i < n - 1; i++)
        {
            if (n % i == 0)
            {
                Console.WriteLine("It is not prime number");
                return;
            }
        }
        Console.WriteLine("It is prime number");
    }
}
