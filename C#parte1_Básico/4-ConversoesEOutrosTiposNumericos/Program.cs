using System;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 4 ");

            double salario = 1900.85;
            Console.WriteLine(salario);

            //int é uma variavel de até 32bits
            int salarioEmInteiro = (int)salario; //convertendo double pra inteiro
            Console.WriteLine(salarioEmInteiro);

            //long é uma variavel até 64bits 
            long idade = 130000000000000;
            Console.WriteLine(idade);

            //long é uma variavel até 16bits 
            short qtd  = 13000;
            Console.WriteLine(qtd);

            float altura = 1.80f;
            Console.WriteLine(altura);

            Console.WriteLine("Execução finalizada. Tecle enter para sair....");
            Console.ReadLine();
        }
    }
}
