using System;
using System.Collections.Generic;

namespace ProjectEuler
{
    class MainClass
    {
        public static void Main(string[] args)
        {
           int answer = 0;
           int answerx = 0;
           int answery = 0;

            for (int x = 100; x < 1000; x++)
            {
                for (int y = 100; y < 1000; y++)
                {
                    int sum = x * y;
                    if(sum.ToString() == Reverse(sum.ToString()) && sum > answer){
                        answer = sum;
                        answerx = x;
                        answery = y;
                    }
                }
            }

            Console.WriteLine(answerx + " * " + answery + " = " + answer);
            Console.ReadKey();
        }

        static string Reverse (string _input) {
            var arr = _input.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}