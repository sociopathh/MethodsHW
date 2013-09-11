using System;

class MethodLastDigit
{
    static int LastDigit(int number)
    {
        int lastDigit = number % 10;
        return lastDigit;
    }

    static void PrintDigitAsWord(int lastNum)
    {

        switch (lastNum)
        {
            case 0: Console.WriteLine("Zero"); break;
            case 1: Console.WriteLine("One"); break;
            case 2: Console.WriteLine("Two"); break;
            case 3: Console.WriteLine("Three"); break;
            case 4: Console.WriteLine("Four"); break;
            case 5: Console.WriteLine("Five"); break;
            case 6: Console.WriteLine("Six"); break;
            case 7: Console.WriteLine("Seven"); break;
            case 8: Console.WriteLine("Eight"); break;
            case 9: Console.WriteLine("Nine"); break;
        }
    }

    static void Main()
    {
        Console.Write("Enter Number:");
        int n = int.Parse(Console.ReadLine());

        int lastDigitIs = LastDigit(n);
        PrintDigitAsWord(lastDigitIs);
    }
}