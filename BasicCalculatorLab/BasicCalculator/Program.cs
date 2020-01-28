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

            decimal sum = temperature - 9 * (100 - relativeHumidity) / 25 ;

            Console.WriteLine("The dew point is " + sum);

            Console.WriteLine("Enter the Windspeed: ");

            int windSpeed = int.Parse(Console.ReadLine());

            //Calculate windchill
            

            double windChill = 35.74 + (0.6125 * temperature)
                - (35.75 * Math.Pow(windSpeed, 0.16)) + (0.4275 * temperature * Math.Pow(windSpeed, 0.16));

            Console.WriteLine("The Windchill will be: " + windChill);


        }
    }
}
