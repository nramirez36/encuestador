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
    public class GestorRespuestas
    {
        public int RegistrarEncuesta(Respuesta pRespuesta)
        {
            try
            {
                return Respuestas.RegistrarEncuesta(pRespuesta);
            }
            catch (Exception ex)
            {
                Logger.WriteXMLError("GestorRespuestas.cs", "GestorRespuestas.cs", "RegistrarEncuesta", ex.Message);
                throw ex;
            }
        }
        public int EliminarEncuesta(EncuestaReportar pRespuesta)
        {
            try
            {
                return Respuestas.EliminarEncuesta(pRespuesta);
            }
            catch (Exception ex)
            {
                Logger.WriteXMLError("GestorRespuestas.cs", "GestorRespuestas.cs", "EliminarEncuesta", ex.Message);
                throw ex;
            }
        }
        public List<EncuestaReportar> ObtenerEncuestas()
        {
            try
            {
                return Respuestas.ObtenerEncuestas();
            }
            catch (Exception ex)
            {
                Logger.WriteXMLError("GestorRespuestas.cs", "GestorRespuestas.cs", "ObtenerEncuestas", ex.Message);
                throw ex;
            }
        }
        public List<EncuestaReportar> ObtenerEncuestasParametros(DateTime pFechaDesde, DateTime pFechaHasta, int pIdUsuario)
        {
            try
            {
                return Respuestas.ObtenerEncuestasParametros(pFechaDesde, pFechaHasta, pIdUsuario);
            }
            catch (Exception ex)
            {
                Logger.WriteXMLError("GestorRespuestas.cs", "GestorRespuestas.cs", "ObtenerEncuestasParametros", ex.Message);
                throw ex;
            }
        }
    }
}
