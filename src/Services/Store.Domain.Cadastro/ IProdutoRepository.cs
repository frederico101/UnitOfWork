using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Cadastro.Domain;
using DomainCore.Data;

namespace Cadastro
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        Task<IEnumerable<Produto>> ObterTodos();
        Task<Produto> ObterPorId(Guid id);
        Task<IEnumerable<Produto>> ObterPorCategoria(int codigo);
        Task<IEnumerable<Categoria>> ObterCategorias();
        void Adicionar(Produto produto);
        void Atualizar(Produto produto);
        void Adcionar(Categoria categoria);
        void Atualizar(Categoria categoria);
    }
}