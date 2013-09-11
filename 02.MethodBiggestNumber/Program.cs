using System;

class MethodBiggestNumber

{
    static void Main()
    {
        int one = int.Parse(Console.ReadLine());
        int two = int.Parse(Console.ReadLine());
        int three = int.Parse(Console.ReadLine());
        int biggest = GetMax(one, two);
        biggest = GetMax(biggest, three);
        Console.WriteLine("The biggest number is {0}", biggest);

    }
    static int GetMax(int first, int second)
    {
        int biggest = first;
        if (second > first)
        {
            biggest = second;
        }
        return biggest;
    }

}