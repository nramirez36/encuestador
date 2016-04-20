using System;
using System.Collections.Generic;
using Encuestador.Entities;
using System.Data.OleDb;

namespace Encuestador.DL
{
    public class Casos
    {
        public static List<Caso> ObtenerCasosPorIdDistancia(int idDistancia, int idVehiculo)
        {
            var conexion = OdbcClient.Conectar();
            Caso caso = null;
            List<Caso> lstCasos = new List<Caso>();
            try
            {
                string sql = "SELECT TiempoRuta1, TiempoRuta2, TiempoRuta3, CostoRuta1, CostoRuta2, CostoRuta3, IdCaso, OrdenCaso, IdTiempoViaje, IdVehiculo FROM Casos WHERE (IdTiempoViaje = @idDistancia) and (IdVehiculo = @idVehiculo) ORDER BY OrdenCaso";
                var lstParametros = new List<OleDbParameter>();
                lstParametros.Add(new OleDbParameter("@idDistancia", idDistancia)); 
                    lstParametros.Add(new OleDbParameter("@idVehiculo", idVehiculo));
                var dr = OdbcClient.GenerarReader(sql, lstParametros, conexion);
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        caso = new Caso();                        
                        caso.CostaRuta1 = dr["CostoRuta1"].ToString();
                        caso.CostaRuta2 = dr["CostoRuta2"].ToString();
                        caso.CostaRuta3 = dr["CostoRuta3"].ToString();
                        caso.IdCaso = int.Parse(dr["IdCaso"].ToString());
                        caso.OrdenCaso = int.Parse(dr["OrdenCaso"].ToString());
                        caso.TiempoRuta1 = dr["TiempoRuta1"].ToString();
                        caso.TiempoRuta2 = dr["TiempoRuta2"].ToString();
                        caso.TiempoRuta3 = dr["TiempoRuta3"].ToString();
                        caso.IdTiempoViaje = int.Parse(dr["IdTiempoViaje"].ToString());
                        caso.IdVehiculo = int.Parse(dr["IdVehiculo"].ToString());

                        lstCasos.Add(caso);
                        caso = null;
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Hubo un problema al Obtener los Casos");
            }
            finally
            {
                conexion.Close();
            }
            return lstCasos;
        }

        public static List<Caso> ObtenerTodosCasos()
        {
            var conexion = OdbcClient.Conectar();
            Caso caso = null;
            List<Caso> lstCasos = new List<Caso>();
            try
            {
                string sql = "SELECT IdDistanciaViaje, TiempoRuta1, TiempoRuta2, TiempoRuta3, CostoRuta1, CostoRuta2, CostoRuta3, IdCaso, OrdenCaso,IdTiempoViaje, IdVehiculo FROM Casos ORDER BY OrdenCaso";
                var dr = OdbcClient.GenerarReader(sql, conexion);
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        caso = new Caso();
                        caso.CostaRuta1 = dr["CostoRuta1"].ToString();
                        caso.CostaRuta2 = dr["CostoRuta2"].ToString();
                        caso.CostaRuta3 = dr["CostoRuta3"].ToString();
                        caso.IdCaso = int.Parse(dr["IdCaso"].ToString());
                        caso.OrdenCaso = int.Parse(dr["OrdenCaso"].ToString());
                        caso.TiempoRuta1 = dr["TiempoRuta1"].ToString();
                        caso.TiempoRuta2 = dr["TiempoRuta2"].ToString();
                        caso.TiempoRuta3 = dr["TiempoRuta3"].ToString();
                        caso.IdTiempoViaje = int.Parse(dr["IdTiempoViaje"].ToString());
                        caso.IdVehiculo = int.Parse(dr["IdVehiculo"].ToString());

                        lstCasos.Add(caso);
                        caso = null;
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Hubo un problema al Obtener los Casos");
            }
            finally
            {
                conexion.Close();
            }
            return lstCasos;
        }
    }
}
