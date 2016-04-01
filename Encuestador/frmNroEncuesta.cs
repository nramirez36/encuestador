using System;
using System.Windows.Forms;
using Encuestador.Entities;

namespace Encuestador
{
    public partial class frmNroEncuesta : Form
    {
        #region Variables

        #endregion

        #region Propiedades
        public Login UsuarioConectado { get; set; }
        #endregion

        #region Constructor
        public frmNroEncuesta()
        {
            InitializeComponent();
        }
        #endregion

        #region Metodos
        public bool validarControles()
        {
            bool res = false;
            string msg = "";
            if (txtNroEncuesta.Text == null || txtNroEncuesta.Text.Equals(""))
            {
                MessageBox.Show("Debe ingresar el Número de Encuesta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public void LoadDatos()
        {
            this.Text = this.Text + " - " + UsuarioConectado.User;
        }

        private void IrASitiosEncuestas()
        {
            if (validarControles())
            {
                var frmControl = new frmControl();
                frmControl.NroEncuesta = int.Parse(txtNroEncuesta.Text);
                frmControl.UsuarioConectado = UsuarioConectado;
                this.Close();
                frmControl.ShowDialog();
            }
        }

        #endregion

        #region Eventos
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            IrASitiosEncuestas();
        }
        private void frmNroEncuesta_Load(object sender, EventArgs e)
        {
            LoadDatos();
        }
        private void txtNroEncuesta_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            if (e.KeyChar != (char)8 && !char.IsNumber(e.KeyChar))
                e.Handled = true;
            if ((int)e.KeyChar == (int)Keys.Enter)
                IrASitiosEncuestas();
        }   

        #endregion

    }
}
