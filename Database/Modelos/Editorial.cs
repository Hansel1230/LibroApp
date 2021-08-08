namespace Database.Modelos
{
    public class Editorial
    {
        public int Id { get; }
        public string Nombre { get; set; }
        public string Pais { get; set; }
        public string Telefono { get; set; }

        public Editorial(string nombre, string pais, string telefono)
        {
            this.Nombre = nombre;
            this.Pais = pais;
            this.Telefono = telefono;
        }
    }
}
