using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class PerfectNumber
    {
        public static void CheckPerfectNumber()
        {
            Console.WriteLine("Enter the number :");
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int index = 1; index <= number / 2; index++)
            {
                if (number % index == 0)
                {
                    sum = sum + index;
                }
            }
            if (sum == number)
                Console.WriteLine("Number is PerfectNumber :");
            else
                Console.WriteLine("Number not a perfect Number :");

        }
    }
}
