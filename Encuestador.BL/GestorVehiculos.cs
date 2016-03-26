using System;
using System.Collections.Generic;
using Encuestador.Entities;
using Encuestador.DL;
using nramirez36.Logger;

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
                Logger.WriteXMLError("GestorVehiculos.cs", "GestorVehiculos.cs", "ObtenerTodosVehiculos", ex.Message);
                throw;
            }
        }
    }
}
