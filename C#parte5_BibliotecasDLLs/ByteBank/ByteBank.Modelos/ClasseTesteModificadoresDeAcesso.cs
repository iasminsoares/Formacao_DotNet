using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    class ClasseTesteModificadoresDeAcesso
    {
        ModificadoresTeste teste = new ModificadoresTeste();
        
    }

    class ClasseDerivada : ModificadoresTeste
    {
        public ClasseDerivada()
        {
            MetodoProtegido();
        }
    }
    public class ModificadoresTeste
    {
        public void MetodoPublico()
        {
            //Visivel fora da classe "ModificadoresTeste"
        }

        private void MetodoPrivado()
        {
            //Visivel apenas na classe "ModificadoresTeste"
        }

        protected void MetodoProtegido()
        {
            //Visivel apenas na classe "ModificadoresTeste" e derivados
        }

        internal void MetodoInterno()
        {
            //Visivel apenas para a Biblioteca/Projeto ByteBank.Modelos
        }
    }
}
