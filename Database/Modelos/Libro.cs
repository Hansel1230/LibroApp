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
        public string Nombre { get; set; }
        public string Fecha { get; set; }//Fecha de publicacion
        public int IdAutor { get; set; }
        public int IdEditorial { get; set; }

        public Libro(string nombre,string fecha,int idAutor,int idEditorial)
        {
            this.Nombre = nombre;
            this.Fecha = fecha;
            this.IdAutor = idAutor;
            this.IdEditorial = idEditorial;
        }
    }
}
