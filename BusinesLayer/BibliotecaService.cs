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


        #region Metodos

        #region Autor
        //Autor
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

        #endregion

        #region Editorial
        //Editorial
        public bool AgregarEditorial(Editorial editorial)
        {
            return repositorio.AgregarEditorial(editorial);
        }

        public bool EditarEditorial(Editorial editorial, int editorialId)
        {
            return repositorio.EditarEditorial(editorial, editorialId);
        }

        public bool EliminarEditorial(int id)
        {
            return repositorio.EliminarEditorial(id);
        }

        #endregion

        #region Libro
        //Libro
        public bool AgregarLibro(Libro libro)
        {
            return repositorio.AgregarLibro(libro);
        }

        public bool EditarLibro(Libro libro, int librolId)
        {
            return repositorio.EditarLibro(libro, librolId);
        }

        public bool EliminarLibro(int id)
        {
            return repositorio.EliminarLibro(id);
        }

        #endregion

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
        #endregion
    }
}
