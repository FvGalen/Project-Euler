using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ProjectEuler
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            long answer = 0;
            long chainsAnswer = 0;
            long currentNumber;
            long currentChain;

            for (int i = 1; i < 1000000; i++)
            {
                currentNumber = i;
                currentChain = 0;

                while (currentNumber != 1)
                {
                    if (currentNumber % 2 == 0)
                    {
                        currentNumber /= 2;
                    }
                    else
                    {
                        currentNumber = currentNumber * 3 + 1;
                    }

                    currentChain++;
                }

                if (chainsAnswer <= currentChain)
                {
                    answer = i;
                    chainsAnswer = currentChain;
                }

            }

            Console.WriteLine($"The answer is {answer} with {chainsAnswer}");
            Console.ReadKey();
        }
    }
}