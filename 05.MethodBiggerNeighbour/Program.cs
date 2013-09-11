using System;

namespace NeighbourNumbers
{
    public class MethodBiggerNeighbour
    {
        static void Main()
        {
            Console.WriteLine("Please enter lenght of the array:");
            int lenght = int.Parse(Console.ReadLine());
            int[] elements = new int[lenght];
            for (int i = 0; i < elements.Length; i++)
            {
                Console.WriteLine("Please enter a value {0}", i);
                elements[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Please specify the position of the desired element:");
            int position = int.Parse(Console.ReadLine());
            if (ValidateData(elements, position) == false)
            {
                Console.WriteLine("The desired element has only one neighbour");
            }
            else
            {
                if (CheckNumbers(elements, position) == true)
                {
                    Console.WriteLine("The number {0} is greater than both its neighbours", elements[position]);
                }

                if (CheckNumbers(elements, position) == false)
                {
                    Console.WriteLine("The number {0} is NOT greater than its neighbours", elements[position]);
                }
            }
        }

        public static bool CheckNumbers(int[] arr, int a)
        {
            if (arr[a] > arr[a - 1] && arr[a] > arr[a + 1])
            {
                return true;
            }

            return false;
        }

        static bool ValidateData(int[] arr, int a)
        {
            if (a == 0 || a == (arr.Length - 1))
            {
                return false;
            }

            return true;
        }
    }
}