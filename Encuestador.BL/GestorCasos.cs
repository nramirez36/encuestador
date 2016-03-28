using System;
using System.Collections.Generic;
using Encuestador.DL;
using Encuestador.Entities;
using nramirez36.Logger;

namespace Encuestador.BL
{
    public class GestorCasos
    {
        public List<Caso> ObtenerCasosPorIdDistancia(int pIdDistancia)
        {
            try
            {
                return Casos.ObtenerCasosPorIdDistancia(pIdDistancia);
            }
            catch (Exception ex)
            {
                Logger.WriteXMLError("GestorCasos.cs", "GestorCasos.cs", "ObtenerCasosPorIdDistancia", ex.Message);
                throw ex;
            }
        }
        public List<Caso> ObtenerTodosCasos()
        {
            try
            {
                return Casos.ObtenerTodosCasos();
            }
            catch (Exception ex)
            {
                Logger.WriteXMLError("GestorCasos.cs", "GestorCasos.cs", "ObtenerTodosCasos", ex.Message);
                throw ex;
            }
        }
    }
}
