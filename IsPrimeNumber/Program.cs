using System;
// Определите, является ли натуральное число простым.
//
namespace IsPrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(IsPrime(n));
            Console.ReadLine();
        }

        static bool IsPrime(int n)
        {
            for (int i = 2; i <= n/i; i++)
            {
                if (n%i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
