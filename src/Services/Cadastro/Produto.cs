using System;
using DomainCore;

namespace Cadastro.Domain
{
    public class Produto : Entity
    {
        public string Nome { get; private set; }
        public int Quantidade { get; private set; }
        public Guid CategoriaId { get; private set; }
        public Categoria Categoria { get; private set; }

        public Produto(string nome, int quantidade)
        {
            Nome = nome;
            Quantidade = quantidade;
            Validar();
        }
        public void Validar()
        {
            Validacoes.ValidarSeNulo(Nome, "O nome esta vazio");
        }

    }
    public class Categoria : Entity
    {
        public string Nome { get; private set; }
        public string Status { get; private set; }

        public Categoria(string nome, string status)
        {
            Nome = nome;
            Status = status;
        }

    }
}
