using System;

namespace test_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vad heter Sveriges huvudstad?");
            string x = Console.ReadLine().ToLower();
            
            while (x != "stockholm")
            {
               
                if (x == "stokholm" || x == "stocholm")
                {
                    Console.WriteLine("Nära, försök igen");
                    x = Console.ReadLine().ToLower();
                }
                else
                {
                    Console.WriteLine("Fel, försök igen");
                    x = Console.ReadLine().ToLower();

                }
            }
            
            
                
            
            Console.WriteLine("Grattis! Du gissade rätt.");

            Console.ReadKey();
        }
    }
}