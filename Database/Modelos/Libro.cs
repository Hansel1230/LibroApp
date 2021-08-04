using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Modelos
{
    public class Libro
    {
        public int Id { get; set; }
        public int Nombre { get; set; }
        public int Fecha { get; set; }//Fecha de publicacion
        public int IdAutor { get; set; }
        public int IdEditorial { get; set; }
    }
}
