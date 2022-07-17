using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class ReverseNumber
    {
        public static void ReverseDigit()
        {
            Console.WriteLine("Enter the number :");
            int number = Convert.ToInt32(Console.ReadLine());
            string revDigit = ""; int digit = 0;
            do
            {
                digit = number % 10;
                revDigit = revDigit + digit;
                number = number / 10;

            } while (number != 0);
            Console.WriteLine(revDigit);
        }

    }
}
