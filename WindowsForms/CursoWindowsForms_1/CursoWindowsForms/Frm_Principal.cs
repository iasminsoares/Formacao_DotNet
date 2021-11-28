using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void Btn_DemonstracaoKey_Click(object sender, EventArgs e) //instanciando a classe do formulario para ser inicializado na tela
        {
            Frm_Demonstracao fDemonstracao = new Frm_Demonstracao();
            fDemonstracao.ShowDialog(); //é um método da classe Forms q vem do .NET q abre um formulario na frente do outro.
        }

        private void Btn_HelloWord_Click(object sender, EventArgs e)
        {
            Frm_HelloWorld fHelloWord = new Frm_HelloWorld();
            fHelloWord.ShowDialog();
        }

        private void Btn_Mascara_Click(object sender, EventArgs e)
        {
            Frm_Mascara fMascara = new Frm_Mascara();
            fMascara.ShowDialog();
        }

        private void Btn_ValidaCPF_Click(object sender, EventArgs e)
        {
            Frm_ValidaCPF fValidaCPF = new Frm_ValidaCPF();
            fValidaCPF.ShowDialog();
        }

        private void Btn_ValidarCPF2_Click(object sender, EventArgs e)
        {
            Frm_ValidaCPF2 fValidaCPF2 = new Frm_ValidaCPF2();
            fValidaCPF2.ShowDialog();
        }

        private void Btn_ValidaSenha_Click(object sender, EventArgs e)
        {
            Frm_ValidaSenha fValidaSenha = new Frm_ValidaSenha();
            fValidaSenha.ShowDialog();
        }
    }
}
