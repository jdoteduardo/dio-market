using System;
using System.Collections.Generic;

namespace DIO.Market
{
    public class Program
    {
        static List<Produto> listaProdutos = new List<Produto>();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
			{
				switch (opcaoUsuario)
				{
					case "1":
						ListarProdutos();
						break;
					case "2":
						InserirProduto();
						break;
                    case "3":
						MostrarTotal();
						break;
                    case "C":
						Console.Clear();
						break;
					default:
						throw new ArgumentOutOfRangeException();
				}

				opcaoUsuario = ObterOpcaoUsuario();
            }
            Console.WriteLine("Obrigado por utilizar nossos serviços.");
			Console.ReadLine();
        }

        private static void MostrarTotal()
        {
            Console.Write("Digite o número do produto: ");
			int indiceProduto = int.Parse(Console.ReadLine());

            listaProdutos[indiceProduto].Total();
        }

        private static void InserirProduto()
        {
            Console.WriteLine("Inserir novo produto");

            Console.Write("Digite o Nome do Produto: ");
			string entradaNome = Console.ReadLine();

            Console.Write("Digite o valor: ");
			double entradaValor = double.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade ou quilo: ");
			int entradaQuantidade = int.Parse(Console.ReadLine());

			Console.Write("Digite 1, 2, 3, 4, 5 ou 6 para Carne, Laticínio, Massa, Bebida, Fruta e Verdura nessa ordem: ");
			int entradaTipoProduto = int.Parse(Console.ReadLine());

			Produto novoProduto = new Produto(nome: entradaNome, valor: entradaValor,
            quantidade: entradaQuantidade, tipoProduto: (TipoProduto)entradaTipoProduto);

			listaProdutos.Add(novoProduto);
        }

        private static void ListarProdutos()
		{
			Console.WriteLine("Listar produtos");

			if (listaProdutos.Count == 0)
			{
				Console.WriteLine("Nenhum produto cadastrado.");
				return;
			}

			for (int i = 0; i < listaProdutos.Count; i++)
			{
				Produto produto = listaProdutos[i];
				Console.Write("#{0} - ", i);
				Console.WriteLine(produto);
			}
		}

        private static string ObterOpcaoUsuario()
            {
                Console.WriteLine();
                Console.WriteLine("DIO Market a seu dispor!!");
                Console.WriteLine("Informe a opção desejada: ");

                Console.WriteLine("1 - Listar Produtos");
                Console.WriteLine("2 - Inserir novo Produto");
                Console.WriteLine("3 - Mostrar valor total a ser pago");
                Console.WriteLine("C - Limpar Tela");
                Console.WriteLine("X - Sair");
                Console.WriteLine();

                string opcaoUsuario = Console.ReadLine().ToUpper();
                Console.WriteLine();
                return opcaoUsuario;
            }
    }
}
