using System;
using System.Collections.Generic;
using Encuestador.DL;
using Encuestador.Entities;
namespace Encuestador.BL
{
    public class GestorDistanciasViajes
    {
        public List<TiempoViaje> ObtenerTodosTiemposViaje()
        {
            try
            {
                return TiemposViajes.ObtenerTodosTiemposViaje();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
