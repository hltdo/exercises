using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 15. Prime numbers
Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.
 */
class PrimeNumbers
{
    static void Main(string[] args)
    {
        int n = 10000000;
        bool [] array = new bool [n];
        int sqrt = (int)Math.Sqrt(n);
        int length = array.Length;

        //Set all values to true
        for (int i = 0; i < length; i++)
        {
            array[i] = true;
        }

        //Set those numbers that are not prime to false
        for (int i = 2; i <= sqrt; i++)
        {
            if (array[i]==true)
            {
                for (int j = i*i; j < length; j=j+i)
                {
                    array[j] = false;
                }
            }
        }

        //Print only values that are true(prime numbers)
        for (int i = 2; i < length; i++)
        {
            if (array[i] == true)
            {
                Console.Write("{0} ", i);
            }
        }

    }
}

