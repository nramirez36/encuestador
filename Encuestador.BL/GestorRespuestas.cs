using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Encuestador.Entities;
using Encuestador.DL;
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
                throw ex;
            }
        }
    }
}
