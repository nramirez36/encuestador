using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Encuestador.Entities;
using nramirez36.Logger;
using System.Data.OleDb;

namespace Encuestador.DL
{
    public class Respuestas
    {
        public static int RegistrarEncuesta(Respuesta pRespuesta)
        {
            var conexion = OdbcClient.Conectar();
            OleDbTransaction trans = null;
            var filasAfectadas = 0;
            try
            {
                trans = conexion.BeginTransaction();
                string sql = "INSERT INTO Respuesta (IdUsuario, NroEncuesta, IdSitio, IdMotivoViaje, Sentido, IdVehiculo, Patente, FechaEncuesta, IdDistanciaViaje, RespuestaCaso1, RespuestaCaso2, RespuestaCaso3) VALUES (@IdUsuario, @NroEncuesta, @IdSitio, @IdMotivoViaje, @Sentido, @IdVehiculo, @Patente, @FechaEncuesta, @IdDistanciaViaje, @RespuestaCaso1, @RespuestaCaso2, @RespuestaCaso3)";
                var lstParametros = new List<OleDbParameter>();
                lstParametros.Add(new OleDbParameter("@IdUsuario", pRespuesta.IdUsuario));
                lstParametros.Add(new OleDbParameter("@NroEncuesta", pRespuesta.NroEncuesta));
                lstParametros.Add(new OleDbParameter("@IdSitio", pRespuesta.IdSitio));
                lstParametros.Add(new OleDbParameter("@IdMotivoViaje", pRespuesta.IdMotivoViaje));
                lstParametros.Add(new OleDbParameter("@Sentido", pRespuesta.Sentido));
                lstParametros.Add(new OleDbParameter("@IdVehiculo", pRespuesta.IdVehiculo));
                lstParametros.Add(new OleDbParameter("@Patente", pRespuesta.Patente));
                lstParametros.Add(new OleDbParameter("@FechaEncuesta",pRespuesta.FechaEncuesta.ToString()));
                lstParametros.Add(new OleDbParameter("@IdDistanciaViaje", pRespuesta.IdDistanciaViaje));
                lstParametros.Add(new OleDbParameter("@RespuestaCaso1", pRespuesta.RespuestaCaso1));
                lstParametros.Add(new OleDbParameter("@RespuestaCaso2", pRespuesta.RespuestaCaso2));
                lstParametros.Add(new OleDbParameter("@RespuestaCaso3", pRespuesta.RespuestaCaso3));
                filasAfectadas = OdbcClient.EjecutarCommand(sql, lstParametros, conexion,trans);
                if (filasAfectadas > 0)
                    trans.Commit();
            }
            catch (Exception ex)
            {
                Logger.WriteXMLError("Respuestas.cs", "Respuestas.cs", "RegistrarEncuesta", ex.Message);
                if (trans != null)
                    trans.Rollback();
                throw new Exception("No se pudo registrar la encuesta");
            }
            finally
            {
                conexion.Close();
            }
            return filasAfectadas;
        }

    }
}
