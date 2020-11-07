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
    public class VendedorRepository : IVendedorRepository
    {
        private readonly string connectionString;

        public VendedorRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public Vendedor GetByEmailAndSenha(string email, string senha)
        {
            var query = "Select * From Vendedor Where Email = @Email and Senha = @Senha";

            using (var connection = new SqlConnection(connectionString))
            {
                return connection.QueryFirstOrDefault<Vendedor>(query, new { Email = email, Senha = senha });
            }
        }

        public Vendedor GetByEmail(string email)
        {
            var query = "Select * From Vendedor Where Email = @Email";

            using(var connection = new SqlConnection(connectionString))
            {
                return connection.QueryFirstOrDefault<Vendedor>(query, new { Email = email});
            }
        }

        public void Insert(Vendedor entity)
        {
            var query = "Insert into Vendedor (Nome,Email,Senha,Telefone) Values (@Nome,@Email,@Senha,@Telefone)";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Execute(query, entity);
            }
        }

        public void Update(Vendedor entity)
        {
            var query = "Update Vendedor Set Nome = @Nome, Telefone = @Telefone where IdVendedor = @IdVendedor";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Execute(query, entity);
            }
        }

        public void Delete(Vendedor entity)
        {
            var query = "Delete From Vendedor Where IdVendedor = @IdVendedor";

            using(var connection = new SqlConnection(connectionString))
            {
                connection.Execute(query, entity);
            }
        }

        public Vendedor GetById(int id)
        {
            var query = "Select * From Vendedor Where IdVendedor = @IdVendedor";

            using (var connection = new SqlConnection(connectionString))
            {
                return connection.QueryFirstOrDefault<Vendedor>(query, new { IdVendedor = id });
            }
        }
    }
}
