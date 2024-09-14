using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class BLL_Card
    {
        private DAL_Card objCapaDatos = new DAL_Card();

        public List<Card> ObtenerCards()
        {
            return objCapaDatos.ObtenerCards();
        }
    }
}
