using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Caso2.Models
{
    public class Conferencia
    {

        [Key]
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaHora { get; set; }
        public int Duracion { get; set; }
        public int CupoMaximo { get; set; }

        [ForeignKey("Categoria")]
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }

        // Otras propiedades como Ubicación, Imagen, etc.
        public virtual ICollection<Inscripcion> Inscripciones { get; set; }

    }
}