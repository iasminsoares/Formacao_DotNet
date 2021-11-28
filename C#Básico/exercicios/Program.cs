using System;

namespace exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programa onde o usuario insere 3 notas e o sisterma calcula a média das notas.
            
            double nota1, nota2, nota3;
            double mediaNotas;
            
            Console.WriteLine("Digite a primeira nota?");
            nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota?");
            nota2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota?");
            nota3 = Convert.ToDouble(Console.ReadLine());

            mediaNotas = (nota1 + nota2 + nota3) / 3;
            
            
            Console.WriteLine("A média de notas é: " + mediaNotas.ToString("F"));
            Console.ReadKey();
            
        }
    }
}
