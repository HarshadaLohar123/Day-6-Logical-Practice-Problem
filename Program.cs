using System;

namespace FibonaccciSeries
{
    public class FibonacciSeries
    {
        public static void Main(string[] args)
        {
            //Variable Declaration
            int a = 0, b = 1, c = 0;

            Console.WriteLine("Enter the Level Number for Fibonacci Series :");
            int level = byte.Parse(Console.ReadLine());

            //Display the initial a and b values for series
            Console.WriteLine(a + "\n" + b);

            //Repeat the loop till the Level not reached
            for (int i = 1; i <= level; i++)
            {
                //generate the next number for series by adding last 2 numbers
                c = a + b;
                Console.WriteLine(c);
                //swp the numbers for generating next series number
                a = b;
                b = c;
            }

        }
    }
}
