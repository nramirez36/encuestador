using System;
using System.Collections.Generic;
using Encuestador.Entities;
using nramirez36.Logger;

namespace Encuestador.DL
{
    public class Sitios
    {
        public static List<Sitio> ObtenerTodosSitios()
        {
            var conexion = OdbcClient.Conectar();
            Sitio sitio = null;
            List<Sitio> lstSitios = new List<Sitio>();
            try
            {
                string sql = "SELECT IdSitios, Descripcion FROM Sitios";
                var dr = OdbcClient.GenerarReader(sql, conexion);
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        sitio = new Sitio();
                        sitio.IdSitios = int.Parse(dr["IdSitios"].ToString());
                        sitio.Descripcion = dr["Descripcion"].ToString();
                        lstSitios.Add(sitio);
                        sitio = null;
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.WriteXMLError("Sitios.cs", "Sitios.cs", "ObtenerTodosSitios", ex.Message);
                throw;
            }
            finally
            {
                conexion.Close();
            }
            return lstSitios;
        }
    }
}
