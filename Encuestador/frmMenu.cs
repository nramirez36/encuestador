using Encuestador.BL;
using Encuestador.Entities;
using System;
using System.Windows.Forms;

namespace Encuestador
{
    public partial class frmMenu : Form
    {
        #region Variables        
        private GestorUsuarioEncuestador gestorUsuarios = new GestorUsuarioEncuestador();
        #endregion

        #region Propiedades
        public Login UsuarioConectado { get; set; }
        #endregion

        #region Constructor
        public frmMenu()
        {
            InitializeComponent();
        }
        #endregion

        #region Metodos
        public void LoadDatos()
        {
            this.Text = this.Text + " - " + UsuarioConectado.User;
            if (UsuarioConectado.User.ToUpper().Contains("ADMIN"))
                btnExportar.Enabled = true;
        }
        #endregion

        #region Eventos
        private void btnNuevaEncuesta_Click(object sender, EventArgs e)
        {
            var frmNroEncuesta = new frmNroEncuesta();
            frmNroEncuesta.UsuarioConectado = UsuarioConectado;
            frmNroEncuesta.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            var frm = new frmExportar();
            frm.ShowDialog();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            LoadDatos();
        }
        #endregion

        private void frmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
