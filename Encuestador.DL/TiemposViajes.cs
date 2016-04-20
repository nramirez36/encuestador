using System;
using System.Collections.Generic;
using Encuestador.Entities;

namespace Encuestador.DL
{
    public class TiemposViajes
    {
        public static List<TiempoViaje> ObtenerTodosTiemposViaje()
        {
            var conexion = OdbcClient.Conectar();
            TiempoViaje tiempo = null;
            List<TiempoViaje> lstDistancias = new List<TiempoViaje>();
            try
            {
                string sql = "SELECT IdTiempoViaje, Descripcion FROM TiempoViaje";
                var dr = OdbcClient.GenerarReader(sql, conexion);
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        tiempo = new TiempoViaje();
                        tiempo.IdTiempoViaje = int.Parse(dr["IdTiempoViaje"].ToString());
                        tiempo.Descripcion = dr["Descripcion"].ToString();
                        lstDistancias.Add(tiempo);
                        tiempo = null;
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Hubo un problema al Obtener las Distancias");
            }
            finally
            {
                conexion.Close();
            }
            return lstDistancias;
        }
    }
}
