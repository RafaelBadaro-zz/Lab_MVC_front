using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Bolsa.Models
{
    public class AcaoUsuario
    {
        [Key]
        public long Id { get; set; }
        
        public long IdUsuarioForeignKey { get; set; }
        [ForeignKey("IdUsuarioForeignKey")]
        public Usuario IdUsuario { get; set; }

        public long IdAcaoForeignKey { get; set; }
        [ForeignKey("IdAcaoForeignKey")]
        public Acao IdAcao { get; set; }

        public int Quantidade { get; set; }

    }
}
