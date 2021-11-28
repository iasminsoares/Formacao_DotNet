using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionarios
{
    public class Diretor :  FuncionarioAutenticavel // diretor herda as funções da classe funcionário
    {
       public Diretor(string cpf) : base(5000,cpf)
        {
            Console.WriteLine("Criando DIRETOR");
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
        public override double GetBonificacao() //sobre escrevendo o comportamento de funcionário
        {
            return Salario * 0.5;
        }
    }
}
