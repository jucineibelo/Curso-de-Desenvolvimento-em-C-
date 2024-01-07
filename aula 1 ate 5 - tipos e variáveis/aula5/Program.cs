using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula5
{
    class Program
    {
        static string testeBooleano = "O valor booleano é: ";
        static bool ok = true;
        static bool notOk = !ok;

        static void Main(string[] args)
        {
            //TESTANDO BOOLEANO
            Console.WriteLine("TESTANDO BOOLEANO");
            Console.WriteLine(testeBooleano + ok);
            Console.WriteLine(testeBooleano + notOk);

            //TESTANDO INCREMENTO E DECREMENTO EM INTEIRO
            Console.WriteLine("TESTANDO INCREMENTO E DECREMENTO EM INTEIRO");
            int y = 5; 
            Console.WriteLine("y incremento pré fixado " + ++y);
            Console.WriteLine("y incremento pós fixado " + y++); // aqui o incremento não aparece por ser pós fixado na proxima vez que chamar a variavel vai chamar com esse incremento 
            Console.WriteLine("y aqui aparece o incremento anterior porque é pós fixado " + y);

            y = 15;
            Console.WriteLine("y decremento pré fixado " + --y);
            Console.WriteLine("y decremento pós fixado " + y--);
            Console.WriteLine("y aqui aparece o decremento anterior porque é pós fixado " + y);

            //TESTANDO CAST -> ()
            Console.WriteLine("TESTANDO CAST");
            double x = 10;
            int j =(int) x;
            Console.WriteLine("x: " + x + " j: " + j);

            //OPERADOR ARITMETICO - RESTO DA DIVISÃO 
            Console.WriteLine("OPERADOR ARITMETICO - RESTO DA DIVISÃO");
            int num = 10;

            if (num%2 != 0)
            {
                Console.WriteLine("num = "+ num + " é impar");
            } else {
                Console.WriteLine("num = "+ num + "  é par");
            }

            //OPERADORES DE COMPARAÇÃO 
            Console.WriteLine("OPERADORES DE COMPARAÇÃO");
            x = 18;
            y = 20;

            if (x > y)
            {
                Console.WriteLine(" X é maior que Y");
            } else if (y > x)
            {
                Console.WriteLine("Y é maior que X");
            } else if (x == y) 
            {
                Console.WriteLine("X é igual a Y");
            }

            //OPERADOR DE ATRIBUIÇÃO = += -= *= /= %=
            Console.WriteLine("OPERADOR DE ATRIBUIÇÃO");

            x = 10;
            y = 50;

            x *= 3;
            y -= 40;
            Console.WriteLine("O valor de x é: " + x);
            Console.WriteLine("O valor de y é: " + y);

            //OPERADOR DE TERNARIO
            Console.WriteLine("OPERADOR DE TERNARIO");
            int c = 10;
            int e = 12;
            int d = c > e ? c : e;
            Console.WriteLine("se c é maior que e então d recebe c, senão d recebe e. A resposta é: " + d);

            Console.ReadKey();

        }
    }
}
