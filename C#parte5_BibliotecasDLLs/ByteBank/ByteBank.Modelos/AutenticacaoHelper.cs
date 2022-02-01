using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    internal class AutenticacaoHelper //internal faz com que a classe Helper seja visivel somente dentro da Biblioteca Modelos
    {
        public bool CompararSenhas(string senhaVerdadeira, string senhaTentativa)
        {
            
            return senhaVerdadeira == senhaTentativa;
        }
    }
}
