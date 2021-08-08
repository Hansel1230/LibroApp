using Database.Modelos;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Database
{
    public class RepositorioBiblioteca
    {
        private SqlConnection _coneccion;

        public RepositorioBiblioteca(SqlConnection Coneccion)
        {
            _coneccion = Coneccion;
        }

        public bool AgregarAutor(Autor item)
        {
            SqlCommand command = new SqlCommand("insert into Autores1(Nombre,Apellido,Correo)" +
                " values (@nombre,@apellido,@correo) ", _coneccion);
            
            command.Parameters.AddWithValue("@nombre", item.Nombre);
            command.Parameters.AddWithValue("@apellido", item.Apellido);
            command.Parameters.AddWithValue("@correo", item.Correo);
            
            return ExecuteDml(command);
        }

        public bool EditarAutor(Autor item,int AutorId)
        {
            SqlCommand command = new SqlCommand("update Autores1 set Nombre=@nombre,Apellido=@apellido,Correo=@correo where id=@id", _coneccion);


            command.Parameters.AddWithValue("@nombre", item.Nombre);
            command.Parameters.AddWithValue("@apellido", item.Apellido);
            command.Parameters.AddWithValue("@correo", item.Correo);
            command.Parameters.AddWithValue("@id", AutorId);

            return ExecuteDml(command);
        }

        public bool EliminarAutor(int id)
        {
            SqlCommand command = new SqlCommand("delete Autores1 where id=@id", _coneccion);

            command.Parameters.AddWithValue("@id", id);

            return ExecuteDml(command);
        }

        //Hansel: arreglar
        public void GetbyIDAutor(int id)
        {
            /*
            try
            {
                _coneccion.Open();

                SqlCommand command = new SqlCommand("Select id,Nombre,Apellido,Correo from Autores1 " +
                    "where @id=id", _coneccion);

                command.Parameters.AddWithValue("@id",id);

                Autor data = new Autor();

                SqlDataReader reader = command.ExecuteReader();

                Autor returnData = new Autor();


                while (reader.Read())
                {

                    data.ID = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                    data.Nombre = reader.IsDBNull(1) ? "" : reader.GetString(1);
                    data.Apellido = reader.IsDBNull(2) ? "" : reader.GetString(2);
                    data.Correo = reader.IsDBNull(3) ? "" : reader.GetString(3);

                }
                reader.Close();
                reader.Dispose();

                _coneccion.Close();


                return returnData;

            }
            catch(Exception e)
            {
                return null;
            }
            */
        }

        public DataTable GetallAutor()
        {
            SqlDataAdapter query = new SqlDataAdapter("select id as Codigo,Nombre,Apellido,Correo from Autores1",_coneccion);

            return LoadData(query);
        }

        public DataTable GetallEditoriales()
        {
            SqlDataAdapter query = new SqlDataAdapter("select id as Codigo,Nombre,Telefono,Pais from Editoriales", _coneccion);

            return LoadData(query);
        }

        public DataTable GetAllLibros()
        {
            SqlDataAdapter query = new SqlDataAdapter("SELECT Libros.id as Codigo,Libros.Nombre as 'Nombre Libro'" +
                ",Libros.Fecha_Publicacion as 'fecha publicacion',Autores1.Nombre as 'Nombre Autor'," +
                " Editoriales.Nombre as 'Nombre Editorial' FROM Libros" +
                " inner join Autores1 on ( Libros.id_Autor = Autores1.id)  " +
                " inner join Editoriales on ( Libros.id_Editorial = Editoriales.id)", _coneccion);
            return LoadData(query);
        }

        private DataTable LoadData(SqlDataAdapter query)
        {
            try
            {
                DataTable data = new DataTable();

                _coneccion.Open();

                query.Fill(data);

                _coneccion.Close();

                return data;

            }
            catch (Exception e)
            {
                return null;
            }
        }

        public bool ValidarLibro()
        {
            SqlDataAdapter Editorial = new SqlDataAdapter("select * from Editoriales", _coneccion);
            int EditorialCantidad = LoadData(Editorial).Rows.Count;

            SqlDataAdapter Autor = new SqlDataAdapter("select * from Autores1", _coneccion);
            int AutorCantidad = LoadData(Autor).Rows.Count;

            if ((EditorialCantidad==0) || (AutorCantidad == 0))
            {
                return false;
            }

            return true;
        }

        public bool ExecuteDml(SqlCommand query)
        {
            try
            {
                _coneccion.Open();

                query.ExecuteNonQuery();

                _coneccion.Close();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
