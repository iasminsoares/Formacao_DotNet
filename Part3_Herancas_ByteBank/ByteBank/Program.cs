using ByteBank.Funcionarios;
using ByteBank.Sistemas;
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //CalcularBonificacao();
            UsarSistema();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();
            Diretor yane = new Diretor("120.492.736-73");
            yane.Nome = "Yane";
            yane.Senha = "123";

            GerenteDeConta nadirlene = new GerenteDeConta("326.985.628-89");
            nadirlene.Nome = "Nadirlene";
            nadirlene.Senha = "abc";

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "123456";

            sistemaInterno.Logar(parceiro, "123456");
            sistemaInterno.Logar(yane, "123");
            sistemaInterno.Logar(nadirlene, "abc");

            
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Funcionario rayza = new Designer("833.222.048-48");
            rayza.Nome = "Rayza";

            Funcionario yane = new Diretor("120.492.736-73");
            yane.Nome = "Yane";

            Funcionario juliana = new Auxiliar("981.198.778.53");
            juliana.Nome = "Juliana";

            Funcionario nadirlene = new GerenteDeConta("326.985.628-89");
            nadirlene.Nome = "Nadirlene";
            Desenvolvedor iasmin = new Desenvolvedor("456.175.468-78");
            iasmin.Nome = "Iasmin";


            gerenciadorBonificacao.Registrar(iasmin);
            gerenciadorBonificacao.Registrar(rayza);
            gerenciadorBonificacao.Registrar(yane);
            gerenciadorBonificacao.Registrar(juliana);
            gerenciadorBonificacao.Registrar(nadirlene);

            Console.WriteLine("Total de bonificações do mes " + gerenciadorBonificacao.GetTotalBonificacao());
        }
    }
}
