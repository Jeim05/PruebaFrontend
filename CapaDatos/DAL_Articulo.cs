using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DAL_Articulo
    {
        public List<Articulo> ObtenerArticulos()
        {
            List<Articulo> lista = new List<Articulo>();

            try
            {
                using (SqlConnection oConexion = new SqlConnection(Conexion.conexion))
                {
                    string query = "SELECT IdArticulo, Titulo, Descripcion FROM ARTICULO";
                    SqlCommand cmd = new SqlCommand(query, oConexion);
                    cmd.CommandType = CommandType.Text;
                    oConexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(
                                new Articulo()
                                {
                                    IdArticulo = Convert.ToInt32(reader["IdArticulo"]),
                                    Titulo = reader["Titulo"].ToString(),
                                    Descripcion = reader["Descripcion"].ToString(),
                                });
                        }
                    }
                }
            }
            catch (Exception)
            {
                lista = new List<Articulo>();

            }
            return lista;
        }
    }
}
