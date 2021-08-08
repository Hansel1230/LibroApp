
namespace Database.Modelos
{
    public class Autor
    {
        //public static Autor Instancia { get; } = new Autor();
        public int ID { get; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }

        public Autor(string Nombre,string Apellido, string Correo)
        {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Correo = Correo;
        }
    }
}
