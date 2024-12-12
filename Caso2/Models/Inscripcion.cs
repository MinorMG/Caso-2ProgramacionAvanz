using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Caso2.Models
{
    public class Inscripcion
    {

        [Key]
        public int Id { get; set; }

        [ForeignKey("Usuario")]
        public string UsuarioId { get; set; } // Id del usuario, que coincide con el Id de IdentityUser
        public virtual ApplicationUser Usuario { get; set; }

        [ForeignKey("Conferencia")]
        public int ConferenciaId { get; set; }
        public virtual Conferencia Conferencia { get; set; }

    }
}