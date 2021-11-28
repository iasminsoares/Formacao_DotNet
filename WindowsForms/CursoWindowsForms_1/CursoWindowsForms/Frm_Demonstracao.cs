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
    public partial class Frm_Demonstracao : Form
    {
        public Frm_Demonstracao()
        {
            InitializeComponent();
        }

        private void Txt_Input_KeyDown(object sender, KeyEventArgs e)
        {
            Txt_Msg.AppendText("\r\n" + "Pressionei uma tecla: " + e.KeyCode + "\r\n"); //exibindo na tela qual tecla está sendo digitado atraves do KeyCode
            Txt_Msg.AppendText("\t" + "Código uma tecla: " + ((int)e.KeyCode) + "\r\n");//Convertendo a tecla num valor inteiro
            Txt_Msg.AppendText("\t" + "Nome uma tecla: " + ((int)e.KeyData) + "\r\n");//Nome da tecla 
            Lbl_Lower.Text = e.KeyCode.ToString().ToLower();
            Lbl_Upper.Text = e.KeyCode.ToString().ToUpper();

        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            //limpando os campos
            Txt_Msg.Text = "";
            Txt_Input.Text = "";
            Lbl_Lower.Text = "";
            Lbl_Upper.Text = "";
        }
    }
}
