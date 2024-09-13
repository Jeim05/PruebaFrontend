using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaDatos
{
    public class DAL_Card
    {
        public List<Card> ObtenerCards()
        {
            List<Card> lista = new List<Card>();

            try
            {
                using (SqlConnection oConexion = new SqlConnection(Conexion.conexion))
                {
                    string query = " SELECT IdCard, TituloPrincipal, SubTitulo, TextoCardInformativo FROM CARD";
                    SqlCommand cmd = new SqlCommand(query, oConexion);
                    cmd.CommandType = CommandType.Text;
                    oConexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read()) {
                            lista.Add(
                                new Card()
                                {
                                    IdCard = Convert.ToInt32(reader["IdCard"]),
                                    TituloPrincipal = reader["TituloPrincipal"].ToString(),
                                    SubTitulo = reader["Subtitulo"].ToString(),
                                    TextoCardInformativo = reader["TextoCardInformativo"].ToString(),
                                });
                        }
                    }
                }
            }
            catch (Exception)
            {
                lista = new List<Card>();
                
            }
            return lista;
        }

    }
}
