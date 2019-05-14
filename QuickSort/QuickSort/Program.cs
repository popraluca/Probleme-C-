using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Scrieti un program care citeste de la consola un sir de numere, 
//si apoi il afiseaza in ordine crescatoare.
namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti lungimea sirului");
            //Citirea lungimii sirului
            int lungime = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti elementele pentru sortat:");

            //Citirea datelor introduse de utilizator
            string[] intrareUtilizator = Console.ReadLine().Split(' ');

            int[] intrareSir = new int[lungime];

            for (int i = 0; i < lungime; i++)
            {
                //Asignarea datelor introduse de utilizator la sir
                intrareSir[i] = int.Parse(intrareUtilizator[i]);
            }

            QuickSort(intrareSir, 0, lungime - 1);

            Console.WriteLine("Sirul sortat: ");

            //Printarea sirului 
            for (int k = 0; k < intrareSir.Length; k++)
            {
                Console.Write(intrareSir[k] + " ");
            }
            Console.ReadLine();
        }

        static void QuickSort(int[] arr, int inceput, int final)
        {
            if (inceput < final)
            {
                //stocarea pozitiei pivotului
                int piv_pos = impartire(arr, inceput, final);

                //sortarea pana la elementul pivot
                QuickSort(arr, inceput, piv_pos - 1);

                //sortarea sirului de dupa elementul pivot
                QuickSort(arr, piv_pos + 1, final);
            }
        }
        static int impartire(int[] arr, int inceput, int final)
        {
            int i = inceput - 1;
            int piv = arr[final];
            for (int j = inceput; j <= final - 1; j++)
            {
                //aranjarea elementelor mai mici decat pivotul in partea care il precede 
                //si a elementelor mai mari decat pivotul in partea din dreapta 

                if (arr[j] <= piv)
                {
                    i++;
                    schimba(ref arr[i], ref arr[j]);
                }
            }
            schimba(ref arr[final], ref arr[i + 1]);
            return i + 1;
        }
        public static void schimba(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}



    
