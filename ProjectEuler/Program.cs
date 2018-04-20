using System;
using System.Diagnostics;
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
            int answer = 0;
            int numbersToCheck = 10000;

            Stopwatch stopwatch = new Stopwatch();

            for (int a = 0; a < numbersToCheck; a++)
            {
                int B = SumOfFactors(a);

                if(SumOfFactors(B) == a && a != B) {
                    answer += a;
                }
            }            
            
            stopwatch.Stop();

            Console.WriteLine($"answer is {answer}");
            Console.ReadKey();

        }

        private static int SumOfFactors (int _int)
        {
            int sum = 0;
            for (int i = 1; i < _int; i++)
            {
                if(_int % i == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }

    }
}

