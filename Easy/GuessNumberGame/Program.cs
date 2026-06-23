using System;

namespace GuessNumberGame;

class Program
{
    static void Main(string[] args)
    {
        var number = new Random().Next(1,10);

        //System.Console.WriteLine($"Random number is {number}");

        //you have 4 trials to win goodluck bro 

        for (int i = 0; i < 4; i++)
        {
            System.Console.WriteLine("Guess the number");
            var guess = Convert.ToInt32(Console.ReadLine());

            if (guess == number)
            {
                System.Console.WriteLine("You won!");
                return;
            }
        }
        System.Console.WriteLine("You lost!");
    }
}
