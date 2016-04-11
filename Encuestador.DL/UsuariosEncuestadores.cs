using System;
using System.Collections.Generic;
using Encuestador.Entities;

using System.Data.OleDb;

namespace Encuestador.DL
{
    public class UsuariosEncuestadores
    {
        public static Login IniciarSesion(Login pUsers)
        {
            var conexion = OdbcClient.Conectar();
            Login user = null;
            try
            {
                string sql = "SELECT User, IdEncuestador FROM Login WHERE User = @user AND Password = @pass";
                List<OleDbParameter> lstParametros = new List<OleDbParameter>();
                lstParametros.Add(new OleDbParameter("@user", pUsers.User));
                lstParametros.Add(new OleDbParameter("@pass", pUsers.Password));
                var dr = OdbcClient.GenerarReader(sql, lstParametros, conexion);
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        user = new Login();
                        user.IdEncuestador = int.Parse(dr["IdEncuestador"].ToString());
                        user.User = dr["User"].ToString();
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Hubo un problema al Iniciar Sesión");
            }
            finally
            {
                conexion.Close();
            }
            return user;
        }

        public static List<Login> ObtenerTodosUsuarios()
        {
            var conexion = OdbcClient.Conectar();
            Login user = null;
            List<Login> lstUsuarios = new List<Login>();
            try
            {
                string sql = "SELECT User, IdEncuestador FROM Login";
                var dr = OdbcClient.GenerarReader(sql, conexion);
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        user = new Login();
                        user.IdEncuestador = int.Parse(dr["IdEncuestador"].ToString());
                        user.User = dr["User"].ToString();
                        lstUsuarios.Add(user);
                        user = null;
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Hubo un problema al Obtener los Usuarios");
            }
            finally
            {
                conexion.Close();
            }
            return lstUsuarios;
        }
    }
}
