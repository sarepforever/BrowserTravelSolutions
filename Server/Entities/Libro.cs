using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrowserTravel.Server.Entities
{
    public class Libro
    {
        public int id { get; set; }

        public int editorialId { get; set; }

        [MaxLength(45)]
        public string titulo { get; set; }

        [MaxLength(200)]
        public string urlImagen { get; set; }

        public string sinopsis { get; set; }

        public int numPaginas { get; set; }

        public virtual ICollection<Autor_has_libro> _Autor_Has_Libros { get; set; }

        [ForeignKey("editorialId")]
        public virtual Editorial Editorial { get; set; }
    }
}
