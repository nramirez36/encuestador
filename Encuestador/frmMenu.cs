using Encuestador.BL;
using Encuestador.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encuestador
{
    public partial class frmMenu : Form
    {
        #region Variables        
        private GestorUsuarioEncuestador gestorUsuarios = new GestorUsuarioEncuestador();
        #endregion

        #region Propiedades
        public int UsuarioID { get; set; }
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
            frmNroEncuesta frmNroEncuesta = new frmNroEncuesta();
            frmNroEncuesta.ShowDialog();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }

        private void btnExportar_Click(object sender, EventArgs e)
        {

        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            LoadDatos();
        }
        #endregion

    }
}
