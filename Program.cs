using System;
using System.Collections.Generic;

namespace Aula27_28_29_30
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto();
            p1.Codigo = 2;
            p1.Nome = "Pepsi";
            p1.Preco = 4.2f;

            p1.Cadastrar(p1);

            p1.Remover("Macarrao");

            List<Produto> lista = p1.Ler();
           

            foreach(Produto item in lista){
                System.Console.WriteLine($"R$:{item.Preco} - {item.Nome}");
            }

            
        }
    }
}
