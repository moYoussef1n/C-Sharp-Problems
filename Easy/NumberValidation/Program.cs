using System;

namespace NumberValidation;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Please enter number in range 1 : 10");

        var inputNumber = Convert.ToInt32(Console.ReadLine());

        if (inputNumber >= 1 && inputNumber <= 10)
        {
            System.Console.WriteLine("Valid");
        }
        else
        {
            System.Console.WriteLine("Invalid");
        }
    }
}
