using System;
namespace Myapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Celsius value :");
            double cel = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Kelvin={0}", cel + 273);
            Console.WriteLine("Fahrenheit={0}", cel * 18 / 10 + 32);
        }
    }
}

