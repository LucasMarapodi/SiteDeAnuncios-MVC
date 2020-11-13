using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Infra.Data.Entities
{
    public class Comprador
    {
        //Entidade para teoricamente guardar os dados de um comprador 
        public string Nome { get; set; }
        public string Cartao { get; set; }
        public string Local { get; set; }
    }
}
