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
        public string RegistrarEncuestaXUsuario(int pIdUsuario, string pNombreUsuario, string pAmPm)
        {
            try
            {
                return Respuestas.RegistrarEncuestaXUsuario(pIdUsuario, pNombreUsuario, pAmPm);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int EliminarEncuestaXUsuario(string pNroEncuesta, int pIdEncuesta, int pIdUser)
        {
            try
            {
                return Respuestas.EliminarEncuestaXUsuario(pNroEncuesta, pIdEncuesta, pIdUser);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
