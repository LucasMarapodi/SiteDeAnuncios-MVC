using Dapper;
using Projeto.Infra.Data.Contracts;
using Projeto.Infra.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Projeto.Infra.Data.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly string connectionString;

        public ProdutoRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Insert(Produto entity)
        {
            var query = "insert Into Produto (Nome,Preco,Descricao,Categoria,IdVendedor) values (@Nome,@Preco,@Descricao,@Categoria,@IdVendedor)";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Execute(query, entity);
            }
        }

        public void Update(Produto entity)
        {
            var query = "Update Produto Set Nome = @Nome, Preco = @Preco, Descricao = @Descricao, Categoria = @Categoria where IdProduto = @IdProduto";

            using(var connection = new SqlConnection(connectionString))
            {
                connection.Execute(query, entity);
            }
        }

        public void Delete(Produto entity)
        {
            var query = "Delete From Produto Where IdProduto = @IdProduto";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Execute(query, entity);
            }
        }

        public Produto GetById(int id)
        {
            var query = "Select * From Produto where IdProduto = @IdProduto";

            using (var connection = new SqlConnection(connectionString))
            {
                return connection.QueryFirstOrDefault<Produto>(query, new { IdProduto = id });
            }
        }

        public List<Produto> GetAll()
        {
            var query = "Select * From Produto p inner join Vendedor v on v.IdVendedor = p.IdVendedor Order By p.Nome Asc";

            using (var connection = new SqlConnection(connectionString))
            {
                return connection.Query(query, (Produto p, Vendedor v) => { p.Vendedor = v; return p; },splitOn : "IdVendedor").ToList();
            }
        }

        public List<Produto> GetByVendedor(int id)
        {
            var query = "Select * From Produto where IdVendedor = @IdVendedor Order By Nome Asc";

            using (var connection = new SqlConnection(connectionString))
            {
                return connection.Query<Produto>(query, new { IdVendedor = id}).ToList();
            }
        }
    }
}
