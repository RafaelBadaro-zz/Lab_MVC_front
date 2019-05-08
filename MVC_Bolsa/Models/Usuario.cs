using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Bolsa.Models
{
    public class Usuario
    {
        [Key]
        public long Id { get; set; }

        public string Nome { get; set; }

        public decimal Saldo { get; set; }

    }
}
