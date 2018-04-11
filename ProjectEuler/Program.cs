using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            long sumOfPrimes = 0;

            List<int> primeNumberList = new List<int>();

            primeNumberList = PrimeNumbers.PrimeNumbers.FindPrimeNumersInRange(2, 2000000);

            for (int i = 0; i < primeNumberList.Count ; i++)
            {
                sumOfPrimes += primeNumberList[i];
            }

            Console.WriteLine($"het antwoord is {sumOfPrimes}");
            Console.ReadKey();
        }


    }
}