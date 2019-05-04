using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Bolsa.Models
{
    public class Acao
    {

        public long ID { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [StringLength(100, ErrorMessage = "O nome não pode exceder 100 caracteres")]
        public string Nome { get; set; }
        [Display(Name = "Preço")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public decimal Preco { get; set; }
    }
}
