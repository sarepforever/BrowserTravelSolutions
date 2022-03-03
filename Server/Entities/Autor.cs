using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BrowserTravel.Server.Entities
{
    public class Autor
    {
        public int id { get; set; }

        [MaxLength(45)]       
        public string nombre { get; set; }

        [MaxLength(45)]
        public string apellidos { get; set; }

        public virtual ICollection<Autor_has_libro> _Autor_Has_Libros { get; set; }
    }
}
