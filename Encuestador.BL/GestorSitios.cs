using System;
using System.Collections.Generic;
using Encuestador.Entities;
using Encuestador.DL;
using nramirez36.Logger;
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
                Logger.WriteXMLError("GestorSitios.cs", "GestorSitios.cs", "ObtenerTodosSitios", ex.Message);
                throw ex;
            }
        }
    }
}
