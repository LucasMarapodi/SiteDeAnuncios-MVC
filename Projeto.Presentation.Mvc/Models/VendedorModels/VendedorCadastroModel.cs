using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Presentation.Mvc.Models.VendedorModels
{
    public class VendedorCadastroModel
    {
        [Required(ErrorMessage = "Campo Obrigatorio.")]
        [MaxLength(150,ErrorMessage ="Por favor, Informe no maximo {1} Caracteres.")]
        public string Nome { get; set; }

        [EmailAddress(ErrorMessage ="Por favor, Informe um Email Valido.")]
        [Required(ErrorMessage = "Campo Obrigatorio.")]
        public string Email { get; set; }

        [MinLength(5,ErrorMessage ="Por favor informe no minimo {1} Caracteres.")]
        [Required(ErrorMessage = "Campo Obrigatorio.")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Campo Obrigatorio.")]
        [Compare("Senha", ErrorMessage ="As senhas não são Iguais.")]
        public string SenhaTeste { get; set; }

        [Required(ErrorMessage = "Campo Obrigatorio.")]
        public string Telefone { get; set; }
    }
}
