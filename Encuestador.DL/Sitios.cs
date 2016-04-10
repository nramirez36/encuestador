using System;
using System.Collections.Generic;
using Encuestador.Entities;

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
                //TODO 05: Revisar y actualizar este query ya que se modifico la tabla participante
                //TODO 06: De aca tomo los sentidos?
                string sql = "SELECT IdSitios, Descripcion, Sentido1, Sentido2 FROM Sitios";
                var dr = OdbcClient.GenerarReader(sql, conexion);
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        sitio = new Sitio();
                        sitio.IdSitios = int.Parse(dr["IdSitios"].ToString());
                        sitio.Descripcion = dr["Descripcion"].ToString();
                        sitio.Sentido1= dr["Sentido1"].ToString();
                        sitio.Sentido2 = dr["Sentido2"].ToString();
                        lstSitios.Add(sitio);
                        sitio = null;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Hubo un problema al Obtener los Sitios");
            }
            finally
            {
                conexion.Close();
            }
            return lstSitios;
        }
    }
}
