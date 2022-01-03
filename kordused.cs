using System;
using System.Collections.Generic;
using System.Text;

namespace _03._01._22.VladEm
{
    class kordused
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int A = rnd.Next(1, 20);
            int[] massiv = new int[A];
            int E;
            for (int i = 0; i < A; i++)
            {
                E = rnd.Next(0, 10);
                massiv[i] = E;
            }
            foreach (var item in massiv)
            {
                Console.WriteLine("{0,3}", item);
            }
            Console.WriteLine();
            string[] abc = new string[5] { "A", "B", "C", "D", "E" };

            int ind = rnd.Next(0, 4);
            Console.WriteLine("Element indeksiga {0} on {1} ",ind,abc[ind]);
            int n = abc.Length;
            int j = 0;

            while (j!=0)
            {
                Console.WriteLine(abc[j]);
                j--;
            }
            Console.ReadLine();
        }
    }
}