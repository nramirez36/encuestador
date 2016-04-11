﻿using System;
using System.Collections.Generic;
using Encuestador.Entities;

namespace Encuestador.DL
{
    public class DistanciasViajes
    {
        public static List<DistanciaViaje> ObtenerTodasDistanciasViaje()
        {
            var conexion = OdbcClient.Conectar();
            DistanciaViaje distancia = null;
            List<DistanciaViaje> lstDistancias = new List<DistanciaViaje>();
            try
            {
                string sql = "SELECT IdDistanciaViaje, Descripcion FROM DistanciaViaje";
                var dr = OdbcClient.GenerarReader(sql, conexion);
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        distancia = new DistanciaViaje();
                        distancia.IdDistanciaViaje = int.Parse(dr["IdDistanciaViaje"].ToString());
                        distancia.Descripcion = dr["Descripcion"].ToString();
                        lstDistancias.Add(distancia);
                        distancia = null;
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
