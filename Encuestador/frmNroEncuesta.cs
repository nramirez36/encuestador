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
    public partial class frmNroEncuesta : Form
    {
        #region Variables

        #endregion

        #region Propiedades

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
        #endregion

        #region Eventos
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (validarControles())
            {
                frmSitioEncuesta frmDatoSitios = new frmSitioEncuesta();
                this.Close();
                frmDatoSitios.ShowDialog();
            }
        }
        #endregion





    }
}
