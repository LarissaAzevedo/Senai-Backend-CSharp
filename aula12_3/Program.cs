using System;
using aula12_3.Controller;

namespace aula12_3
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutoController produto = new ProdutoController();

            produto.ReservarProduto();
        }
    }
}
