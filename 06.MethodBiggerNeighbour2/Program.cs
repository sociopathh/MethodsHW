using System;

namespace Task6NeighbourNumbersSecond
{
    class Task6NeighbourNumbersSecond
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

            for (int j = 1; j < (elements.Length - 1); j++)
            {
                bool result = NeighbourNumbers.MethodBiggerNeighbour.CheckNumbers(elements, j);
                if (result == true)
                {
                    Console.WriteLine("The index of the first element which is greater than its neighoubrs is:{0}", j);
                    break;
                }

                if (result == false)
                {
                    Console.WriteLine("-1");
                    break;
                }
            }
        }
    }
}