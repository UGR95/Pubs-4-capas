using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;

namespace CapaNegocio
{
    public class N_Titulos
    {
        public List<E_Titulos> ObtenerTitluos()
        {
            D_Titulos pubsTitulo = new D_Titulos();
            return pubsTitulo.ObtenerTitulos();
        }
    }
}
