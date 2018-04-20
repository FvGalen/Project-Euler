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
            int offset = 'A' - 1;
            WebClient wc = new WebClient();
            string raw = wc.DownloadString("https://projecteuler.net/project/resources/p022_names.txt");
            string[] inputstring = raw.Split(',').Select(s=>s.Trim('"')).OrderBy(s=>s).ToArray();

            int answer = inputstring.Select(name => name.Sum(c => c - offset)).Select((valueOfName, i) => valueOfName * (i + 1)).Sum();

            Console.WriteLine($"answer is {answer}");
            Console.ReadKey();

        }

    }
}

