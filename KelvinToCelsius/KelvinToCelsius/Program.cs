using KelvinToCelsius.Models;
using System;

namespace KelvinToCelsius
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter the amount of Kelvin: ");
            float input = float.Parse(Console.ReadLine());

            Kelvin kelvin = new Kelvin(input);            
            Celsius celsius = kelvin;

            Console.Clear();
            Console.WriteLine($"Temperature in Kelvin (K): {input}");
            Console.WriteLine($"Temperature in Celsius (C): {celsius.Degree}");
        }
    }
}
