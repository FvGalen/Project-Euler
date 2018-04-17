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
            int totalIncrements = 0;
            int nextIncrement = 1;
            bool answerFound = false;

            while (!answerFound)
            {

                answer = answer + nextIncrement;
                nextIncrement++;
                totalIncrements = 0;

                for (int i = 1; i < answer ; i++)
                {
                    if (answer % i == 0)
                        totalIncrements++;

                    if (totalIncrements == 500)
                    {
                        answerFound = true;
                    }
                }

                Console.WriteLine($"current number is {answer}, current amount of increments is {totalIncrements}");
            }

            Console.WriteLine($"The answer is {answer}");
            Console.ReadKey();
        }
    }
}