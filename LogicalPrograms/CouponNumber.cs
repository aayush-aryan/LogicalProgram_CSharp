using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class CouponNumber
    {
        public static void CouponGenerator()
        {
            Random random = new Random();
            char[] charArray = {'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P',
            'Q','R','S','T','U','V','W','X','Y','Z','a','b','c','d','e','f','g','h','i','j',
                'k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z' };

            Console.WriteLine("Enter the number Of Coupon:");
            int numberOfCoupon = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your Coupon Number is :");
            while (numberOfCoupon > 0)
            {
                string emptyStr = "";
                for (int index = 0; index <= 3; index++)
                {
                    int value = random.Next(0, 52);
                    char ch = charArray[value];
                    emptyStr = emptyStr + ch;
                }
                for (int index = 0; index < 3; index++)
                {
                    int value = random.Next(0, 9);
                    emptyStr = emptyStr + value;
                }
                Console.WriteLine(emptyStr);
                numberOfCoupon--;
            }

        }
    }
}
