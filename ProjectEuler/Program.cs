﻿using System;
using System.Collections.Generic;

namespace ProjectEuler
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            long sumOfPrimes = 0;
            long numberToCheck = 2;
            bool primeNumber;

            do
            {
                if (numberToCheck > 2000000)
                    break;

                if(numberToCheck % 100000 == 0)
                    Console.WriteLine($"sum of primes is: {sumOfPrimes} when the number to check is {numberToCheck}");

                primeNumber = true;
                for (int i = 2; i < numberToCheck; i++)
			    {
                    if(numberToCheck % i == 0){
                        primeNumber = false;
                        numberToCheck ++;
                        break;
                     }
                }
                
                if(primeNumber){
                    sumOfPrimes += numberToCheck;
                    numberToCheck++;
                }


	        } while (true);

            Console.WriteLine($"sum of primes is: {sumOfPrimes}");
            Console.ReadKey();
        }
    }
}