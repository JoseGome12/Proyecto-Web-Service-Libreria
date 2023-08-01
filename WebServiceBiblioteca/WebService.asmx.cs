using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Data;
namespace WebServiceBiblioteca
{
    /// <summary>
    /// Descripción breve de WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {

        [WebMethod]
        public bool VerificarCredenciales(string usuario, string contraseña)
        {
            if (usuario == "admin" && contraseña == "admin")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        [WebMethod]
        public bool VerificarUsuario(string usuario, string contraseña)
        {
            using (SqlConnection conexion = new SqlConnection("Data Source=localhost;Initial Catalog=BibliotecaP;Integrated Security=true;"))
            {
                conexion.Open();
                using (SqlCommand cmd = new SqlCommand("Select Usuario, Contraseña from Usuarios where Usuario ='" + usuario + "' and Contraseña ='" + contraseña + "'", conexion))
                {

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        return true;
                    } else
                    {
                        return false;
                    }
                }
            }
        }
        [WebMethod]
        public int IdUsuario(string usuario, string contraseña)
        {
            int id = 0;
            using (SqlConnection conexion = new SqlConnection("Data Source=localhost;Initial Catalog=BibliotecaP;Integrated Security=true;"))
            {
                conexion.Open();
                using (SqlCommand cmd = new SqlCommand("Select idUsuario from Usuarios where Usuario ='" + usuario + "' and Contraseña ='" + contraseña + "'", conexion))
                {

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        id = dr.GetInt32(0);
                        return id;
                    } else
                    {
                        return 0;
                    }

                }
            }

        }
        [WebMethod]
        public bool CrearUsuario(string usuario, string contraseña)
        {
            using (SqlConnection conexion = new SqlConnection("Data Source=localhost;Initial Catalog=BibliotecaP;Integrated Security=true;"))
            {
                conexion.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Usuarios (Usuario, Contraseña) VALUES (@Usuario, @Contraseña)", conexion))
                {
                    cmd.Parameters.AddWithValue("@Usuario", usuario);
                    cmd.Parameters.AddWithValue("@Contraseña", contraseña);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

            }
        }
        [WebMethod]
        public string Verlibros()
        {
            using (SqlConnection conexion = new SqlConnection("Data Source=localhost;Initial Catalog=BibliotecaP;Integrated Security=true;"))
            {
                conexion.Open();
                using (SqlCommand cmd = new SqlCommand("Select idLibro,NombreLibro,Autor,Genero,FechaPublicacion from Libros", conexion))
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable tabla = new DataTable("NombreTabla");
                    tabla.Load(dr);

                    // Crear un DataSet y agregar la DataTable
                    DataSet dataSet = new DataSet();
                    dataSet.Tables.Add(tabla);

                    // Obtener la representación XML del DataSet
                    string xml = dataSet.GetXml();

                    return xml;
                }
            }
        }
        [WebMethod]
        public bool AgregarLibro(string idUsuario, string idLibro)
        {
            using (SqlConnection conexion = new SqlConnection("Data Source=localhost;Initial Catalog=BibliotecaP;Integrated Security=true;"))
            {
                conexion.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Prestamos (idUsuario, idLibro) VALUES (@idUsuario, @idLibro)", conexion))
                {
                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                    cmd.Parameters.AddWithValue("@idLibro", idLibro);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

            }
        }
        [WebMethod]
        public string VerTusLibors(string idUsuario)
        {
            using (SqlConnection conexion = new SqlConnection("Data Source=localhost;Initial Catalog=BibliotecaP;Integrated Security=true;"))
            {
                conexion.Open();
                using (SqlCommand cmd = new SqlCommand("select  Prestamos.idPrestamo, Prestamos.idLibro ,Libros.NombreLibro,Libros.Autor, Libros.Genero from Prestamos inner join Libros on Prestamos.idLibro = Libros.idLibro inner join Usuarios on Prestamos.idUsuario = Usuarios.idUsuario  where Prestamos.idUsuario =" + idUsuario, conexion))
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable tabla = new DataTable("NombreTabla");
                    tabla.Load(dr);

                    // Crear un DataSet y agregar la DataTable
                    DataSet dataSet = new DataSet();
                    dataSet.Tables.Add(tabla);

                    // Obtener la representación XML del DataSet
                    string xml = dataSet.GetXml();

                    return xml;
                }
            }

        }
        [WebMethod]
         public bool EliminarLibro (string idPrestamo)
        {
            using (SqlConnection conexion = new SqlConnection("Data Source=localhost;Initial Catalog=BibliotecaP;Integrated Security=true;"))
            {
                conexion.Open();
                using (SqlCommand cmd = new SqlCommand("delete  from Prestamos where idPrestamo =" + idPrestamo, conexion))
                {

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

            }

        }



    }
}

