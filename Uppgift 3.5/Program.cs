using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hur gammal är du? : ");
            int ålder = Convert.ToInt32(Console.ReadLine());
            


            Console.WriteLine("Hur mycket tjänar du i månaden? : ");
            int lön = Convert.ToInt32(Console.ReadLine());  

            if (ålder > 39)
            {
                Console.WriteLine("Du är äldre än Göteborgs medelålder");
            }

            if (ålder == 39)
            {
                Console.WriteLine("Du är lika gammal som Göteborgs medelålder");
            }

            if (ålder < 39)
            {
                Console.WriteLine("Du är yngre än Göteborgs medelålder");
            }

            if (lön > 36100)
            {
                Console.WriteLine("Du har högre lön än Göteborgs medellön");
            }

            if (lön == 36100)
            {
                Console.WriteLine("Du har samma lön som Göteborgs medellön");
            }

            if (lön < 36100)
            {
                Console.WriteLine("Du har lägre lön än Göteborgs medellön");
            }

        }
    }
}
