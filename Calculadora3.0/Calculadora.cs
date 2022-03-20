using Calculadora3._0;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora2._0
{
    public partial class Calculadora : Form
    {
        OperacaoAritmetica operacao = new OperacaoAritmetica();

        //List guarda e resgatar depois
        List<string> Historicos = new List<string>();

        public Calculadora()
        {
            InitializeComponent();
        }

        #region Variaveis.
        /*decimal nPrimeiroNumero;
        decimal nSegundoNumero;*/
        //int iOperacao;// 1 = +/2 =-/3 =*/4 =/ /5 =% / 6 ==
       // decimal nTotal = 0;
        #endregion


        #region EventoClick Numeros
        private void btnUm_Click(object sender, EventArgs e)
        {
            //txtDigitado.Text = txtDigitado.Text + "1";
            // txtDigitado.Text += "1";

            // Metado responsavel por Atualizar o painel de digitação com a informação do botão
            AtualizaTxtDigitado("1");

        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            // txtDigitado.Text += "2";

            // Metado responsavel por Atualizar o painel de digitação com a informação do botão
            AtualizaTxtDigitado("2");
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            // txtDigitado.Text += "3";

            // Metado responsavel por Atualizar o painel de digitação com a informação do botão
            AtualizaTxtDigitado("3");
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            //txtDigitado.Text += "4";

            // Metado responsavel por Atualizar o painel de digitação com a informação do botão
            AtualizaTxtDigitado("4");
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            // txtDigitado.Text += "5";

            // Metado responsavel por Atualizar o painel de digitação com a informação do botão
            AtualizaTxtDigitado("5");
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            //txtDigitado.Text += "6";

            // Metado responsavel por Atualizar o painel de digitação com a informação do botão
            AtualizaTxtDigitado("6");
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            // txtDigitado.Text += "7";

            // Metado responsavel por Atualizar o painel de digitação com a informação do botão
            AtualizaTxtDigitado("7");
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            // txtDigitado.Text += "8";

            // Metado responsavel por Atualizar o painel de digitação com a informação do botão
            AtualizaTxtDigitado("8");
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            //txtDigitado.Text += "9";

            // Metado responsavel por Atualizar o painel de digitação com a informação do botão
            AtualizaTxtDigitado("9");
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            //txtDigitado.Text += "0";

            // Metado responsavel por Atualizar o painel de digitação com a informação do botão
            AtualizaTxtDigitado("0");
        }
        private void btnVirgula_Click(object sender, EventArgs e)
        {

            if (!txtDigitado.Text.Contains(","))
            {
                AtualizaTxtDigitado(",");
            }



        }
        #endregion

        #region Operações

        private void btnSoma_Click(object sender, EventArgs e)
        {
            

            ProcessaBotaoAritimetico(TipoOperacao.Adicao);

        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            
            ProcessaBotaoAritimetico(TipoOperacao.Subtracao);
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
           
            ProcessaBotaoAritimetico(TipoOperacao.Divisao);

        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            ProcessaBotaoAritimetico(TipoOperacao.Multiplicacao);
        }

        private void btnPorcento_Click(object sender, EventArgs e)
        {
            
            ProcessaBotaoAritimetico(TipoOperacao.Porcentagem);


        }
        private void btnIgual_Click(object sender, EventArgs e)
        {
            


            if (operacao.tipoOperacao == TipoOperacao.Igual)
            {
                return;
            }
            // Metado responsavel por realizar o calculo da calculadora
            Calcula();
            // Atualiza Painel
            txtDigitado.Text = String.Concat(operacao.nPrimeiroValor.ToString(), operacao.RetornaSinal(), operacao.nSegundoValor, " = ", operacao.nResultado);
            txtHistorico.Text = string.Empty;

            // guardando o historicos de calculos 
            Historicos.Add(txtDigitado.Text);

            // Atualiza a operação para Igual
            operacao.tipoOperacao = TipoOperacao.Igual;


        }
        private void btnC_Click(object sender, EventArgs e)
        {
            //limpar();

            IniciaProcesso();

            txtDigitado.Clear();
            txtHistorico.Clear();
        }
       
        #endregion



        #region Metodo
       

        private void IniciaProcesso()
        {
            operacao.tipoOperacao = TipoOperacao.Nenhum;
            operacao.nPrimeiroValor = 0;
            operacao.nSegundoValor = 0;
            operacao.nResultado = 0;
        }

        private void Calcula()
        {
           

            // Passa o Segundo Valor informado para a Classe
            operacao.nSegundoValor = Convert.ToDecimal(txtDigitado.Text);
            // Após Passar os Valores, Realiza o Calculo
            operacao.Calcula();
        }

        private void AtualizaTxtDigitado(string strNumero)
        {
            if (operacao.tipoOperacao == TipoOperacao.Igual)
            {
                // Prepara a Class para novo calculo
                IniciaProcesso();
                // Limpa painel
                txtDigitado.Clear();
            }
            txtDigitado.Text += strNumero;
        }
        private void ProcessaBotaoAritimetico(TipoOperacao tpOperacao)
        {
            if (operacao.tipoOperacao == TipoOperacao.Nenhum)

            {
                operacao.tipoOperacao = tpOperacao;

                operacao.nPrimeiroValor = Convert.ToDecimal(txtDigitado.Text);

                txtHistorico.Text += String.Concat(operacao.nPrimeiroValor, operacao.RetornaSinal());

                txtDigitado.Text = string.Empty;

            }
            else if (operacao.tipoOperacao == TipoOperacao.Igual)
            {
                // Guarda o ultimo resultado
                var nUltimoResultado = operacao.nResultado;
                // Prepara a Class para novo calculo
                IniciaProcesso();
                // Informa ultimo resultado
                operacao.nPrimeiroValor = nUltimoResultado;
                // Define a Operação Artimética
                operacao.tipoOperacao = tpOperacao;
                // Atualiza painel
                txtDigitado.Clear();
                txtHistorico.Text = String.Concat(operacao.nPrimeiroValor, operacao.RetornaSinal());
            }
            else
            {
                // Troca a operação
                if (String.IsNullOrEmpty(txtDigitado.Text))
                {
                    // Define a Operação Artimética
                    operacao.tipoOperacao = tpOperacao;
                    // Atualiza o painel de histórico
                    txtHistorico.Text = String.Concat(operacao.nPrimeiroValor, operacao.RetornaSinal());
                }
                else
                {
                    // Calcula o operação
                    Calcula();
                    // Define a Operação Artimética
                    operacao.tipoOperacao = tpOperacao;
                    // Passa o Primeiro Valor informado para a Classe
                    operacao.nPrimeiroValor = operacao.nResultado;
                    // Atualiza o painel de histórico
                    txtHistorico.Text = String.Concat(operacao.nPrimeiroValor, operacao.RetornaSinal());
                    txtDigitado.Clear();
                }
            }
        }





        #endregion

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            Historico historico = new Historico();
            // puxando o metodo PreencheHistorico da class Historico
            historico.PreencheHistorico(Historicos);

            // Aqui ele vai fazer que o form de tras não seja acesado usando o metodo showDialog()
            historico.ShowDialog(this); 
            historico.Close();
            
        }
    }
}

