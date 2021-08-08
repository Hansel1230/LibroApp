using System.Data.SqlClient;
using Database.Modelos;
using Database;
using System.Data;

namespace BusinesLayer
{
    public class BibliotecaService
    {
        private RepositorioBiblioteca repositorio;

        public BibliotecaService(SqlConnection conection)
        {
            repositorio = new RepositorioBiblioteca(conection);
        }

        public bool AgregarAutor(Autor autor)
        {
            return repositorio.AgregarAutor(autor);
        }

        public bool EditarAutor(Autor autor,int autorId)
        {
            return repositorio.EditarAutor(autor,autorId);
        }

        public bool EliminarAutor(int id)
        {
            return repositorio.EliminarAutor(id);
        }

        //areglar
        public void GetById(int id)
        {
            //return  repositorio.GetbyIDAutor(id);
        }

        public DataTable GetAllAutor()
        {
            return repositorio.GetallAutor();
        }

        public DataTable GetallEditoriales()
        {
            return repositorio.GetallEditoriales();
        }

        public DataTable GetAllLibros()
        {
            return repositorio.GetAllLibros();
        }

        public bool ValidarLibro()
        {
            return repositorio.ValidarLibro();
        }
    }
}
