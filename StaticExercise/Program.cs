using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Celcius:    {TempConverter.FahrenheitToCelcius(12)}");
            Console.WriteLine($"Celcius:    {TempConverter.CelciusToFahrenheit(-11.11)}");
        }
    }
}
