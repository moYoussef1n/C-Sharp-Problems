using System;

namespace DivisibleByThreeChallenge;

class Program
{
    static void Main(string[] args)
    {
        var count = 0; 
        for (int i = 1 ; i <= 100; i++)
        {
            if (i % 3 == 0)
            {
                count += 1 ;
                System.Console.WriteLine($"Count {count} is: {i}");
            }
        }
        System.Console.WriteLine($"Total counts is {count}");
    }
}
