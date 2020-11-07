using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Presentation.Mvc.Models.ProdutoModels
{
    public class ProdutoCadastroModel
    {
        [Required(ErrorMessage = "Campo Obrigatorio.")]
        [MinLength(2, ErrorMessage = "No minimo {1} Caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo Obrigatorio.")]
        public string Categoria { get; set; }

        [Required(ErrorMessage = "Campo Obrigatorio.")]
        public string Preco { get; set; }

        [Required(ErrorMessage = "Campo Obrigatorio.")]
        [MaxLength(500, ErrorMessage = "No Maximo {1} Caracteres.")]
        public string Descricao { get; set; }
    }
}
