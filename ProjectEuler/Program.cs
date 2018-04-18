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
            long answer = 0;

            for (int i = 1; true; i++)
            {
                int triangle = i * (i + 1) / 2;

                int factors = 0;
                for (int k = 1; k <= Math.Sqrt(triangle); k++)
                {
                    if (triangle % k == 0)
                        factors++;
                }

                factors *= 2;


                if (factors > 499)
                {
                    answer = triangle;
                    break;
                }
            }

            Console.WriteLine($"The answer is {answer}");
            Console.ReadKey();
        }
    }
}