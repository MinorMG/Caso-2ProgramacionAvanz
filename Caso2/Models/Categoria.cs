using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Caso2.Models
{
    public class Categoria
    {

        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
        public DateTime FechaRegistro { get; set; }

        [ForeignKey("UsuarioRegistro")]
        public string UsuarioRegistroId { get; set; } // Id del usuario que creó la categoría
        public virtual ApplicationUser UsuarioRegistro { get; set; }

        public virtual ICollection<Conferencia> Conferencias { get; set; }

    }
}