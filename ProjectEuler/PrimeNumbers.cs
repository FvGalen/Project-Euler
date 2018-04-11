using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class PrimeNumbers
    {
        public static List<int> FindPrimeNumersInRange(int _startNumber, int _endNumber)
        {
            bool isPrime = false;

            List<int> primeNumbersInRange = new List<int>();

            if (_startNumber <= 2)
                primeNumbersInRange.Add(2);

            if (_startNumber % 2 == 0)
                _startNumber++;

            

            for (int i = _startNumber; i <= _endNumber; i += 2) {
                isPrime = true;

                for(int j = 3; j * j <=i; j += 2)
                {
                    if ((i % j == 0))
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                    primeNumbersInRange.Add(i);
            }

            return primeNumbersInRange;

        }

    }
}
