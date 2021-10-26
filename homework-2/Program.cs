using System;

namespace homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Daxil edilmis string deyerinin icinde reqem olub olmadigini tapan proqram

            Console.WriteLine("String gir");
            string str = Console.ReadLine();

            char[] digits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            bool check = false;

            for (int i = 0; i < str.Length; i++)
            {
                char word = str[i];
                for (int j = 0; j < digits.Length; j++)
                {
                    if (word == digits[j])
                    {
                        check = true;
                        break;
                    }
                }
            }

            if (check)
            {
                Console.WriteLine(str + "- Daxil edilmis string deyerinin icinde reqem var");
            }
            else
            {
                Console.WriteLine(str + " - Daxil edilmis string deyerinin icinde reqem yoxdur");
            }


            //-------------------------------------------------------------------------
            //2. Daxil edilmis string deyerinde ardicil a ve l charlarinin olub olmadigini tapan proqram.Misalcun alma, salam ve s. kimi sozlerde "vardir" yazdirmalidir geriye.

            Console.WriteLine("Bir String deyeri daxil edin:");
            string str1 = Console.ReadLine();

            char[] list = { 'a', 'l' };
            bool checks = false;

            for (int a = 0; a < str1.Length - 1; a++)
            {
                if (str1[a] == 'a' && str1[a + 1] == 'l')
                {
                    checks = true;
                    break;
                }
            }
            if (checks)
            {
                Console.WriteLine(str1 + " Sozunde ardicil a ve l herfleri vardir");
            }
            else
            {
                Console.WriteLine(str1 + " Sozunde ardicil a ve l herfleri yoxdur");
            }


            //------------------------------------------------------------------
            //3. Verilmis ededin reqemlerinin ededi ortasini tapan proqram

            var N = 55;

            var result = 0;
            var sum = 0;
            var counter = 0;
            for (int i = 0; N > 0; i++)
            {
                var digit = N % 10;
                N = (N - digit) / 10;
                sum += digit;
                counter++;
            }
            if (counter > 0) ;
            {
                result = sum / counter;
                Console.WriteLine("Result - " + result);
            }



        }
    }
}
