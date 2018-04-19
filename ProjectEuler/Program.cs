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
            int gridSize = 20;
            BigInteger possibilities = 1;

            for (int i = 0; i < gridSize; i++)
            {
                possibilities *= (2 * gridSize) - i;
                possibilities /= i + 1;
            }

            Console.WriteLine($"The number of possibilities is {possibilities}");
            Console.ReadKey();
        }
    }
}   