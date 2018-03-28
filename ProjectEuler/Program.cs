using System;
using System.Collections.Generic;

namespace ProjectEuler
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            int sumOfSquare = 0;
            int squareOfSum = 0;

            for (int i = 1; i <= 100; i++)
            {
                sumOfSquare += i*i;
                squareOfSum += i;
            }

            squareOfSum *= squareOfSum;

            Console.WriteLine(squareOfSum - sumOfSquare);
            Console.ReadKey();
        }
    }
}