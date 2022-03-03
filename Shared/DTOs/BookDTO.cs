using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrowserTravel.Shared.DTOs
{
    public class GETBookDTO
    {
        public int id { get; set; }
        public string titulo { get; set; }
        public string urlImagen { get; set; }
        public int paginas { get; set; }
        public string nombreEditorial { get; set; }

        public ICollection<string> _autores { get; set; }
    }
    public class GETBookIdDTO
    {
        public string titulo { get; set; }
        public int paginas { get; set; }
        public string urlImagen { get; set; }
        public string nombreEditorial { get; set; }
        public string sedeEditorial { get; set; }
        public string sinopsis { get; set; }

        public ICollection<string> _autores { get; set; }
    }
}
