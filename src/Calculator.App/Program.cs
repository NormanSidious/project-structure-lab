using System;

namespace Calculator.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Простой калькулятор");
            Console.WriteLine($"2 + 3 = {Calculator.Add(2, 3)}");
            Console.WriteLine($"10 - 4 = {Calculator.Subtract(10, 4)}");
        }
    }
}