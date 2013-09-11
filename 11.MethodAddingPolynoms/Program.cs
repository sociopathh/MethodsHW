using System;

class Polynoms
{
    //sum polynoms
    static void SumOfPolynoms(decimal[] firstPolynom, decimal[] secondPolynom, decimal[] result)
    {
        int minLenght = 0;
        int smallerPolynom = 0;

        if (firstPolynom.Length > secondPolynom.Length)
        {
            minLenght = secondPolynom.Length;
            smallerPolynom = 2;
        }
        else
        {
            minLenght = firstPolynom.Length;
            smallerPolynom = 1;
        }

        for (int i = 0; i < minLenght; i++)
        {
            result[i] = firstPolynom[i] + secondPolynom[i];
        }

        for (int i = minLenght; i < result.Length; i++)
        {
            if (smallerPolynom == 1)
            {
                result[i] = secondPolynom[i];
            }
            else
            {
                result[i] = firstPolynom[i];
            }
        }
    }

    //substraction of polynoms
    static void SubstractionOfPolynoms(decimal[] firstPolynom, decimal[] secondPolynom, decimal[] result)
    {
        int minLenght = 0;
        int smallerPolynom = 0;

        if (firstPolynom.Length > secondPolynom.Length)
        {
            minLenght = secondPolynom.Length;
            smallerPolynom = 2;
        }
        else
        {
            minLenght = firstPolynom.Length;
            smallerPolynom = 1;
        }

        for (int i = 0; i < minLenght; i++)
        {
            result[i] = firstPolynom[i] - secondPolynom[i];
        }

        for (int i = minLenght; i < result.Length; i++)
        {
            if (smallerPolynom == 1)
            {
                result[i] = secondPolynom[i];
            }
            else
            {
                result[i] = firstPolynom[i];
            }
        }
    }
    //multiplying of polynoms
    static void MultiplyPolynom(decimal[] firstPolynom, decimal[] secondPolynom, decimal[] result)
    {
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = 0;
        }

        for (int i = 0; i < firstPolynom.Length; i++)
        {
            for (int j = 0; j < secondPolynom.Length; j++)
            {
                int position = i + j;
                result[position] += (firstPolynom[i] * secondPolynom[j]);
            }
        }
    }

    //print polynom
    static void PrintPolynom(decimal[] polynom)
    {
        for (int i = polynom.Length - 1; i >= 0; i--)
        {
            if (polynom[i] != 0 && i != 0)
            {
                if (polynom[i - 1] >= 0)
                {
                    Console.Write("{1}x^{0} +", i, polynom[i]);
                }
                else
                {
                    Console.Write("{1}x^{0} ", i, polynom[i]);
                }
            }
            else if (i == 0)
            {
                Console.Write("{0}", polynom[i]);
            }
        }

        Console.WriteLine();
    }

    static void Main()
    {
        decimal[] firstPolynom = { 5, -1 };
        Console.Write("First polynom:                 ");
        PrintPolynom(firstPolynom);

        decimal[] secondPolynom = { 10, -5, 6 };
        Console.Write("Second polinomial:                ");
        PrintPolynom(secondPolynom);

        int maxLenght = 0;
        if (firstPolynom.Length > secondPolynom.Length)
        {
            maxLenght = firstPolynom.Length;
        }
        else
        {
            maxLenght = secondPolynom.Length;
        }

        decimal[] result = new decimal[maxLenght];
        Console.WriteLine();

        //sum the polinomials into result
        SumOfPolynoms(firstPolynom, secondPolynom, result);

        Console.Write("Sum:                              ");
        PrintPolynom(result);

        SubstractionOfPolynoms(firstPolynom, secondPolynom, result);

        Console.Write("Substraction:                     ");
        PrintPolynom(result);

        decimal[] multiply = new decimal[firstPolynom.Length + secondPolynom.Length];

        MultiplyPolynom(firstPolynom, secondPolynom, multiply);

        Console.Write("Multiplication:                   ");
        PrintPolynom(multiply);
    }
}