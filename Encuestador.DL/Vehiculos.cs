using Encuestador.Entities;

using System;
using System.Collections.Generic;

namespace Encuestador.DL
{
    public class Vehiculos
    {
        public static List<Vehiculo> ObtenerTodosVehiculos()
        {
            var conexion = OdbcClient.Conectar();
            Vehiculo vehi = null;
            List<Vehiculo> lstVehiculos = new List<Vehiculo>();
            try
            {
                string sql = "SELECT IdVehiculo, Descripcion FROM Vehiculos";
                var dr = OdbcClient.GenerarReader(sql, conexion);
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        vehi = new Vehiculo();
                        vehi.IdVehiculo = int.Parse(dr["IdVehiculo"].ToString());
                        vehi.Descripcion = dr["Descripcion"].ToString();
                        lstVehiculos.Add(vehi);
                        vehi = new Vehiculo();
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Hubo un problema al Obtener los Tipos de Vehículos");
            }
            finally
            {
                conexion.Close();
            }
            return lstVehiculos;
        }
    }
}
