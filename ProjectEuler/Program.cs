﻿using System;
using System.Collections.Generic;

namespace ProjectEuler
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<int> primeNumbers = SieveOfEranthoses.SieveOfEranthoses.FindPrimeNumbersInRange(2, 13);

            for (int i = 0; i < primeNumbers.Count; i++)
            {
                Console.WriteLine(primeNumbers[i]);
            }
            Console.WriteLine("klaar");
            Console.ReadKey();
        }
    }
}