namespace ControleEstoque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto(1, "Notebook", 0, 2300);
            produto.imprimir();
            produto.entrada(20);
            produto.imprimir();
            produto.venda(5);
            produto.imprimir();
        }
    }
}