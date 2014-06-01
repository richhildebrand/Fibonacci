using System;
using System.Linq;

namespace Fibonacci
{
    public class Printer
    {
        public static void Main(string[] args)
        {
            PrintFibonacciSequence(5);
            PrintFibonacciSequence(20);
            PrintFibonacciSequence(90);

            Console.ReadKey();
        }

        public static void PrintFibonacciSequence(int maxNumber)
        {
            var fibonacciGetter = new FibonacciGetter();
            var fibSequence = fibonacciGetter.GetNumbersUnder(maxNumber);
            Console.WriteLine(string.Join(",", fibSequence));
        }
    }
}
