using System;
using System.Numerics;

namespace MethodCalculate
{
    class MethodCalculate
    {
        static void Main()
        {
            Console.WriteLine("Enter a number between 0 and 100");
            BigInteger number = BigInteger.Parse(Console.ReadLine());
            BigInteger factoriel = CalculateFactoriel(number);
            Console.WriteLine("{0} factoriel is equal to:{1}", number, factoriel);
        }

        static BigInteger CalculateFactoriel(BigInteger number)
        {
            BigInteger sum = 1;
            for (int i = 1; i <= number; i++)
            {
                sum = sum * i;
            }

            return sum;
        }
    }
}