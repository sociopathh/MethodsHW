using System;

namespace Task9MaximalElement
{
    class Task9MaximalElement
    {
        static void Main()
        {
            Console.WriteLine("Enter the number of integers");
            int lenght = int.Parse(Console.ReadLine());
            int[] myArray = new int[lenght];
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine("Please input element {0}", i);
                myArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter the starting index");
            int startIndex = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the ending index");
            int endIndex = int.Parse(Console.ReadLine());
            if (ValidateInput(startIndex, endIndex, lenght) == false)
            {
                Console.WriteLine("Please enter valid index numbers (0>startingINdex>endingIndex>lenght)");
            }
            else
            {
                int[] newArray = new int[endIndex - startIndex + 1];
                for (int k = 0; k < newArray.Length; k++, startIndex++)
                {
                    newArray[k] = myArray[startIndex];
                }

                Console.WriteLine();
                Print(newArray);
                SortDescending(newArray);
                Print(newArray);
            }
        }

        static int Maximal(int[] arr)
        {
            int greatest = int.MinValue;
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] > greatest)
                {
                    greatest = arr[j];
                }
            }

            return greatest;
        }

        static bool ValidateInput(int a, int b, int lenght)
        {
            bool validateInput = false;
            if (a > 0 && a < lenght && b > a && b < lenght)
            {
                validateInput = true;
            }

            return validateInput;
        }

        static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        static int[] SortDescending(int[] arr)
        {
            int tempMax = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                tempMax = arr[i];
                for (int k = i + 1; k < arr.Length; k++)
                {
                    if (arr[k] > tempMax)
                    {
                        tempMax = arr[i];
                        arr[i] = arr[k];
                        arr[k] = tempMax;
                    }
                }
            }

            Console.WriteLine();
            return arr;
        }
    }
}