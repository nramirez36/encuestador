using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
