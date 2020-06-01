using RomanNumeralGenerator.Service;
using System;

namespace RomanNumeralGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            RomanNumeralService romanNumeralService = new RomanNumeralService();
            Console.WriteLine(romanNumeralService.Generate(3999));
            Console.ReadLine();
        }
    }
}
