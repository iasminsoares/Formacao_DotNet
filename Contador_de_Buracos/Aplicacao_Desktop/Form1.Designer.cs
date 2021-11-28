
namespace Aplicacao_Desktop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_entradaTexto = new System.Windows.Forms.TextBox();
            this.label_digite_aqui = new System.Windows.Forms.Label();
            this.label_palavras = new System.Windows.Forms.Label();
            this.tb_quantidade_palavras = new System.Windows.Forms.TextBox();
            this.label_caracter = new System.Windows.Forms.Label();
            this.tb_quantidade_caracter = new System.Windows.Forms.TextBox();
            this.label_buracos = new System.Windows.Forms.Label();
            this.tb_quantidade_buracos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_entradaTexto
            // 
            this.tb_entradaTexto.Location = new System.Drawing.Point(56, 80);
            this.tb_entradaTexto.Margin = new System.Windows.Forms.Padding(4);
            this.tb_entradaTexto.Name = "tb_entradaTexto";
            this.tb_entradaTexto.Size = new System.Drawing.Size(388, 34);
            this.tb_entradaTexto.TabIndex = 0;
            this.tb_entradaTexto.TextChanged += new System.EventHandler(this.tb_entradaTexto_TextChanged);
            // 
            // label_digite_aqui
            // 
            this.label_digite_aqui.AutoSize = true;
            this.label_digite_aqui.Location = new System.Drawing.Point(151, 40);
            this.label_digite_aqui.Name = "label_digite_aqui";
            this.label_digite_aqui.Size = new System.Drawing.Size(196, 27);
            this.label_digite_aqui.TabIndex = 1;
            this.label_digite_aqui.Text = "Digite aqui o seu texto:";
            // 
            // label_palavras
            // 
            this.label_palavras.AutoSize = true;
            this.label_palavras.Location = new System.Drawing.Point(56, 153);
            this.label_palavras.Name = "label_palavras";
            this.label_palavras.Size = new System.Drawing.Size(278, 27);
            this.label_palavras.TabIndex = 2;
            this.label_palavras.Text = "Quantidade de palavras no texto:";
            // 
            // tb_quantidade_palavras
            // 
            this.tb_quantidade_palavras.Location = new System.Drawing.Point(383, 146);
            this.tb_quantidade_palavras.Name = "tb_quantidade_palavras";
            this.tb_quantidade_palavras.Size = new System.Drawing.Size(61, 34);
            this.tb_quantidade_palavras.TabIndex = 3;
            this.tb_quantidade_palavras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_quantidade_palavras.TextChanged += new System.EventHandler(this.tb_quantidade_palavras_TextChanged);
            // 
            // label_caracter
            // 
            this.label_caracter.AutoSize = true;
            this.label_caracter.Location = new System.Drawing.Point(56, 222);
            this.label_caracter.Name = "label_caracter";
            this.label_caracter.Size = new System.Drawing.Size(294, 27);
            this.label_caracter.TabIndex = 4;
            this.label_caracter.Text = "Quantidade de caracteres no texto:";
            // 
            // tb_quantidade_caracter
            // 
            this.tb_quantidade_caracter.Location = new System.Drawing.Point(383, 215);
            this.tb_quantidade_caracter.Name = "tb_quantidade_caracter";
            this.tb_quantidade_caracter.Size = new System.Drawing.Size(61, 34);
            this.tb_quantidade_caracter.TabIndex = 5;
            this.tb_quantidade_caracter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_buracos
            // 
            this.label_buracos.AutoSize = true;
            this.label_buracos.Location = new System.Drawing.Point(56, 288);
            this.label_buracos.Name = "label_buracos";
            this.label_buracos.Size = new System.Drawing.Size(274, 27);
            this.label_buracos.TabIndex = 6;
            this.label_buracos.Text = "Quantidade de buracos no texto:";
            // 
            // tb_quantidade_buracos
            // 
            this.tb_quantidade_buracos.Location = new System.Drawing.Point(383, 281);
            this.tb_quantidade_buracos.Name = "tb_quantidade_buracos";
            this.tb_quantidade_buracos.Size = new System.Drawing.Size(61, 34);
            this.tb_quantidade_buracos.TabIndex = 7;
            this.tb_quantidade_buracos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 364);
            this.Controls.Add(this.tb_quantidade_buracos);
            this.Controls.Add(this.label_buracos);
            this.Controls.Add(this.tb_quantidade_caracter);
            this.Controls.Add(this.label_caracter);
            this.Controls.Add(this.tb_quantidade_palavras);
            this.Controls.Add(this.label_palavras);
            this.Controls.Add(this.label_digite_aqui);
            this.Controls.Add(this.tb_entradaTexto);
            this.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_entradaTexto;
        private System.Windows.Forms.Label label_digite_aqui;
        private System.Windows.Forms.Label label_palavras;
        private System.Windows.Forms.TextBox tb_quantidade_palavras;
        private System.Windows.Forms.Label label_caracter;
        private System.Windows.Forms.TextBox tb_quantidade_caracter;
        private System.Windows.Forms.Label label_buracos;
        private System.Windows.Forms.TextBox tb_quantidade_buracos;
    }
}

