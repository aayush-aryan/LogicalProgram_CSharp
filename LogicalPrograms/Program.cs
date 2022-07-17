using System;

namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press a number : \nFibonacciSeries :1\nPerfectNumber :2");
            int problemNumber = Convert.ToInt32(Console.ReadLine());

            switch (problemNumber)
            {
                case 1:
                    FibonacciSeries.ComputingFibnacciSeries();
                    break;
                case 2:
                    PerfectNumber.CheckPerfectNumber();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;

            }

        }
    }
}
