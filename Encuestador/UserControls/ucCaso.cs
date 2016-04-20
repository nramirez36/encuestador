using System;
using System.Windows.Forms;
using Encuestador.Entities;
namespace Encuestador.UserControls
{
    public partial class ucCaso : UserControl
    {

        #region Propiedades
        public Caso CasoSeleccionado { get; set; }
        public TiempoViaje DistanciaViajeSeleccionada { get; set; }
        public MotivoViaje MotivoSeleccionado { get; set; }
        public int IdRutaSeleccionada { get; set; }
        #endregion

        #region Constructor
        public ucCaso()
        {
            InitializeComponent();
        }

        #endregion

        #region Metodos
        public bool validarSeleccionRespuesta()
        {
            if (rbRuta1.Checked == false && rbRuta2.Checked == false && rbRuta3.Checked == false && rbRuta4.Checked == false)
            {
                MessageBox.Show("Debe seleccionar una Opción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public void CargarDatos()
        {
            var mensajeActualizado = label1.Text.Replace("##", DistanciaViajeSeleccionada.Descripcion).Replace("#motivo", MotivoSeleccionado.Descripcion);
            label1.Text = mensajeActualizado;
            lblCosto1.Text = lblCosto1.Text.Replace("##", CasoSeleccionado.CostaRuta1);
            lblCosto2.Text = lblCosto2.Text.Replace("##", CasoSeleccionado.CostaRuta2);
            lblCosto3.Text = lblCosto3.Text.Replace("##", CasoSeleccionado.CostaRuta3);

            lblTiempo1.Text = lblTiempo1.Text.Replace("##:##", CasoSeleccionado.TiempoRuta1);
            lblTiempo2.Text = lblTiempo2.Text.Replace("##:##", CasoSeleccionado.TiempoRuta2);
            lblTiempo3.Text = lblTiempo3.Text.Replace("##:##", CasoSeleccionado.TiempoRuta3);

        }

        private void AsignarRespuesta()
        {
            if (rbRuta1.Checked)
                IdRutaSeleccionada = 1;
            if (rbRuta2.Checked)
                IdRutaSeleccionada = 2;
            if (rbRuta3.Checked)
                IdRutaSeleccionada = 3;
            if (rbRuta4.Checked)
                IdRutaSeleccionada = 4;
        }

        #endregion

        #region Eventos
        private void rbRuta1_CheckedChanged(object sender, EventArgs e)
        {
            AsignarRespuesta();
        }

        private void rbRuta2_CheckedChanged(object sender, EventArgs e)
        {
            AsignarRespuesta();
        }

        private void rbRuta3_CheckedChanged(object sender, EventArgs e)
        {
            AsignarRespuesta();
        }

        private void rbRuta4_CheckedChanged(object sender, EventArgs e)
        {
            AsignarRespuesta();
        }
        #endregion
    }
}
