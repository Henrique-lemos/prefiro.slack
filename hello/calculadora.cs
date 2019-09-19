using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            object p = InitializeComponent();
        }
        #region Variáveis
        double numero1;
        double numero2;
        double resultado;
        string operador; //sã6 os sinais
        bool operacao = true; //são os números.
        
        #endregion
        #region Definição dos Botões Numéricos
        private void bt0_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == "0")
            {
                return;
            }
            else
            {
                txtResultado.Text = txtResultado.Text += 0;
            }
        }
        private void bt1_Click(object sender, EventArgs e)
        {
            if (operacao)
            {
                txtResultado.Text = txtResultado.Text = "";
                txtResultado.Text = txtResultado.Text = "1";
                operacao = false;
            }
            else
            {
                txtResultado.Text = txtResultado.Text += "1";
            }
        }
        private void bt2_Click(object sender, EventArgs e)
        {
            if (operacao)
            {
                txtResultado.Text = txtResultado.Text = "";
                txtResultado.Text = txtResultado.Text = "2";
                operacao = false;
            }
            else
            {
                txtResultado.Text = txtResultado.Text += 2;
            }
        }
        private void bt3_Click(object sender, EventArgs e)
        {
            if (operacao)
            {
                txtResultado.Text = txtResultado.Text = "";
                txtResultado.Text = txtResultado.Text = "3";
                operacao = false;//essa linha serve para colocar a operacao em falso para repetir o nº. Ex.: 3333.
            }
            else
            {
                txtResultado.Text = txtResultado.Text += 3;
            }
        }
        private void bt4_Click_1(object sender, EventArgs e)
        {
            if (operacao)
            {
                txtResultado.Text = txtResultado.Text = "";
                txtResultado.Text = txtResultado.Text = "4";
                operacao = false;
            }
            else
            {
                txtResultado.Text = txtResultado.Text += 4;
            }
        }
        private void bt5_Click(object sender, EventArgs e)
        {
            if (operacao)
            {
                txtResultado.Text = txtResultado.Text = "";
                txtResultado.Text = txtResultado.Text = "5";
                operacao = false;
            }
            else
            {
                txtResultado.Text = txtResultado.Text += 5;
            }
        }
        private void bt6_Click(object sender, EventArgs e)
        {
            if (operacao)
            {
                txtResultado.Text = txtResultado.Text = "";
                txtResultado.Text = txtResultado.Text = "6";
                operacao = false;
            }
            else
            {
                txtResultado.Text = txtResultado.Text += 6;
            }
        }
        private void bt7_Click(object sender, EventArgs e)
        {
            if (operacao)
            {
                txtResultado.Text = txtResultado.Text = "";
                txtResultado.Text = txtResultado.Text = "7";
                operacao = false;
            }
            else
            {
                txtResultado.Text = txtResultado.Text += 7;
            }
        }
        private void bt8_Click(object sender, EventArgs e)
        {
            if (operacao)
            {
                txtResultado.Text = txtResultado.Text = "";
                txtResultado.Text = txtResultado.Text = "8";
                operacao = false;
            }
            else
            {
                txtResultado.Text = txtResultado.Text += 8;
            }
        }
        private void bt9_Click(object sender, EventArgs e)
        {
            if (operacao)
            {
                txtResultado.Text = txtResultado.Text = "";
                txtResultado.Text = txtResultado.Text = "9";
                operacao = false;
            }
            else
            {
                txtResultado.Text = txtResultado.Text += 9;
            }
        }
        #endregion
        #region Botão Backspace
        private void btBackspace_Click(object sender, EventArgs e)
        {
            int x = txtResultado.Text.Length - 1;//comprimento do campo txtResultado -1, apagndo uma casa da esquerda para direita. Ex.: 789 clicanco uma vez neste botão fica 78 apagando o 9
            if (x >= 0)
            {
                txtResultado.Text = txtResultado.Text.Substring(0, x);//na primeira casa começa co 0 e termina com um nº int x.
            }
        }
        #endregion
        private void btCE_Click(object sender, EventArgs e)
        {
        }
        #region Botão Limpar
        private void btC_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
            txtResultado.Text = txtResultado.Text = "0";
        }
        #endregion
               #region Configuando o Botão de igual
        private void btIgual_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(txtResultado.Text);
            numero2 = Convert.ToDouble(txtResultado.Text);//coloca-se o numero2 porque é o último a ficar na memória
            operacao = true;
            switch (operador)
            {
                case "+":
                    {
                        resultado = numero1 + numero2;
                        txtResultado.Text = txtResultado.ToString();
                        break;
                    }
                case "-":
                    {
                        resultado = numero1 - numero2;
                        txtResultado.Text = txtResultado.ToString();
                        break;
                    }
                case "*":
                    {
                        resultado = numero1 * numero2;
                        txtResultado.Text = txtResultado.ToString();
                        break;
                    }
                case "/":
                    {
                        resultado = numero1 / numero2;
                        txtResultado.Text = txtResultado.ToString();
                        break;
                    }
            }
        }
        #endregion
        #region Definição dos Botões Operadores Aritméticos
        private void btSoma_Click(object sender, EventArgs e)
        {
            operador = "+";
            operacao = true;
            numero1 = Convert.ToDouble(txtResultado.Text);
        }
        private void btSubtracao_Click(object sender, EventArgs e)
        {
            operador = "-";
            operacao = true;
            numero1 = Convert.ToDouble(txtResultado.Text);
        }
        private void btMultiplicacao_Click(object sender, EventArgs e)
        {
            operador = "*";
            operacao = true;
            numero1 = Convert.ToDouble(txtResultado.Text);
        }
        private void btDivisao_Click(object sender, EventArgs e)
        {
            operador = "/";
            operacao = true;
            numero1 = Convert.ToDouble(txtResultado.Text);
        }
        #endregion
        private void txtResultado_TextChanged(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text.ToString();
        }
    }
}