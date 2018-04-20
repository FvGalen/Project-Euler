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
            Stopwatch stopwatch = new Stopwatch();

            int answer = 0;
            int startNumber = 100;
            BigInteger number = 1;
            string stringNumber;
            

            for (int i = startNumber; i > 0; i--)
            {
                number *= i;
            }

            stringNumber = number.ToString();

            var arr = stringNumber.ToCharArray();

            for (int i = 0; i < arr.Length; i++)
            {
                answer += int.Parse(arr[i].ToString());
            }


            stopwatch.Stop();

            Console.WriteLine($"the answer is {answer}, it took {stopwatch.ElapsedTicks} ticks");
            Console.ReadKey();
        }
    }
}

