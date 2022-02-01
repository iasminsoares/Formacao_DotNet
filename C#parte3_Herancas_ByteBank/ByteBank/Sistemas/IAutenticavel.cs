using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Sistemas
{
    public interface IAutenticavel 
    {
        public bool Autenticar(string senha); //continua sendo um método
     
    }
}
