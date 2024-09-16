using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class BLL_Articulo
    {
        private DAL_Articulo objCapaDatos = new DAL_Articulo();

        public List<Articulo> ObtenerArticulos()
        {
            return objCapaDatos.ObtenerArticulos();
        }
    }
}
