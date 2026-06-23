using System;

namespace MaxNumber;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Please enter your first number");

        var firstNumber = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine("Please enter your second number");

        var secondNumber = Convert.ToInt32(Console.ReadLine());

        if (firstNumber > secondNumber)
        {
            Console.WriteLine($"Max Number: {firstNumber}");
        }
        else
        {
            Console.WriteLine($"Max Number: {secondNumber}");
        }



    }
}
