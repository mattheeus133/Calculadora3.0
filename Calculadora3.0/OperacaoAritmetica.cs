using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora3._0
{
    public enum TipoOperacao
    {
        Nenhum,
        Adicao,
        Subtracao,
        Multiplicacao,
        Divisao,
        Porcentagem,
        Igual
    }
    public class OperacaoAritmetica
    {
       public TipoOperacao tipoOperacao { get; set; } // metodo puxando o enum
        public decimal nPrimeiroValor { get; set; }
        public decimal nSegundoValor { get; set; }
        public decimal nResultado { get; set; }

        public string RetornaSinal() // metodo de retorno do sinal
        {
            string strSinal = "";
           if(tipoOperacao == TipoOperacao.Adicao) // tipoOperacao vem do get set
            {                 //TipoOperacao.Adicao vem do enum
                strSinal = "+";//passando se a variavel for igual a +
            }
           if(tipoOperacao == TipoOperacao.Subtracao)
            {
                strSinal = "-";
            }
           if(tipoOperacao == TipoOperacao.Multiplicacao)
            {
                strSinal = "*";
            }
           if(tipoOperacao == TipoOperacao.Divisao)
            {
                strSinal = "/";
            }
           if(tipoOperacao == TipoOperacao.Porcentagem)
            {
                strSinal = "%";
            }
            return strSinal;
        }

        public void Calcula()
        {
            decimal nResult = 0; // pansando a varivel que ira receber o resultado

            switch(tipoOperacao) // Switch case tem praticamente a mesma funçao do if/else 
            {
                case TipoOperacao.Adicao:// no case TipoOperacao vem do enum
                    {
                        nResult = nPrimeiroValor + nSegundoValor;
                        break;
                    }
                case TipoOperacao.Subtracao: // case sempre termina com Dois Pontos
                    {
                        nResult = nPrimeiroValor - nSegundoValor;
                        break; // ja o break termina com Ponto e Virgula
                    }
                case TipoOperacao.Multiplicacao:
                    {
                        nResult = nPrimeiroValor * nSegundoValor;
                        break;
                    }
                case TipoOperacao.Divisao:
                    {
                        nResult = nPrimeiroValor / nSegundoValor;
                        break;
                    }
                case TipoOperacao.Porcentagem:
                    {
                        nResult = (nPrimeiroValor / 100) * nSegundoValor;
                        break;
                    }

            }
            nResultado = nResult; // Aqui passa o resultado da varival do Switch case
                                  // para o a variavel principal
        }

        
    }
}
