using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Windows.Forms;
using Encuestador.BL;
using Encuestador.Entities;
using nramirez36.Logger;

namespace Encuestador
{
    public partial class frmLogin : Form
    {
        #region Variables
        private GestorUsuarioEncuestador gestorUsuarios = new GestorUsuarioEncuestador();
        #endregion

        #region Propiedades

        #endregion

        #region Constructor
        public frmLogin()
        {
            InitializeComponent();
        }
        #endregion

        #region Eventos
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            IniciarSesion();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
                IniciarSesion();
        }
        #endregion

        #region Metodos
        private void IniciarSesion()
        {
            var usuario = new Login();
            try
            {
                if (validarControles())
                {
                    usuario.User = txtUsuario.Text.Trim();
                    usuario.Password = txtPassword.Text.Trim();
                    Login oAux = gestorUsuarios.IniciarSesion(usuario);
                    if (oAux != null)
                    {
                        frmMenu frm = new frmMenu();
                        frm.UsuarioConectado = oAux;
                        this.Close();
                        frm.Show();
                    }
                    else
                    {
                        MessageBox.Show("El Usuario o la Contraseña Ingresados no son correctos", "Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUsuario.Focus();
                        txtPassword.Text = "";
                    }
                }

            }
            catch (Exception ex)
            {
                Logger.WriteXMLError("frmLogin.cs", "frmLogin.cs", "IniciarSesion", ex.Message);
                throw;
            }
        }
        private bool validarControles()
        {
            if ((txtUsuario.Text != null && !txtUsuario.Text.Equals(string.Empty)) && txtUsuario.Text.Length <= 50)
            {
                if ((txtPassword.Text != null && !txtPassword.Text.Equals(string.Empty)) && txtPassword.Text.Length <= 50)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Por favor ingrese la contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Focus();
                return false;
            }
        }
        #endregion



    }
}
