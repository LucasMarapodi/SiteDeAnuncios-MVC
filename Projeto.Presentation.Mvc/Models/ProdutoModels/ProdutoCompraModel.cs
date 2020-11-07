using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Projeto.Infra.Data.Entities;

namespace Projeto.Presentation.Mvc.Models.ProdutoModels
{
    public class ProdutoCompraModel
    {
        [Required(ErrorMessage ="Campo Obrigatorio.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Campo Obrigatorio.")]
        public string Local { get; set; }
        [Required(ErrorMessage = "Campo Obrigatorio.")]
        [MinLength(8,ErrorMessage ="Informe um cartão com no minimo {1} digitos")]
        public string Cartao { get; set; }

        public Produto Produto { get; set; }
    }
}
