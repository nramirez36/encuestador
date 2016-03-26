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
    public partial class frmDatosVehiculos : Form
    {
        #region Variables

        #endregion

        #region Propiedades

        #endregion

        #region Constuctor

        #endregion

        #region Metodos

        #endregion

        #region Eventos

        #endregion

        public frmDatosVehiculos()
        {
            InitializeComponent();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            var frmMotivoViajes = new frmMotivoViajes();
            this.Close();
            frmMotivoViajes.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmbTipoVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtPatente_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtFechaHoraEncuesta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
