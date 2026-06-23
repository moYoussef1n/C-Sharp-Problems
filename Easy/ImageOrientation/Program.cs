using System;

namespace ImageOrientation;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Please enter the width");

        var width = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine("Please enter the height");

        var height = Convert.ToInt32(Console.ReadLine());

        if (width > height)
        {
            System.Console.WriteLine("The image is landscape.");
        }
        else
        {
            System.Console.WriteLine("The image is portrait.");
        }



    }
}
