using System;

namespace MaxNumberFinder;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Please enter seperated comma numbers");

        var input = Console.ReadLine();

        var numbers = input.Split(',');

        var max = Convert.ToInt32(numbers[0]);

        foreach (var str in numbers)
        {
           var number = Convert.ToInt32(str);
            if ( number > max)
            {
                max = number;
            }
        }
        System.Console.WriteLine($"Max found number is {max}");
    }
}
