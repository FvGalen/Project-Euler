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
            int answer = 0;
            BigInteger number = BigInteger.Pow(2,1000);
            string numberToString = number.ToString();

            var arr = numberToString.ToCharArray();

            for (int i = 0; i < arr.Length; i++)
            {
                
                answer += int.Parse(arr[i].ToString());
            }

            Console.WriteLine($"{answer}");
            Console.ReadKey();
        }
    }
}   