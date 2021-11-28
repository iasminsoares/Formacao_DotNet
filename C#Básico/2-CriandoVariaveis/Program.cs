using System;

namespace _2_CriandoVariaveis
{
    class Program 
    {
        static void Main(string[] args)
        {
            int idade;
            idade = 32;

            idade = 10 + 5 * 2;
            Console.WriteLine(idade);

            idade = (10 + 5) * 2;
            Console.WriteLine("Sua idade é: " + idade);

            Console.WriteLine("Hello World!");
            Console.WriteLine("Execução finalizada. Tecle enter para sair....");
            Console.ReadLine();
        }
    }
}
