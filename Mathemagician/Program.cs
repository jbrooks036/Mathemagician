using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathemagician
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I am the Mathemagician");
            Console.WriteLine("What shall I math? \nFibonacci, Primes, or Integers");
            string desiredMaths = Console.ReadLine();
            Console.WriteLine("Ok.  I'm gonna do some " + desiredMaths);
            if ("Integers" == desiredMaths)
            {
                PrintIntegers();
            }
            else if ("Fibonacci" == desiredMaths)
            {
                PrintFibonacciSequence();
            }
            else if ("Primes" == desiredMaths)
            {
                PrintPrimes();
            } else
            {
                Console.WriteLine("Well, Actually...  I lied...");
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        private static void PrintPrimes()
        {
            // 2, 3, 5, 7, 11, 13, 17, ...
            List<int> primesList = new List<int>();
            primesList.Add(2);
            Console.WriteLine(2);
            int i = 3;
            bool prime;

            while (true)
            {
                prime = true;

                foreach (int p in primesList)
                {
                    if (i % p == 0)
                    {
                        prime = false;
                        break;
                    }
                }

                if (prime)
                {
                    Console.WriteLine(i);
                    primesList.Add(i);
                    System.Threading.Thread.Sleep(300);
                }
                i++;
            }
        }

        private static void PrintFibonacciSequence()
        {
            // 1, 1, 3, 5, 8, 13, ...
            int prev = 0;
            int current = 1;
            while (true)
            {
                Console.WriteLine(current);
                System.Threading.Thread.Sleep(100);
                int newValue = prev + current;
                prev = current;
                current = newValue;
            }
        }

        private static void PrintIntegers()
        {
            // 1, 2, 3, 4, 5, ...
            int nextInteger = 0;

            while (true)
            {
                nextInteger++;
                Console.WriteLine(nextInteger);
                System.Threading.Thread.Sleep(100);
            }
        }
    }
}
