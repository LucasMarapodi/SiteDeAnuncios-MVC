using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Presentation.Mvc.Models.VendedorModels
{
    public class VendedorLoguinModel
    {
        [Required(ErrorMessage = "Campo Obrigatorio.")]
        [EmailAddress(ErrorMessage ="Informe um Email Valido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo Obrigatorio.")]
        public string Senha { get; set; }
    }
}
