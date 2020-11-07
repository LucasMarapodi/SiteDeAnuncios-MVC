using Projeto.Infra.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Infra.Data.Contracts
{
    public interface IVendedorRepository : IBaseRepository<Vendedor>
    {
        Vendedor GetByEmailAndSenha(string email, string senha);
        Vendedor GetByEmail(string email);
    }
}
