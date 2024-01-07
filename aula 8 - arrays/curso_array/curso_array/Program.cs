using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ARRAY 
            Console.WriteLine("ARRAY");
            int[] umArray= new int[5];
            umArray[0]= 1;
            umArray[1]= 3;
            umArray[2]= -7;
            umArray[3]= 19;
            umArray[4]= 0;

            Console.WriteLine("Array na posição 0 : " + umArray[0]);
            Console.WriteLine("Array na posição 1 : " + umArray[1]);
            Console.WriteLine("Array na posição 2 : " + umArray[2]);
            Console.WriteLine("Array na posição 3 : " + umArray[3]);
            Console.WriteLine("Array na posição 4 : " + umArray[4]);

            Console.WriteLine("");

            //ARRAY JÁ ATRIBUINDO VALORES
            Console.WriteLine("ARRAY JÁ ATRIBUINDO VALORES");
            int[] outroArray = { 1, 0, -2, 5, 19 };
            Console.WriteLine("Quantidade de itens do Array: " + outroArray.Length);

            for (int i = 0;  i < outroArray.Length; i++)
            {
                Console.WriteLine("Valor do indice " + i + ": " + outroArray[i]);
            }

            Console.WriteLine("");

            //ARRAY AVANÇADO LIST 
            Console.WriteLine("ARRAY AVANÇADO LIST");

            List<int> lista1 = new List<int>();
            lista1.Add(69);
            lista1.Add(24);
            lista1.Add(19);
            lista1.Add(-20);

            for (int i = 0; i < lista1.Count; i++)
            {
                Console.WriteLine("Valor do indice" + i + ": " + lista1[i]);
            }


            Console.ReadKey();
        }
    }
}
