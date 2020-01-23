using System;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** BASIC Wether CALCULATOR ***");

            Console.WriteLine("Enter Temperature in Fehrenheit: ");

            // int.Parse will take a string data type and convert it to an int data type
            int temperature = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Relative Humidity: ");
            int relativeHumidity = int.Parse(Console.ReadLine());

            int sum = temperature - 9 * (100 - relativeHumidity) / 25 ;

            Console.WriteLine("The answer is " + sum);
        }
    }
}
