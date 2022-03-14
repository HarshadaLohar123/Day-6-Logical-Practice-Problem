using System;

namespace PrimeNo
{
    internal class PrimeNumber
    {
        public static void Main(string[] args)
        {
            int n, temp = 1;

            Console.WriteLine("Enter Any Number :");
            n = int.Parse(Console.ReadLine());

            //if value of n is not 1 then check for the prime no because 1 is already prime
            if (n != 1)
            {
                for (int i = 2; i <= n - 1; i++)
                {
                    if (n % i == 0)
                    {
                        temp = 0;
                        break;
                    }
                }
            }

            //Checking for the Flag Variable Value is match or not
            if (temp == 1)
            {
                Console.WriteLine(n + " is Prime Number");
            }
            else
            {
                Console.WriteLine(n + " is Not Prime Number");
            }

        }
    }
}
