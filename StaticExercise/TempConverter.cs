using System;

namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FahrenheitToCelcius(double f)
        {
            return (f - 32) / 1.8;
        }
        public static double CelciusToFahrenheit(double c)
        {
            return (c * 1.8) + 32;
        }
    }
}
