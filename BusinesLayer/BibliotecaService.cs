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

        public bool agregar(Autor autor)
        {
            return repositorio.agregarAutor(autor);
        }

        public bool Editar(Autor autor)
        {
            return repositorio.EditarAutor(autor);
        }

        public bool Eliminar(int id)
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

    }
}
