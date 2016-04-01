using System;
using System.Collections.Generic;
using Encuestador.Entities;
using Encuestador.DL;


namespace Encuestador.BL
{
    public class GestorVehiculos
    {
        public List<Vehiculo> ObtenerTodosVehiculos()
        {
            try
            {
                return Vehiculos.ObtenerTodosVehiculos();
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
    }
}
