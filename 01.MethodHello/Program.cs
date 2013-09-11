using System;
using System.Linq;

class MethodHello
{
    static void TestAndPrint(string name)
    {
        bool result = name.All(Char.IsLetter);

        if (result)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }

    static void Main()
    {
        Console.Write("Write your name: ");
        string input = Console.ReadLine();

        TestAndPrint(input);
    }
}