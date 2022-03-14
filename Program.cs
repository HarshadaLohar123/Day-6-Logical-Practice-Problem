using System;

namespace PerfectNumber
{
    public class PerfectNo
    {
        public static void Main(string[] args)
        {
            int n, sum = 0;

            Console.WriteLine("Enter Any Number :");
            n = int.Parse(Console.ReadLine());

            //Repeat the loop till the number is reached
            for (int i = 1; i < n; i++)
            {
                //Checking for the Devisor of n
                if (n % i == 0)
                {
                    sum = sum + i;
                    Console.WriteLine(i + " is Devisor and Sum : " + sum);
                }
            }

            //Checking for Sum of all devisor are same as given Number
            if (sum == n)
            {
                Console.WriteLine(n + " is Perfect Number");
            }
            else
            {
                Console.WriteLine(n + " is Not Perfect Number");
            }

        }
    }
}
