using System;

namespace SpeedCamera;

class Program
{
    static void Main(string[] args)
    {
        const int AllowedSpeed = 90;

        var finePoints = 0;

        var speedDifference = 0;

        System.Console.WriteLine("Please enter car speed");

        var carSpeed = Convert.ToInt32(Console.ReadLine());

        if (carSpeed <= 90)
        {
            System.Console.WriteLine("Ok!");
        }
        else
        {
            speedDifference = carSpeed - AllowedSpeed;
            finePoints = speedDifference / 5 ;

            if (finePoints > 12 )
            {
                System.Console.WriteLine("License Suspended");
            }
            else
            {
                System.Console.WriteLine($"Care! You have {finePoints} fine points");
            }
        }


    }
}
