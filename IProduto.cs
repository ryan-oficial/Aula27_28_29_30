using System.Collections.Generic;

namespace Aula27_28_29_30
{
    public interface IProduto
    {

        /// <summary>
        /// Metodo CRUD
        /// </summary>
        /// <returns>E herdado pelo Produto</returns>
         List<Produto> Ler();
         void Cadastrar(Produto prod);
         void Remover(string _termo);
         void Alterar(Produto _produtoAlterado);
    }
}