using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Scrieti un program care accepta de la utilizar doua numere, si afiseaza toate numerele intre ele. 
 * Daca primul numar e mai mic decat al doilea, numerele afisate vor fi in ordine crescatoare. 
 * Daca primul numar e mai mare ca l doilea, numerele afisate for fi in ordine descrescatoare.

La problema precedenta, afisati doar fiecare al doilea numar.*/


namespace AfisareIntervalNumereSelectiv
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Acest program va afisa un interval de numere:");
            Console.WriteLine("Primul numar: ");
            int primul = int.Parse(Console.ReadLine());

            Console.WriteLine("Al doilea numar: ");
            int ultimul = int.Parse(Console.ReadLine());

            if (primul < ultimul)
            {
                crescator(primul, ultimul);
            }
            else if (primul == ultimul)
            {
                Console.WriteLine(primul);
            }
            else
                descrescator(primul, ultimul);



            Console.ReadKey();
        }


        public static void crescator(int primul, int ultimul)
        {
            int k = 0;
            for (int i = primul; i <= ultimul; i++)
            {
                if (k % 2 != 0)
                Console.Write($" {i}");
                k++;
            }
        }

        public static void descrescator(int primul, int ultimul)
        {
            int k = 0;
            for (int i = primul; i >= ultimul; i--)
            {
                if (k%2 != 0)
                Console.Write($" {i}");
                k++;
            }
        }
    }
}
