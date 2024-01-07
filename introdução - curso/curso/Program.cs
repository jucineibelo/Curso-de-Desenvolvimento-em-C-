using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso //nome principal do projeto
{
    class Program
    {
        static int qtde = 10;
        static string valor = "meu valor: ";

        static void Main(string[] args)
        {
            Console.WriteLine(valor + qtde);
            qtde = (qtde + 10) + (20 - 10);
            Console.WriteLine(valor + qtde);
            Console.ReadKey();
        }
    }
}
