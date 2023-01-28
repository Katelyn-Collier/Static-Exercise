using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FarenheitToCelsius(double f)
        {
            return (f - 32) / 1.8;
        }

        public static double CelsiusToFarenheit(double c)
        {
            return (c * 9) / 5 + 32;
        }
    }
}
