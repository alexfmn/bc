
using System;

namespace BC
{
    class Program
    {
        static void Main(string[] args)
        {
            if ( args.Length == 0 )
            {
                Console.WriteLine("No number provided!");
                return;
            }

            int number = 0;
            number = int.Parse(args[0]);
            Console.WriteLine("The number you gave is " + number);


            string result = Convert(number);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }

        static string Convert(number);
        {
        int[] digits = new int[32];
        int i = 0;

        while (number / 2 >= 1)
        {
            int remainder = number % 2;
            digits[i] = remainder;
            number = number / 2;
            i = i + 1;
        }
        digits[i] = number;

        string result = "";

        while (i >= 0)
        {
            result = result + digits[i];
            i = i - 1;
        }
        return result;
    }
}
