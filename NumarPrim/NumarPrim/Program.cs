using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Afisati la consola numerele prime pana la 100. 
//(Numerele prime sunt acele care se impart fara rest la 1 si la ele insusi).

namespace NumarPrim
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Introduceti valoarea pana la care vreti afisarea numerelor prime:");
            //in cazul nostru 100
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Prime Numbers : ");
            NumarPrim(n);
            
            Console.ReadKey();
        }

        //Metoda pt verificarea si afisarea numerelor prime
        public static void NumarPrim(int n)
        {

            bool estePrim = true;
            for (int i = 2; i <= n; i++)
            {
                for (int j = 2; j <= n; j++)
                {

                    if (i != j && i % j == 0)
                    {
                        estePrim = false;
                        break;
                    }

                }
                if (estePrim)
                {
                    Console.Write("  " + i);
                }
                estePrim = true;
            }
        }

       
    }
}
