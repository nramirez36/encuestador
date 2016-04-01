using System;
using System.Collections.Generic;
using Encuestador.Entities;
using Encuestador.DL;
namespace Encuestador.BL
{
    public class GestorSitios
    {
        public List<Sitio> ObtenerTodosSitios()
        {
            try
            {
                return Sitios.ObtenerTodosSitios();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
