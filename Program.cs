using System;
using System.Collections.Generic;

namespace Aula27_28_29_30
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto();
            p1.Codigo = 1;
            p1.Nome = "Coca-cola";
            p1.Preco = 4.50f;

            List<Produto> list = new List<Produto>();
            list = p1.Ler();

            foreach(Produto item in list){
                System.Console.WriteLine($"R$:{item.Preco} - {item.Nome}");
            }

            p1.Cadastrar(p1);
        }
    }
}
