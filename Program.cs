using System;

namespace _03._01._22.VladEm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string eesnimi = Console.ReadLine();
            Console.WriteLine("Tere, " + eesnimi.ToUpper());
            if (eesnimi.ToLower() == "jukku") 
            {
                Console.WriteLine("Lähme kinno", eesnimi);
                int vanus = int.Parse(Console.ReadLine());
                double hind = 6.50;
                string pilet;
                if (vanus < 0 || vanus > 120)
                {
                    Console.WriteLine("Viga vanusega!");
                }
                else
                {
                    if (vanus < 6)
                    {
                        Console.WriteLine("Suur allahindlus!");
                        hind *= 0.5;
                    }
                    else
                    {
                        Console.WriteLine("Täis hind!");
                    }
                    Console.ReadLine();
                }
            }
            /*Console.ReadLine();
            int arv1 = int.Parse(Console.ReadLine());
            int arv2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Arvude {1} ja {0} korrutis võrdub {2}",arv1, arv2, arv1 * arv2);*/
        }
    }
}
