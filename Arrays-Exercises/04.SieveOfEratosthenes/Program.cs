using System;
using System.Runtime.InteropServices;

namespace _04.SieveOfEratosthenes
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            bool[] primes = new bool[n + 1];
            for (int i = 0; i < primes.Length; i++)
            {
                primes[i] = true;
            }

            primes[0] = primes[1] = false;

            for (int i = 2; i <= n; i++)
            {
                if (primes[i])
                {
                    for (int j = i * i; j <= n; j += i)
                    {
                        primes[j] = false;
                    }
                }
            }

            for (int i = 2; i <= n; i++)
            {
                if (primes[i])
                    Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}

