using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Infra.Data.Entities
{
    public class Produto
    {
        public int IdProduto { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public double Preco { get; set; }
        public string Descricao { get; set; }

        public int IdVendedor { get; set; }
        public Vendedor Vendedor { get; set; }
    }
}
