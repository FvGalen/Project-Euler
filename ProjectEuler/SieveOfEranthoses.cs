using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieveOfEranthoses
{
    class SieveOfEranthoses
    {
        public static List<int> FindPrimeNumbersInRange(int _startNumber, int _endNumber)
        {
            List<int> primeNumbers = new List<int>();

            for (int i = _startNumber; i <= _endNumber; i++)
            {
                primeNumbers.Add(i);
            }

            return primeNumbers;
        }
    }
}
