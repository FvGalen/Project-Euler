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
            int numberInList = 0;
            int pyramidHeight = 15;
            string input = "75 95 64 17 47 82 18 35 87 10 20 04 82 47 65 19 01 23 75 03 34 88 02 77 73 07 63 67 99 65 04 28 06 16 70 92 41 41 26 56 83 40 80 70 33 41 48 72 33 47 32 37 16 94 29 53 71 44 65 25 43 91 52 97 51 14 70 11 33 28 77 73 17 78 39 68 17 57 91 71 52 38 17 14 91 43 58 50 27 29 48 63 66 04 68 89 53 67 30 73 16 69 87 40 31 04 62 98 27 23 09 70 98 73 93 38 53 60 04 23";
            string[] inputString = input.Split(' ');

            List<int> numberList = new List<int>();

            // nummers in de lijst zetten
            for (int i = inputString.Length - 1 ; i >= 0; i--)
            {
                if(inputString[i] != "")
                {
                    numberList.Add(int.Parse(inputString[i]));
                    Console.WriteLine($"added number is {inputString[i]}");
                }
            }

            //top nummer vaststellen
            int topNumber = numberList[numberList.Count - 1];

            //parameters om de onderste hoek over te slaan
            int numbersToCheck = pyramidHeight-1;
            int currentnumber = numbersToCheck;

            //hoogste van de 2 van onderaf optellen
            for (int i = pyramidHeight; true; i++)
            {

                if (numberList[numberInList] > numberList[numberInList + 1])
                {
                    numberList[i] += numberList[numberInList];
                }
                else
                {
                    numberList[i] += numberList[numberInList + 1];
                }

                numberInList++;
                currentnumber--;

                if(currentnumber == 0)
                {
                    numberInList++;
                    numbersToCheck--;
                    currentnumber = numbersToCheck;
                }


                if (topNumber != numberList[numberList.Count - 1])
                {
                    answer = numberList[numberList.Count - 1];
                    break;
                }
            }


            Console.WriteLine($"the answer is {answer}");
            Console.ReadKey();
        }
    }
}   