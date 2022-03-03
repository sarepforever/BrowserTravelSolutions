using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BrowserTravel.Server.Entities
{
    public class Editorial
    {
        public int id { get; set; }

        [MaxLength(45)]
        public string nombre { get; set; }

        [MaxLength(45)]
        public string sede { get; set; }

        public virtual ICollection<Libro> _libros { get; set; }
    }
}
