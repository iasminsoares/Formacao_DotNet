// using _05_ByteBank;

namespace _06_ByteBank
{
    public class ContaCorrente
    {

        public Cliente Titular
        {
            get; set;
            //O compilador encontrou a construção de Titular, em ContaCorrente, e se deparou com ponto e vírgula (;) em vez de chaves ({}) após get e set.
            //Com isso, percebeu que não há lógica envolvida. Então, por baixo dos panos, ele cria o método GetTitular() e o campo _titular.
            // Ou seja, executa o mesmo comportamento, com uma construção muito mais limpa.
            //Inclusive, quando temos esse tipo de estrutura, somente com o nome da propriedade, get e set, colocamos todos na mesma linha.
        }

        public int Agencia { get; set; }
        public int Numero { get; set; }
        
        private double _saldo = 100; //campo privado saldo

        public double Saldo
        {
            get // irá sempre retornar o saldo
            {
                return _saldo;
            }
            set // definir o valor do saldo da propriedade da classe e nome do argumento é o value
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }
        //public void SetSaldo(double saldo)//saldo argumento
        //{
        //    if (saldo < 0) //qnd escreve somente o saldo sem mais nada ele verifica o saldo argumento
        //    {
        //        return;
        //    }
            
        //    this.saldo = saldo; //como acontece a colisão de nomes, o this acessa o objeto campo, então ele recebe o argumento 
            
        //}
        //public double GetSaldo() //método
        //{
        //    return saldo;
        //}

        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }


        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}
