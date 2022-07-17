﻿using System;

namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press a number : \nFibonacciSeries :1\nPerfectNumber :2\nPrimeNumber :3" +
                "\nReverseNumber :4");
            int problemNumber = Convert.ToInt32(Console.ReadLine());

            switch (problemNumber)
            {
                case 1:
                    FibonacciSeries.ComputingFibnacciSeries();
                    break;
                case 2:
                    PerfectNumber.CheckPerfectNumber();
                    break;
                case 3:
                    PrimeNumber.CheckPrimeNumber();
                    break;
                case 4:
                    ReverseNumber.ReverseDigit();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;

            }

        }
    }
}
