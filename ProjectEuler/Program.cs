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
            int index = 3;
            BigInteger oldAnswer = 1;
            BigInteger newAnswer = 2;

            while (newAnswer <= BigInteger.Pow(10,999))
            {
                BigInteger temp = newAnswer;
                newAnswer += oldAnswer;
                oldAnswer = temp;
                index++;
            }
                

            Console.WriteLine($"het nummer is {newAnswer}, het index nummer is {index}");
            Console.ReadKey();

        }

    }
}

