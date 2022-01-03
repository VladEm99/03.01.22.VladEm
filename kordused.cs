using System;
using System.Collections.Generic;
using System.Text;

namespace _03._01._22.VladEm
{
    class kordused
    {
        static int Masiivi_suurus()
        {
            Random rnd = new Random();
            int A = rnd.Next(min, max);
            return A;
        }
        static void Main(string[] args)
        {
            int A = Massiivi_suurus(1, 20);
            int[] massiv = new int[A];
            int E;
            for (int i = 0; i < A; i++)
            {
                E = Masiivi_suurus(0, 10);
                massiv[i] = E;
            }
            foreach (var item in massiv)
            {
                Console.WriteLine("{0,3}", item);
            }
            Console.WriteLine();
            string[] abc = new string[5] { "A", "B", "C", "D", "E" };

            int ind = Masiivi_suurus(0, 4);
            Console.WriteLine("Element indeksiga {0} on {1} ",ind,abc[ind]);
            int n = abc.Length;
            int j = 0;

            while (j!=abc.Length)
            {
                Console.WriteLine(abc[j]);
                j++;
            }
            A = Masiivi_suurus(3, 12); //read
            E = Masiivi_suurus(3, 12); //kohad
            int[,] tabel = new int[A, E];
            //int[,] tabel2 = new int[,] { };
            for (int i = 0; i < length; i++)
            {
                for (int y = 0; y < length; y++)
                {
                    tabel[i, y] = Masiivi_suurus(-10, 10);
                }
            }
            for (int i = 0; i < length; i++)
            {
                for (int y = 0; y < length; y++)
                {
                    Console.Write("0,4", tabel[i, y]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}