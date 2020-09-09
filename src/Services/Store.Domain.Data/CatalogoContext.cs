using System;
using Cadastro.Domain;
using Microsoft.EntityFrameworkCore;

namespace Store.Domain.Data
{
    public class CatalogoContext: DbContext
    {
        DbSet<Produto> Produtos {get; set;}
        DbSet<Categoria> Categorias {get; set;}
        public CatalogoContext(DbContextOptions<CatalogoContext> options) : base (options){}

    }
}
