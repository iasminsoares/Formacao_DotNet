using System;
using System.Collections.Generic;
using System.IO;


namespace projetos
{
    class BuracosTexto
    {
        static void Main(string[] args)
        {
                IDictionary<string, int> dicionarioDeBuracos = new Dictionary<string, int>() 
            {
                    {"0", 1},{"1", 0},{"2", 0},{"3", 0},{"4", 1},{"5", 0},{"6", 1},{"7", 0},{"8", 2},{"9", 1},
                    {"a", 1},{"A", 1},{"b", 1},{"B", 2},{"c", 0},{"C", 0},{"d", 1},{"D", 1},{"e", 1},{"E", 0}, 
                    {"f", 0},{"F", 0},{"g", 2},{"G", 0},{"h", 0},{"H", 0},{"i", 0},{"I", 0},{"j", 0},{"J", 0}, 
                    {"k", 0},{"K", 0},{"l", 0},{"L", 0},{"m", 0},{"M", 0},{"n", 0},{"N", 0},{"o", 1},{"O", 1},
                    {"p", 1},{"P", 1},{"q", 1},{"Q", 1},{"r", 0},{"R", 1},{"s", 0},{"S", 0},{"t", 0},{"T", 0},
                    {"u", 0},{"U", 0},{"v", 0},{"V", 0},{"w", 0},{"W", 0},{"x", 0},{"Y", 0},{"z", 0},{"Z", 0}
            };

            //Lendo o arquivo com texto, contando os digitos, palavras e buracos.
            string textoRecebido = System.IO.File.ReadAllText(@"C:\Users\Nadirlene Oliveira\OneDrive\Documentos\Meusprojetos\HMB-teste\leitura_escrita_arquivo\entrada.txt"); 
            Console.WriteLine("Arquivo aberto: {0} " , textoRecebido);
            string[] palavras = textoRecebido.Split(' ');
            int totalPalavras = palavras.Length;
            Console.WriteLine("O texto possui {0} digitos.", NumeroDeLetras(textoRecebido));
            Console.WriteLine("Total de {0} palavras: ", (totalPalavras)); 
            int buracosTexto = 0;
        
            foreach (string palavra in palavras)
            { 
                foreach (char caracter in palavra)
                {
                    if (dicionarioDeBuracos.ContainsKey(caracter.ToString()))
                    {
                        buracosTexto = buracosTexto + dicionarioDeBuracos[caracter.ToString()];
                    
                    }
                }
            }

            Console.WriteLine("Numero de buracos: " + buracosTexto);

            //GERANDO ARQUIVO CSV
            StreamWriter arquivoSaida = new StreamWriter("saida.csv");
            arquivoSaida.WriteLine("Texto: " + textoRecebido + ";" + "Total de letras: " + NumeroDeLetras(textoRecebido) + ";" + "Total de palavras: " + totalPalavras + ";" + "Total de buracos: " + buracosTexto);
            arquivoSaida.Close();
            Console.WriteLine("Arquivo Gerado");      
        }

        public static int NumeroDeLetras(string textoRecebido) {
            int contador = 0;
            for (int i = 0; i < textoRecebido.Length; i++)
            {
                if (Char.IsLetter(textoRecebido[i]))
                {
                 contador++;   
                }
            }

            return contador;
        }
    }
}

