using Encuestador.Entities;
using System;
using System.Collections.Generic;
using Encuestador.DL;
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
                throw ex;
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
                throw ex;
            }
        }

    }
}
