using System;

namespace MethodReverseDigits
{
    public class MethodReverseDigits
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number");
            decimal number = decimal.Parse(Console.ReadLine());

            ReverseDigits(number);
        }

        public static void ReverseDigits(decimal number)
        {
            if (number < 0)
            {
                Console.Write("-");
                number = Math.Abs(number);
            }

            string stringNumber = number.ToString();
            for (int i = stringNumber.Length; i > 0; i--)
            {
                Console.Write(stringNumber[i - 1]);
            }
        }
    }
}