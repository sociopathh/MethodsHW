using System;

public class MethodNumberCount
{
    static void Main()
    {
        Console.WriteLine("Enter lenght of the array:");
        int lenght = int.Parse(Console.ReadLine());
        int[] elements = new int[lenght];
        for (int i = 0; i < elements.Length; i++)
        {
            Console.WriteLine("Enter a value");
            elements[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Specify which number to look for:");
        int number = int.Parse(Console.ReadLine());
        RepeatingNumbers(elements, number);
    }

    public static int RepeatingNumbers(int[] elements, int number)
        {
        int counter = 0;
        for (int i = 0; i < elements.Length; i++)
        {
            if (elements[i] == number)
            {
                counter++;
            }
        }
        
        Console.WriteLine("The number {0} appears {1} times in the array", number, counter);
        return counter;
    }
}
