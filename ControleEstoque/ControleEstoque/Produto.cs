using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoque
{
    class Produto
    {
        private int codigo { get; set; }
        private string nome { get; set; }

        private int estoque;
        private double valor { get; set; }

        public void entrada(int qtd)
        {
            estoque += qtd;
            Console.WriteLine("Entrada de " + qtd);
        }

        public void venda(int qtd)
        {
            estoque -= qtd;
            Console.WriteLine("Venda de " + qtd);
        }

        public void imprimir()
        {
            Console.WriteLine("Dados do produto");
            Console.WriteLine("Cod: " + codigo);
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Estoque: " + estoque);
            Console.WriteLine("Valor: " + valor);
        }

        public Produto(int codigo, string nome, int estoque, double valor)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.estoque = estoque;
            this.valor = valor;
        }
    }
}
