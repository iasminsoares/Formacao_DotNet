using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5_CaracteresETexto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Caracteres e textos ");

            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);

            //char é uma variavel de até 16bits
            primeiraLetra = (char)61; //convertendo int pra char
            Console.WriteLine(primeiraLetra);
 
            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);
 
            string titulo = "Alura Cursos de tecnologia " + 2020;
            Console.WriteLine(titulo);

            string cursosProgramacao = " - .NET" + " - Java " + "- JavaScript";

            Console.WriteLine("Execução finalizada. Tecle enter para sair....");
            Console.ReadLine();
        }
    }
}
