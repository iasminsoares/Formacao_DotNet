using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dataFimPagamento = new DateTime(2018, 8, 17);
            // Data corrente no momento de execução do código
            DateTime dataCorrente = DateTime.Now;
            TimeSpan diferenca = dataFimPagamento - dataCorrente;

            string mensagem = "Vencimento em " + TimeSpanHumanizeExtensions.Humanize(diferenca);

            Console.WriteLine(mensagem);
            //DateTime dataFimPagamento = new DateTime(2022, 06, 1);
            //DateTime dataAtual = DateTime.Now;

            //TimeSpan diferencaDeDatas = dataFimPagamento - dataAtual;

            //string mensagem = "Vencimento em: " + TimeSpanHumanizeExtensions.Humanize(diferencaDeDatas);

            //Console.WriteLine(mensagem);
            Console.ReadLine(); 
            //ContaCorrente conta = new ContaCorrente(847, 489754);
            
            //Console.WriteLine(conta.Numero);


            //FuncionarioAutenticavel carlos = null;
            //carlos.Autenticar("ijdiejijdijde");

        }

    }
}
