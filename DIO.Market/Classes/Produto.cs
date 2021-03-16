using System;

namespace DIO.Market
{
    public class Produto
    {
        private string Nome { get; set; }
        private double Valor { get; set; }
        private int Quantidade { get; set; }
        private TipoProduto TipoProduto { get; set; }

        public Produto(string nome, double valor, int quantidade, TipoProduto tipoProduto)
		{
            this.Nome = nome;
			this.Valor = valor;
			this.Quantidade = quantidade;
			this.TipoProduto = tipoProduto;
		}

        public void Total()
        {
            var valorTotal = this.Valor * this.Quantidade;
            
            Console.WriteLine("O valor total da compra será: " + valorTotal);
        }

        public override string ToString()
		{
            string retorno = "";
            retorno += "Nome: " + this.Nome + " | ";
            retorno += "Valor: " + this.Valor + " | ";
            retorno += "Quantidade: " + this.Quantidade + " | ";
            retorno += "Tipo Produto: " + this.TipoProduto;
			return retorno;
		}
    }
}