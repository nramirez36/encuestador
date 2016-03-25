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
    public partial class frmControl : Form
    {
        public frmControl()
        {
            InitializeComponent();
        }

        private void btnIrSitiosEncuesta_Click(object sender, EventArgs e)
        {
            this.Size = new Size(350, 241);
            panelNroEncuesta.Visible = false;
            panelSitiosEncuestas.Visible = true;

        }

        private void btnIrDatosVehiculos_Click(object sender, EventArgs e)
        {
            panelSitiosEncuestas.Visible = false;
            panelDatosVehiculo.Visible = true;
        }

        private void btnIrMotivoViajes_Click(object sender, EventArgs e)
        {
            panelDatosVehiculo.Visible = false;

        }

        private void frmControl_Load(object sender, EventArgs e)
        {
            panelNroEncuesta.Visible = true;
            panelDatosVehiculo.Visible = false;
            panelSitiosEncuestas.Visible = false;
            
        }
    }
}
