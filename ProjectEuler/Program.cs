using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
            List<int> abundandNumberList = new List<int>();
            bool[] booleanList = new bool[28122];

            for (int i = 1; i < 28123; i++)
            {
                int tempAnswer = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        tempAnswer += j;
                    }
                }

                if (tempAnswer > i)
                {
                    abundandNumberList.Add(i);
//                  Console.WriteLine($"{i} is an abundand number");
                }
            }

            for (int i = 0; i < abundandNumberList.Count; i++)
            {
                for (int j = i; j < abundandNumberList.Count; j++)
                {
//                  Console.WriteLine($"{abundandNumberList[i]} + {abundandNumberList[j]} = {abundandNumberList[i] + abundandNumberList[j]}");
                    if(abundandNumberList[i] + abundandNumberList[j] < 28123)
                        booleanList[(abundandNumberList[i] + abundandNumberList[j])-1] = true;
                }
            }

            for (int i = 0; i < booleanList.Length; i++)
            {
                if (booleanList[i] == false)
                {
                    Console.WriteLine($"{i+1} isn't a sum of 2 abundand numbers");
                    answer += i + 1;
                }
            }

            Console.WriteLine($"answer is {answer}");
            Console.ReadKey();

        }

    }
}

