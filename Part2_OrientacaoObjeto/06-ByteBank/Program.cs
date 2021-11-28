using System;

namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente conta = new ContaCorrente();
            Cliente cliente = new Cliente();

            cliente.Nome = "Nadirlene";
            cliente.CPF = "789.852.369.12";
            cliente.Profissao = "Desenvolvedora";

            conta.Titular = cliente; // atribuindo a referencia do cliente pra conta
            conta.Saldo = -10; //set
            //conta.SetSaldo(-10);

            Console.WriteLine(conta.Titular.Nome);
            Console.WriteLine(conta.Saldo);
            //Console.WriteLine(conta.GetSaldo());
        }
    }
}
