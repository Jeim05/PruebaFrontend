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
        private BLL_Card objCapaDatos = new BLL_Card();

        public List<Card> ObtenerCards()
        {
            return objCapaDatos.ObtenerCards();
        }
    }
}
