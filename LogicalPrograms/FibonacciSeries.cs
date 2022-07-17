using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class FibonacciSeries
    {
        public static void ComputingFibnacciSeries()
        {
            int firstTerm = 0, secondTerm = 1, thirdTerm;

            Console.WriteLine("Enter the number of term you want FibonacciSeries : ");
            int fibTerm = Convert.ToInt32(Console.ReadLine());

            Console.Write("fibonacciSeries are :" + firstTerm + "," + secondTerm);
            for (int index = 3; index <= fibTerm; index++)
            {
                thirdTerm = firstTerm + secondTerm;
                Console.Write(","+thirdTerm);
                firstTerm = secondTerm;
                secondTerm = thirdTerm;
            }

        }
    }
}
