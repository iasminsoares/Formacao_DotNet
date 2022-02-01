using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class OperacaoFinanceiraException : Exception //toda exception deve herdar o tipo
    {
        public OperacaoFinanceiraException() //construtor sem argumentos
        {

        }

        public OperacaoFinanceiraException(string mensagem) //construtor com argumentos
            : base(mensagem) //enviando a mensagem pra classe base
        {

        }

        public OperacaoFinanceiraException(string mensagem, Exception excecaoInterna)
            :base(mensagem, excecaoInterna)
        {

        }


    }
}
