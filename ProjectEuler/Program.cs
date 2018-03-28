using System;
using System.Collections.Generic;

namespace ProjectEuler
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int answer = 0;

            for (int x = 1; x < 1000; x++)
            {
                for (int y = 1; y < 1000; y++)
                {
                    for (int z = 1; z < 1000; z++)
                    {
                        if(x+y+z == 1000 && x*x + y*y == z * z)
                        {
                            answer = x * y * z;
                        }
                    }
                }
            }

            Console.WriteLine(answer);
            Console.ReadKey();
        }
    }
}