using System;

namespace SumUpChallenge;

class Program
{
    static void Main(string[] args)
    {
        var sum = 0;

        while (true)
        {


            System.Console.WriteLine(@"Please enter a number or ""ok"" to exit. ");
            var input = Console.ReadLine();

            if (input == "ok")
            {
                break;
            }
            
            int number = Convert.ToInt32(input);
            
            sum += number;
        }

        System.Console.WriteLine($"Total sum = {sum}");
    }
}
