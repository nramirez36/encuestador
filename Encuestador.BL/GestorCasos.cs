﻿using System;
using System.Collections.Generic;
using Encuestador.DL;
using Encuestador.Entities;

namespace Encuestador.BL
{
    public class GestorCasos
    {
        public List<Caso> ObtenerCasosPorIdDistancia(int pIdDistancia, int pIdVehiculo)
        {
            try
            {
                return Casos.ObtenerCasosPorIdDistancia(pIdDistancia, pIdVehiculo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Caso> ObtenerTodosCasos()
        {
            try
            {
                return Casos.ObtenerTodosCasos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
