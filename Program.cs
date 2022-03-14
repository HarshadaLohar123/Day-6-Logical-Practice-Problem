using System;

namespace ReverseNo
{
    internal class ReverseNumber
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Enter Any Number :");
            n = int.Parse(Console.ReadLine());

            //Repeat the loop till n greater than 0
            while (n > 0)
            {
                //Get the Last digit of Number by MOD
                int r = n % 10;
                Console.WriteLine(r);
                //Delete the Last Digit
                n = n / 10;
            }

        }
    }
}
