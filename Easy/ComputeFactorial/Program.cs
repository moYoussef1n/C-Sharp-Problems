using System;

namespace ComputeFactorial;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Please enter your fav number");
        var number = Convert.ToInt32(Console.ReadLine());

        long factorial = 1 ;

        for (int i = number ; i >= 1; i--)
        {
            factorial *= i ;
        }

        System.Console.WriteLine($"Facorial of number {number} = {factorial}");
    }
}
