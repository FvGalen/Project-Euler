using System;
using System.Collections.Generic;

namespace ProjectEuler
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int numbersToFind = 10001;
            int numberToCheck = 2;
            bool primeNumber;

            if (numbersToFind != 0) {
                do
                {
                    primeNumber = true;
                    for (int i = 2; i < numberToCheck; i++)
                    {
                        if (numberToCheck % i == 0)
                        {
                            primeNumber = false;
                            numberToCheck++;
                            break;
                        }

                    }
                    if (primeNumber) {
                        numbersToFind--;
                        if (numbersToFind == 0)
                        {
                            break;
                        }
                        else
                        {
                            numberToCheck++;
                        }
                    }

                    if (numbersToFind == 0) {
                        break;
                    }
                } while (true);
            }

            Console.WriteLine($"Het 10001ste priemgetal = {numberToCheck}");
            Console.ReadKey();
        }
    }
}