using System;

namespace _03.RecursiveFibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read the Fibonacci term to calculate
            int n = int.Parse(Console.ReadLine());

            // Calculate the square root of 5
            double sqrt5 = Math.Sqrt(5);

            // Calculate the golden ratio
            double phi = (1 + sqrt5) / 2;

            // Calculate the conjugate of the golden ratio
            double psi = (1 - sqrt5) / 2;
            
            // Use Binet's formula to calculate the nth Fibonacci number
            double fibonacci = (Math.Pow(phi, n) - Math.Pow(psi, n)) / sqrt5;

            // Round the result to the nearest integer and print it
            Console.WriteLine((int)Math.Round(fibonacci)); // Output the Fibonacci number
        }
    }
}
