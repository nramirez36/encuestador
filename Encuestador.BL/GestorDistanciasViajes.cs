using System;
using System.Collections.Generic;
using Encuestador.DL;
using Encuestador.Entities;
using nramirez36.Logger;
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
                Logger.WriteXMLError("GestorDistanciasViajes.cs", "GestorDistanciasViajes.cs", "ObtenerTodasDistanciasViaje", ex.Message);
                throw ex;
            }
        }
    }
}
