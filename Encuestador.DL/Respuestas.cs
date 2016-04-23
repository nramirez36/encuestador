using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Encuestador.Entities;

using System.Data.OleDb;
using System.Data;
using System.Globalization;

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

                string sql = "INSERT INTO Respuesta (IdUsuario, NroEncuesta, IdSitio, IdMotivoViaje, Sentido, IdVehiculo, PatenteLetras, PatenteNumero, FechaEncuesta, HoraEncuesta, DistanciaViaje, RespuestaCaso1, RespuestaCaso2, RespuestaCaso3, PatenteExtranjera, IdTiempoViaje) VALUES (@IdUsuario, @NroEncuesta, @IdSitio, @IdMotivoViaje, @Sentido, @IdVehiculo, @PatenteLetras, @PatenteNumero, @FechaEncuesta, @HoraEncuesta, @IdDistanciaViaje, @RespuestaCaso1, @RespuestaCaso2, @RespuestaCaso3, @PatenteExtranjera, @IdTiempoViaje)";
                var lstParametros = new List<OleDbParameter>();
                lstParametros.Add(new OleDbParameter("@IdUsuario", pRespuesta.IdUsuario));
                lstParametros.Add(new OleDbParameter("@NroEncuesta", pRespuesta.NroEncuesta));
                lstParametros.Add(new OleDbParameter("@IdSitio", pRespuesta.IdSitio));
                lstParametros.Add(new OleDbParameter("@IdMotivoViaje", pRespuesta.IdMotivoViaje));
                lstParametros.Add(new OleDbParameter("@Sentido", pRespuesta.Sentido));
                lstParametros.Add(new OleDbParameter("@IdVehiculo", pRespuesta.IdVehiculo));
                lstParametros.Add(new OleDbParameter("@PatenteLetras", pRespuesta.PatenteLetras));
                lstParametros.Add(new OleDbParameter("@PatenteNumero", pRespuesta.PatenteNumero));
                lstParametros.Add(new OleDbParameter("@FechaEncuesta", pRespuesta.FechaEncuesta.ToOADate()));
                //lstParametros.Add(new OleDbParameter("@HoraEncuesta", pRespuesta.FechaEncuesta.ToShortTimeString()));

                lstParametros.Add(new OleDbParameter("@HoraEncuesta", pRespuesta.FechaEncuesta.ToString("hh:mm:ss tt", CultureInfo.InvariantCulture)));
                lstParametros.Add(new OleDbParameter("@IdDistanciaViaje", pRespuesta.DistanciaViaje));
                lstParametros.Add(new OleDbParameter("@RespuestaCaso1", pRespuesta.RespuestaCaso1));
                lstParametros.Add(new OleDbParameter("@RespuestaCaso2", pRespuesta.RespuestaCaso2));
                lstParametros.Add(new OleDbParameter("@RespuestaCaso3", pRespuesta.RespuestaCaso3));
                lstParametros.Add(new OleDbParameter("@PatenteExtranjera", pRespuesta.PatenteExtranjera));
                lstParametros.Add(new OleDbParameter("@IdTiempoViaje", pRespuesta.IdTiempoViaje));


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

        public static List<EncuestaReportar> ObtenerEncuestasParametros(DateTime pFechaDesde, DateTime pFechaHasta, int pIdUsuario)
        {
            var conexion = OdbcClient.Conectar();
            EncuestaReportar encu = null;
            List<EncuestaReportar> lstEncuestas = new List<EncuestaReportar>();
            try
            {
                string sql = "SELECT R.NroEncuesta, R.IdRespuesta, R.IdSitio, S.Descripcion AS Sitio, R.Sentido, L.[User] AS Usuario, R.FechaEncuesta, R.HoraEncuesta, V.Descripcion AS TipoVehiculo, R.PatenteLetras, R.PatenteNumero, R.PatenteExtranjera, R.DistanciaViaje, TV.Descripcion AS TiempoViaje, R.RespuestaCaso1, R.RespuestaCaso2, R.RespuestaCaso3, MV.Descripcion AS Motivo FROM (((((Respuesta R INNER JOIN Sitios S ON R.IdSitio = S.IdSitios) INNER JOIN Login L ON R.IdUsuario = L.IdEncuestador) INNER JOIN Vehiculos V ON R.IdVehiculo = V.IdVehiculo) INNER JOIN TiempoViaje TV ON R.IdTiempoViaje = TV.IdTiempoViaje) INNER JOIN MotivoViaje MV ON R.IdMotivoViaje = MV.IdMotivoViaje) WHERE (1 = 1) ";

                var lstParametros = new List<OleDbParameter>();
                if (pFechaDesde < DateTime.Now)
                {
                    sql += " and R.FechaEncuesta >= @fechaDesde";
                    lstParametros.Add(new OleDbParameter("@fechaDesde", pFechaDesde.ToOADate()));
                }
                if (pFechaHasta < DateTime.Now)
                {
                    sql += " and R.FechaEncuesta <= @fechaHasta";
                    lstParametros.Add(new OleDbParameter("@fechaHasta", pFechaHasta.ToOADate()));
                }
                if (pIdUsuario != 0)
                {
                    sql += " and R.IdUsuario = @usuario";
                    lstParametros.Add(new OleDbParameter("@usuario", pIdUsuario));
                }

                var dr = OdbcClient.GenerarReader(sql, lstParametros, conexion);

                if (dr.HasRows)
                {

                    while (dr.Read())
                    {
                        encu = new EncuestaReportar();
                        encu.FechaEncuesta = DateTime.Parse(dr["FechaEncuesta"].ToString()).ToShortDateString();

                        encu.NroEncuesta = dr["NroEncuesta"].ToString();
                        encu.IdRespuesta = int.Parse(dr["IdRespuesta"].ToString());
                        encu.IdSitio = int.Parse(dr["IdSitio"].ToString());
                        encu.Sitio = dr["Sitio"].ToString();
                        encu.Sentido = dr["Sentido"].ToString();
                        encu.Usuario = dr["Usuario"].ToString();

                        encu.HoraEncuesta = DateTime.Parse(dr["HoraEncuesta"].ToString()).ToShortTimeString();
                        //encu.HoraEncuesta = dr["HoraEncuesta"].ToString();
                        encu.TipoVehiculo = dr["TipoVehiculo"].ToString();

                        var placaLetras = dr["PatenteLetras"].ToString();
                        var placaNumero = dr["PatenteNumero"].ToString();
                        var placaExtranjera = dr["PatenteExtranjera"].ToString();
                        if (!string.IsNullOrEmpty(placaExtranjera))
                            encu.Placa = placaExtranjera;
                        else
                            encu.Placa = placaLetras + "-" + placaNumero;

                        encu.Distancia = dr["DistanciaViaje"].ToString();
                        encu.TiempoViaje = dr["TiempoViaje"].ToString();
                        encu.Motivo = dr["Motivo"].ToString();

                        encu.RespuestaCaso1 = int.Parse(dr["RespuestaCaso1"].ToString());
                        encu.RespuestaCaso2 = int.Parse(dr["RespuestaCaso2"].ToString());
                        encu.RespuestaCaso3 = int.Parse(dr["RespuestaCaso3"].ToString());

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


        public static string RegistrarEncuestaXUsuario(int pIdUsuario, string pNombreUsuario, string pAmPm)
        {
            var conexion = OdbcClient.Conectar();
            OleDbTransaction trans = null;
            var filasAfectadas = 0;
            try
            {
                trans = conexion.BeginTransaction();
                string sql = "INSERT INTO NroEncuestaXUsuario (IdUsuario) VALUES (@IdUsuario)";
                var lstParametros = new List<OleDbParameter>();
                lstParametros.Add(new OleDbParameter("@IdUsuario", pIdUsuario));
                filasAfectadas = OdbcClient.EjecutarCommand(sql, lstParametros, conexion, trans);

                sql = "SELECT @@Identity";
                var idEncuesta = int.Parse(OdbcClient.EjecutarScalar(sql, conexion, trans));
                //var nroEncuesta = pNombreUsuario + "-"+pAmPm+"-"+idEncuesta.ToString().PadLeft(6, '0');
                int turno = 0;
                int horario = 0;
                if (pNombreUsuario.ToUpper() == "MAÑANA")
                    turno = 01;
                if (pNombreUsuario.ToUpper() == "TARDE")
                    turno = 02;
                if (pNombreUsuario.ToUpper() == "ADMIN")
                    turno = 03;
                if (pAmPm.ToUpper() == "AM")
                    horario = 001;
                if (pAmPm.ToUpper() == "PM")
                    horario = 002;

                var nroEncuesta = turno.ToString().PadLeft(2, '0') + "-" + horario.ToString().PadLeft(3, '0') + "-" + idEncuesta.ToString().PadLeft(6, '0');

                sql = "UPDATE NroEncuestaXUsuario SET NroEncuesta = @NroEncuesta WHERE IdEncuesta = @IdEncuesta AND IdUsuario = @IdUsuario";
                lstParametros = new List<OleDbParameter>();
                lstParametros.Add(new OleDbParameter("@NroEncuesta", nroEncuesta));
                lstParametros.Add(new OleDbParameter("@IdEncuesta", idEncuesta));
                lstParametros.Add(new OleDbParameter("@IdUsuario", pIdUsuario));
                filasAfectadas = OdbcClient.EjecutarCommand(sql, lstParametros, conexion, trans);
                if (filasAfectadas > 0)
                    trans.Commit();

                return nroEncuesta+"*"+idEncuesta;

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
        }

        public static int EliminarEncuestaXUsuario(string pNroEncuesta, int pIdEncuesta, int pIdUser)
        {
            var conexion = OdbcClient.Conectar();
            OleDbTransaction trans = null;
            var filasAfectadas = 0;
            try
            {
                trans = conexion.BeginTransaction();
                string comando = "DELETE FROM NroEncuestaXUsuario WHERE  NroEncuesta = @NroEncuesta and IdEncuesta = @IdEncuesta AND IdUsuario = @IdUsuario";
                var lstParametros = new List<OleDbParameter>();
                lstParametros.Add(new OleDbParameter("@NroEncuesta", pNroEncuesta));
                lstParametros.Add(new OleDbParameter("@IdEncuesta", pIdEncuesta));
                lstParametros.Add(new OleDbParameter("@IdUsuario", pIdUser));
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
    }
}
