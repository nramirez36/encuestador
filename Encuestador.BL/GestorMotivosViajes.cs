using System;
using System.Collections.Generic;
using Encuestador.Entities;
using Encuestador.DL;
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
                throw ex;
            }
        }
    }
}
