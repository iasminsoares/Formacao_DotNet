using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacao_Desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tb_entradaTexto_TextChanged(object sender, EventArgs e)
        {
            string textoRecebido = tb_entradaTexto.Text;

            //Array contendo as palavras do texto digitado pelo usuário
            string[] palavras = textoRecebido.Split(' ');

            //Cálculo da quantidade de palavras no array
            int totalPalavras = palavras.Length;
            tb_quantidade_palavras.Text = totalPalavras.ToString();

            //Quantidade de caracter calculado com a função NumeroDeCaracter
            tb_quantidade_caracter.Text = Convert.ToString((NumeroDeCaracter(textoRecebido)));

            //Função que calcula o numero de Caracteres no texto
            static int NumeroDeCaracter(string textoRecebido)
            {
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

            
                IDictionary<string, int> dicionarioDeBuracos = new Dictionary<string, int>()
            {
                    {"0", 1},{"1", 0},{"2", 0},{"3", 0},{"4", 1},{"5", 0},{"6", 1},{"7", 0},{"8", 2},{"9", 1},
                    {"a", 1},{"A", 1},{"b", 1},{"B", 2},{"c", 0},{"C", 0},{"d", 1},{"D", 1},{"e", 1},{"E", 0},
                    {"f", 0},{"F", 0},{"g", 2},{"G", 0},{"h", 0},{"H", 0},{"i", 0},{"I", 0},{"j", 0},{"J", 0},
                    {"k", 0},{"K", 0},{"l", 0},{"L", 0},{"m", 0},{"M", 0},{"n", 0},{"N", 0},{"o", 1},{"O", 1},
                    {"p", 1},{"P", 1},{"q", 1},{"Q", 1},{"r", 0},{"R", 1},{"s", 0},{"S", 0},{"t", 0},{"T", 0},
                    {"u", 0},{"U", 0},{"v", 0},{"V", 0},{"w", 0},{"W", 0},{"x", 0},{"Y", 0},{"z", 0},{"Z", 0}
            };


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
                        
                tb_quantidade_buracos.Text = buracosTexto.ToString();
        }

         private void tb_quantidade_palavras_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
