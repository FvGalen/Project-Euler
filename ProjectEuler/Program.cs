using System;
using System.Collections.Generic;

namespace ProjectEuler
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            int numberToCheck = 20;

            do
            {
                var succes = true;
                for (int i = 1; i <= 20; i++)
                {
                    if (numberToCheck % i != 0)
                    {
                        succes = false;
                        numberToCheck++;
                        break;
                    }
                }
                if (succes)
                    break;

            } while (true);

            Console.WriteLine(numberToCheck);
            Console.ReadKey();
        }
    }
}