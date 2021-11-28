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
    public partial class Frm_ValidaCPF2 : Form
    {
        public Frm_ValidaCPF2()
        {
            InitializeComponent();
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Msk_CPF.Text = "";
        }

        private void Btn_Valida_Click(object sender, EventArgs e)
        {
            string verConteudo;
            verConteudo = Msk_CPF.Text;
            verConteudo = verConteudo.Replace(".", "").Replace("-", "").Trim();

            if (verConteudo == "" || verConteudo.Length < 11)
            {
                MessageBox.Show("Por favor, digite o CPF completo", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Você realmente deseja validar o CPF?", "Mensagem de validação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) //se clicou na opção sim do botão
                {
                    bool validaCPF = false;
                    validaCPF = Cls_Uteis.Valida(Msk_CPF.Text); //chamando a classe onde contem a validação

                    if (validaCPF == true)
                    {
                        MessageBox.Show("CPF VÁLIDO", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("CPF INVÁLIDO", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }
    }
}
