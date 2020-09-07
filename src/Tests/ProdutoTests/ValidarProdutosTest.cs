using System;
using Cadastro.Domain;
using DomainCore;
using Xunit;

namespace ProdutoTests
{
    public class ValidarProdutosTest
    {
        [Fact]
        public void ValidarProdutos()
        {
           var produtos = Assert.Throws<DomainException>(()=> new Produto(string.Empty, 1));
        }
    }
}
