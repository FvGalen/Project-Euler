using System;

namespace ProjectEuler
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var nummer = 0;

            for (int i = 1; i < 1000; i++)
            {
                if(i%3 == 0 || i%5 == 0){
                    nummer = nummer + i;

                }
            }
            Console.WriteLine(nummer);
        }
    }
}
