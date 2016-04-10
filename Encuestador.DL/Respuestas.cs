using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Encuestador.Entities;

using System.Data.OleDb;
using System.Data;

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
                //TODO 01: Revisar y actualizar este query ya que se modifico la tabla participante
                string sql = "INSERT INTO Respuesta (IdUsuario, NroEncuesta, IdSitio, IdMotivoViaje, Sentido, IdVehiculo, PatenteLetras, PatenteNumero, FechaEncuesta, IdDistanciaViaje, RespuestaCaso1, RespuestaCaso2, RespuestaCaso3, PatenteExtranjera) VALUES (@IdUsuario, @NroEncuesta, @IdSitio, @IdMotivoViaje, @Sentido, @IdVehiculo, @PatenteLetras, @PatenteNumero, @FechaEncuesta, @IdDistanciaViaje, @RespuestaCaso1, @RespuestaCaso2, @RespuestaCaso3, @PatenteExtranjera)";
                var lstParametros = new List<OleDbParameter>();
                lstParametros.Add(new OleDbParameter("@IdUsuario", pRespuesta.IdUsuario));
                lstParametros.Add(new OleDbParameter("@NroEncuesta", pRespuesta.NroEncuesta));
                lstParametros.Add(new OleDbParameter("@IdSitio", pRespuesta.IdSitio));
                lstParametros.Add(new OleDbParameter("@IdMotivoViaje", pRespuesta.IdMotivoViaje));
                lstParametros.Add(new OleDbParameter("@Sentido", pRespuesta.Sentido));
                lstParametros.Add(new OleDbParameter("@IdVehiculo", pRespuesta.IdVehiculo));
                lstParametros.Add(new OleDbParameter("@PatenteLetras", pRespuesta.PatenteLetras));
                lstParametros.Add(new OleDbParameter("@PatenteNumero", pRespuesta.PatenteNumero));
                lstParametros.Add(new OleDbParameter("@FechaEncuesta", pRespuesta.FechaEncuesta.ToString()));
                lstParametros.Add(new OleDbParameter("@IdDistanciaViaje", pRespuesta.IdDistanciaViaje));
                lstParametros.Add(new OleDbParameter("@RespuestaCaso1", pRespuesta.RespuestaCaso1));
                lstParametros.Add(new OleDbParameter("@RespuestaCaso2", pRespuesta.RespuestaCaso2));
                lstParametros.Add(new OleDbParameter("@RespuestaCaso3", pRespuesta.RespuestaCaso3));
                lstParametros.Add(new OleDbParameter("@PatenteExtranjera", pRespuesta.PatenteExtranjera));
                filasAfectadas = OdbcClient.EjecutarCommand(sql, lstParametros, conexion, trans);
                if (filasAfectadas > 0)
                    trans.Commit();
            }
            catch (Exception ex)
            {
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
        public static int EliminarEncuesta(EncuestaReportar pEncuestas)
        {
            var conexion = OdbcClient.Conectar();
            OleDbTransaction trans = null;
            var filasAfectadas = 0;
            try
            {
                trans = conexion.BeginTransaction();
                string comando = "DELETE FROM Respuesta WHERE  (IdRespuesta = @id)";
                var lstParametros = new List<OleDbParameter>();
                lstParametros.Add(new OleDbParameter("@id", pEncuestas.IdRespuesta));
                filasAfectadas = OdbcClient.EjecutarCommand(comando, lstParametros, conexion, trans);
                if (filasAfectadas > 0)
                    trans.Commit();
            }
            catch (Exception)
            {
                if (trans != null)
                {
                    trans.Rollback();
                }
                throw new Exception("No se pudo borrar la encuesta");
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            return filasAfectadas;
        }
        public static List<EncuestaReportar> ObtenerEncuestas()
        {
            var conexion = OdbcClient.Conectar();
            EncuestaReportar encu = null;
            List<EncuestaReportar> lstEncuestas = new List<EncuestaReportar>();
            try
            {
                string sql = "SELECT R.NroEncuesta, R.Sentido, R.Patente, R.FechaEncuesta, R.RespuestaCaso1, R.RespuestaCaso2, R.RespuestaCaso3, V.Descripcion, U.[User] AS Usuario, M.Descripcion AS Motivo, S.Descripcion AS Sitio, C.TiempoRuta1, C.TiempoRuta2, C.TiempoRuta3, C.CostoRuta1, C.CostoRuta2, C.CostoRuta3, C.OrdenCaso, R.IdRespuesta FROM ((((((Respuesta R INNER JOIN Vehiculos V ON R.IdVehiculo = V.IdVehiculo) INNER JOIN Login U ON R.IdUsuario = U.IdEncuestador) INNER JOIN MotivoViaje M ON R.IdMotivoViaje = M.IdMotivoViaje) INNER JOIN Sitios S ON R.IdSitio = S.IdSitios) INNER JOIN DistanciaViaje D ON R.IdDistanciaViaje = D.IdDistanciaViaje) INNER JOIN Casos C ON D.IdDistanciaViaje = C.IdDistanciaViaje)";
                var dr = OdbcClient.GenerarReader(sql, conexion);
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        encu = new EncuestaReportar();
                        encu.IdRespuesta = int.Parse(dr["IdRespuesta"].ToString());
                        encu.NroEncuesta = int.Parse(dr["NroEncuesta"].ToString());
                        //encu.UsuarioConectado = dr["User"].ToString();
                        lstEncuestas.Add(encu);
                        encu = null;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Hubo un problema al Obtener las Encuestas");
            }
            finally
            {
                conexion.Close();
            }
            return lstEncuestas;
        }

        public static List<EncuestaReportar> ObtenerEncuestasParametros(DateTime pFechaDesde, DateTime pFechaHasta, int pIdUsuario)
        {
            var conexion = OdbcClient.Conectar();
            EncuestaReportar encu = null;
            List<EncuestaReportar> lstEncuestas = new List<EncuestaReportar>();
            try
            {
                //TODO 02: Revisar y actualizar este query ya que se modifico la tabla participante
                //TODO 03: Ver el tema del fitro por fechas
                //TODO 04: Ver el tema de que si hay que borrar los datos una vez que ya se hizo el export
                string sql = "SELECT R.NroEncuesta, R.Sentido, R.Patente, R.FechaEncuesta, R.RespuestaCaso1, R.RespuestaCaso2, R.RespuestaCaso3, V.Descripcion as TipoVehiculo, U.[User] AS Usuario, M.Descripcion AS Motivo, S.Descripcion AS Sitio, C.TiempoRuta1, C.TiempoRuta2, C.TiempoRuta3, C.CostoRuta1, C.CostoRuta2, C.CostoRuta3, C.OrdenCaso, R.IdRespuesta FROM ((((((Respuesta R INNER JOIN Vehiculos V ON R.IdVehiculo = V.IdVehiculo) INNER JOIN Login U ON R.IdUsuario = U.IdEncuestador) INNER JOIN MotivoViaje M ON R.IdMotivoViaje = M.IdMotivoViaje) INNER JOIN Sitios S ON R.IdSitio = S.IdSitios) INNER JOIN DistanciaViaje D ON R.IdDistanciaViaje = D.IdDistanciaViaje) INNER JOIN Casos C ON D.IdDistanciaViaje = C.IdDistanciaViaje) where 1=1 ";
                var lstParametros = new List<OleDbParameter>();
                //if (pFechaDesde < DateTime.Now)
                //{
                //    sql += " and R.FechaEncuesta >= @fechaDesde";
                //    lstParametros.Add(new OleDbParameter("@fechaDesde", pFechaDesde.ToString()));
                //}
                //if (pFechaHasta < DateTime.Now)
                //{
                //    sql += " and R.FechaEncuesta <= @fechaHasta";
                //    lstParametros.Add(new OleDbParameter("@fechaHasta", pFechaHasta.ToString()));
                //}
                if (pIdUsuario != 0)
                {
                    sql += " and U.IdEncuestador = @usuario";
                    lstParametros.Add(new OleDbParameter("@usuario", pIdUsuario));
                }

                var dr = OdbcClient.GenerarReader(sql, lstParametros, conexion);

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        encu = new EncuestaReportar();

                        encu.FechaEncuesta = DateTime.Parse(dr["FechaEncuesta"].ToString());

                        if (pFechaDesde >= encu.FechaEncuesta || pFechaHasta <= encu.FechaEncuesta)
                        {
                            encu.NroEncuesta = int.Parse(dr["NroEncuesta"].ToString());
                            encu.Sentido = dr["Sentido"].ToString();
                            encu.Patente = dr["Patente"].ToString();

                            encu.RespuestaCaso1 = int.Parse(dr["RespuestaCaso1"].ToString());
                            encu.RespuestaCaso2 = int.Parse(dr["RespuestaCaso2"].ToString());
                            encu.RespuestaCaso3 = int.Parse(dr["RespuestaCaso3"].ToString());
                            encu.TipoVehiculo = dr["TipoVehiculo"].ToString();
                            encu.UsuarioConectado = dr["Usuario"].ToString();
                            encu.Motivo = dr["Motivo"].ToString();
                            encu.Sitio = dr["Sitio"].ToString();
                            encu.TiempoRuta1 = int.Parse(dr["TiempoRuta1"].ToString());
                            encu.TiempoRuta2 = int.Parse(dr["TiempoRuta2"].ToString());
                            encu.TiempoRuta3 = int.Parse(dr["TiempoRuta3"].ToString());
                            encu.CostoRuta1 = dr["CostoRuta1"].ToString();
                            encu.CostoRuta2 = dr["CostoRuta2"].ToString();
                            encu.CostoRuta3 = dr["CostoRuta3"].ToString();
                            encu.OrdenCaso = int.Parse(dr["OrdenCaso"].ToString());
                            encu.IdRespuesta = int.Parse(dr["IdRespuesta"].ToString());
                            lstEncuestas.Add(encu);
                        }
                        encu = null;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Hubo un problema al Obtener las Encuestas");
            }
            finally
            {
                conexion.Close();
            }
            return lstEncuestas;
        }
    }
}
