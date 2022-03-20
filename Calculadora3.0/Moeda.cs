using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora3._0
{
    public partial class Moeda : Form
    {
        public Moeda()
        {
            InitializeComponent();
            cboMoeda1.SelectedIndex = 0; // comboBox inicia com a primeira opção dele
            cboMoeda2.SelectedIndex = 0;
        }



        public void Calculo()
        {
           

            if(cboMoeda1.SelectedIndex == 1 && cboMoeda2.SelectedIndex == 2)
            {
                double nPrimeiroValor = 5.09;
                double nSegundoValor;
                double nResultado = 0;

                nSegundoValor = double.Parse(txtValor.Text);

                nResultado = nPrimeiroValor * nSegundoValor;

                txtResult.Text = nResultado.ToString("F"); // Lembrece sempre que o txt que vem primeiro no recebimento de valor 
            }

            if(cboMoeda1.SelectedIndex == 2 && cboMoeda2.SelectedIndex == 1)
            {
                double nPrimeiroValor = 0.20;
                double nSegundoValor;
                double nResultado = 0;

                nSegundoValor = double.Parse(txtValor.Text);

                nResultado = nPrimeiroValor * nSegundoValor;

                txtResult.Text = nResultado.ToString("F");

            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            Calculo();
        }
        private void btnUm_Click(object sender, EventArgs e)
        {
            BtnNum("1");
        }
        private void btnDois_Click(object sender, EventArgs e)
        {
            BtnNum("2");
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            BtnNum("3");
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            BtnNum("4");
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            BtnNum("5");
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            BtnNum("6");
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            BtnNum("7");
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            BtnNum("8");
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            BtnNum("9");
        }
        private void btnZero_Click(object sender, EventArgs e)
        {
            BtnNum("0");
        }
        private void btnVirgula_Click(object sender, EventArgs e)
        {
            BtnNum(",");
        }
        public void BtnNum(string num) // metodo para os botoes de numero 
        {
            txtValor.Text += num;
        }
        public void Limpar()// metodo para limpar campos
        {
            txtResult.Clear();
            cboMoeda1.Text = string.Empty;
            txtValor.Clear();
            cboMoeda2.Text = string.Empty;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            txtValor.Text = txtValor.Text.Substring(0, txtValor.Text.Length - 1);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }
    }
}
