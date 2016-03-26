using Encuestador.Entities;
using System;
using System.Collections.Generic;
using Encuestador.DL;
using nramirez36.Logger;

namespace Encuestador.BL
{
    public class GestorUsuarioEncuestador
    {
        public Login IniciarSesion(Login pUsers)
        {
            try
            {
                return UsuariosEncuestadores.IniciarSesion(pUsers);
            }
            catch (Exception ex)
            {
                Logger.WriteXMLError("GestorUsuarioEncuestador.cs", "GestorUsuarioEncuestador.cs", "IniciarSesion", ex.Message);
                throw;
            }            
        }

        public List<Login> ObtenerTodosUsuarios()
        {
            try
            {
                return UsuariosEncuestadores.ObtenerTodosUsuarios();
            }
            catch (Exception ex)
            {
                Logger.WriteXMLError("GestorUsuarioEncuestador.cs", "GestorUsuarioEncuestador.cs", "ObtenerTodosUsuarios", ex.Message);
                throw;
            }
        }

    }
}
