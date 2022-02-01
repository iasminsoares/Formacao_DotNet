using System;
using System.Collections.Generic;
using System.Text;

namespace _07_ByteBank
{
   public class SaldoInsuficienteException : Exception
    {
        public SaldoInsuficienteException()
        {

        }
        public SaldoInsuficienteException (string mensagem) : base(mensagem)
        {

        }
    }
}
