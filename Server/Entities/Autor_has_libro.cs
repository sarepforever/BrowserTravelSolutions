using System.ComponentModel.DataAnnotations.Schema;

namespace BrowserTravel.Server.Entities
{
    public class Autor_has_libro
    {
        public int autorId { get; set; }
        public int libroId { get; set; }

        [ForeignKey("autorId")]
        public virtual Autor Autor { get; set; }

        [ForeignKey("libroId")]
        public virtual Libro Libro { get; set; }
    }
}
