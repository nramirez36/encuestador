using System;
using System.Collections.Generic;
using Encuestador.Entities;
using nramirez36.Logger;

namespace Encuestador.DL
{
   public class MotivosViajes
    {
        public static List<MotivoViaje> ObtenerTodosMotivosViaje()
        {
            var conexion = OdbcClient.Conectar();
            MotivoViaje motivo = null;
            List<MotivoViaje> lstMotivos = new List<MotivoViaje>();
            try
            {
                string sql = "SELECT IdMotivoViaje, Descripcion FROM MotivoViaje";
                var dr = OdbcClient.GenerarReader(sql, conexion);
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        motivo = new MotivoViaje();
                        motivo.IdMotivoViaje = int.Parse(dr["IdMotivoViaje"].ToString());
                        motivo.Descripcion = dr["Descripcion"].ToString();
                        lstMotivos.Add(motivo);
                        motivo = null;
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.WriteXMLError("MotivosViajes.cs", "MotivosViajes.cs", "ObtenerTodosMotivosViaje", ex.Message);
                throw new Exception("Hubo un problema al Obtener los Motivos");
            }
            finally
            {
                conexion.Close();
            }
            return lstMotivos;
        }
    }
}
