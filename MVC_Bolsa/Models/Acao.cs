using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Bolsa.Models
{
    public class Acao
    {
        [Key]
        public long Id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [StringLength(100, ErrorMessage = "O nome não pode exceder 100 caracteres")]
        public string Nome { get; set; }
        [Display(Name = "Preço")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Preco { get; set; }
    }
}
