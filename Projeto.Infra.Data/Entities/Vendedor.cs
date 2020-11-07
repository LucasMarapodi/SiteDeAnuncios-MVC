using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Infra.Data.Entities
{
    public class Vendedor
    {
        public int IdVendedor { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Telefone { get; set; }

        public int IdProduto { get; set; }
        public List<Produto> Produtos { get; set; }
    }
}
