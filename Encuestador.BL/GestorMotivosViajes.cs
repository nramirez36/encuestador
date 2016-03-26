using System;
using System.Collections.Generic;
using Encuestador.Entities;
using Encuestador.DL;
using nramirez36.Logger;
namespace Encuestador.BL
{
    public class GestorMotivosViajes
    {
        public List<MotivoViaje> ObtenerTodosMotivosViaje()
        {
            try
            {
                return MotivosViajes.ObtenerTodosMotivosViaje();
            }
            catch (Exception ex)
            {
                Logger.WriteXMLError("GestorMotivosViajes.cs", "GestorMotivosViajes.cs", "ObtenerTodosMotivosViaje", ex.Message);
                throw;
            }
        }
    }
}
