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
            p1.Nome = "Guarana Antartica";
            p1.Preco = 4.2f;

            p1.Cadastrar(p1);

            Produto alterado = new Produto();
            alterado.Codigo = 2;
            alterado.Nome = "Dolly";
            alterado.Preco = 3.1f;

            // p1.Alterar(alterado);


            List<Produto> lista = p1.Ler();
           

            foreach(Produto item in lista){
                System.Console.WriteLine($"R$:{item.Preco} - {item.Nome}");
            }

            p1.Remover("Kuat");
            
        }
    }
}
