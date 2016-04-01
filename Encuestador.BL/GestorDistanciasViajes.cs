using System;
using System.Collections.Generic;
using Encuestador.DL;
using Encuestador.Entities;
namespace Encuestador.BL
{
    public class GestorDistanciasViajes
    {
        public List<DistanciaViaje> ObtenerTodasDistanciasViaje()
        {
            try
            {
                return DistanciasViajes.ObtenerTodasDistanciasViaje();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
