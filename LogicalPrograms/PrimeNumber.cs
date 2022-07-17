using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class PrimeNumber
    {
        public static void CheckPrimeNumber()
        {
            Console.WriteLine("Enter the number to check Prime :");
            int number = Convert.ToInt32(Console.ReadLine());
            int flag = 0;
            for (int index = 2; index <= number / 2; index++)
            {
                if (number % index == 0)
                {
                    Console.WriteLine("Number is Not a PrimeNumber :");
                    flag++;
                    break;
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("Number is PrimeNumber");
            }
        }
    }
}
