using System;

namespace ProjectEuler
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var nummer1 = 1;
            var nummer2 = 2;

            var startnumber = 0;

            while(nummer2 < 4000000){
                if(nummer2%2 == 0){
                    startnumber = startnumber + nummer2;

                }
                var tempnummer = nummer2;
                nummer2 = nummer2 + nummer1;
                nummer1 = tempnummer;
            }
            Console.WriteLine(startnumber);
        }
    }
}
