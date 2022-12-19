using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace prime_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter first number : ");
            int k1 = int.Parse(Console.ReadLine());

            Console.WriteLine("piease enter second number : ");
            int k2 = int.Parse(Console.ReadLine());

            bool prime = true;
            Console.WriteLine("the prime number are : ");

            for (int x = k1; x <= k2; x++)
            {
                for(int y=2; y<k2; y++)

                {
                    if (x != y && x % y == 0)
                    {
                        prime = false;
                        break;
                    }
                    if (x == 1)
                        prime = false;
                }
                if (prime)
                    Console.WriteLine(x);
                prime = true;

            }
             
        }
    }
}
