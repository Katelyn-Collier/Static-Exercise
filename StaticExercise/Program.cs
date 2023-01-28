namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var c = TempConverter.FarenheitToCelsius(68);
            var f = TempConverter.CelsiusToFarenheit(20);

            Console.WriteLine("After converting:");
            Console.WriteLine($"{c} degrees celsius");
            Console.WriteLine($"{f} degrees farenheit");
        }
    }
}
