using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Estrutura condicional 
            Console.WriteLine("Estrutura Condicional");
            bool ok = true;

            if (ok)
            {
                Console.WriteLine("O valor é true.");
            } else
            {
                Console.WriteLine("O valor é false.");
            }


            Console.WriteLine("");

            string name = "Jucinei";
            string lastName = "Belo";

            if (name == "Jucinei" && lastName == "Belo")
            {
                Console.WriteLine("Seu nome é : " + name + " " + lastName);
            } else
            {
                Console.WriteLine("Seu nome é um mistério!");
            }


            Console.WriteLine("");
            //CONTROLE DE FLUXO - SWITCH
            Console.WriteLine("CONTROLE DE FLUXO - SWITCH");
            ok = true;

            switch(!ok)
            {
                case true: 
                    Console.WriteLine("ok é verdadeiro");
                    break;
                case false: 
                    Console.WriteLine("ok é falso");
                    break;
                default: 
                    Console.WriteLine("ok é indefinido");
                    break;
            }


            Console.WriteLine("");
            //ESTRUTURA DE REPETIÇÃO WHILE
            Console.WriteLine("ESTRUTURA DE REPETIÇÃO WHILE");
            int i = 1;

            while(i <= 10)
            {
                Console.WriteLine("O valor de i é de: " + i++);
            }


            Console.WriteLine("");
            //ESTRUTURA DE REPETIÇÃO DO WHILE
            Console.WriteLine("ESTRUTURA DE REPETIÇÃO DO WHILE");
            i = 1;
            do
            {
                Console.WriteLine("O valor de i é de: " + i++);
            } while (i <= 10);


            Console.WriteLine("");
            //ESTRUTURA DE REPETIÇÃO FOR
            Console.WriteLine("ESTRUTURA DE REPETIÇÃO FOR");

            for ( int x = 1;  x <= 10; x++)
            {
                Console.WriteLine("O valor de i é: " + x);
            }

            Console.ReadKey();

        }
    }
}
