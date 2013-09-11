using System;
using MethodReverseDigits;

namespace Task13MultiTask
{
    class Task13MultiTask
    {
        static double Average(int[] arr)
        {
            double average = 0;
            int sum = 0;
            for (int j = 0; j < arr.Length; j++)
            {
                sum = arr[j] + sum;
            }

            return average = sum / (double)arr.Length;
        }

        static double Equation(int a, int b)
        {
            double result = (double)-b / a;
            return result;
        }

        static void Main()
        {
            Console.WriteLine("Please select the desired function and enter the coresponding number");
            Console.WriteLine("1-Reverse the digits of a number");
            Console.WriteLine("2-Calculate the average of a sequence of integers");
            Console.WriteLine("3-Solve a linear equation");
            int choice = int.Parse(Console.ReadLine());
            if (choice < 1 || choice > 3)
            {
                Console.WriteLine("Invalid selection please try again");
            }
            else if (choice == 1)
            {
                Console.WriteLine("Please enter a number");
                decimal number = decimal.Parse(Console.ReadLine());
                if (number >= 0)
                {
                    MethodReverseDigits.MethodReverseDigits.ReverseDigits(number);
                }
                else
                {
                    Console.WriteLine("Please enter a valid number(larger than 0)");
                }
            }
            else if (choice == 2)
            {
                Console.WriteLine("How many numbers are in the sequence");
                int sequenceCount = int.Parse(Console.ReadLine());
                if (sequenceCount > 0)
                {
                    var myArray = new int[sequenceCount];
                    for (int i = 0; i < myArray.Length; i++)
                    {
                        Console.WriteLine("Input {0} number", i);
                        myArray[i] = int.Parse(Console.ReadLine());
                    }

                    double finalAverage = Average(myArray);
                    Console.WriteLine(finalAverage);
                }
                else
                {
                    Console.WriteLine("Please enter a valid number(larger than 0)");
                }
            }
            else if (choice == 3)
            {
                Console.WriteLine("Enter values for a and b in the following equation: a*x+b=0");
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                if (a == 0)
                {
                    Console.WriteLine("Please enter a value for a different from zero");
                }
                else
                {
                    double finalResult = Equation(a, b);
                    Console.WriteLine(finalResult);
                }
            }
        }
    }
}