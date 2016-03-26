using System;
using System.Drawing;
using System.Windows.Forms;
using Encuestador.Utiles;
using Encuestador.BL;
using Encuestador.Entities;
using System.Linq;
using nramirez36.Logger;
using System.Collections.Generic;

namespace Encuestador
{
    public partial class frmControl : Form
    {
        #region Variables
        private int pCantidadTotal;
        private string pSentidoSeleccionado = string.Empty;
        private GestorSitios pGestorSitios = new GestorSitios();
        private Sitio pSitioSeleccionado = new Sitio();
        private Respuesta pRespuesta = new Respuesta();
        #endregion

        #region Propiedades
        public Login UsuarioConectado { get; set; }
        #endregion

        #region Constuctor
        public frmControl()
        {
            InitializeComponent();
        }
        #endregion

        #region Metodos
        private bool validarControlesNroEncuesta()
        {
            if (txtNroEncuesta.Text == null || txtNroEncuesta.Text.Equals(""))
            {
                MessageBox.Show("Debe ingresar el Número de Encuesta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private bool validarControlesSitioEncuesta()
        {
            if (cmbSitios.SelectedValue == null || int.Parse(cmbSitios.SelectedValue.ToString()) < 1)
            {
                MessageBox.Show("Debe seleccionar el Número de Sitio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (cmbSentido.SelectedValue == null || int.Parse(cmbSentido.SelectedValue.ToString()) < 1)
            {
                MessageBox.Show("Debe seleccionar el Sentido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        private void IrASitiosEncuestas()
        {
            if (validarControlesNroEncuesta())
            {
                pRespuesta.FechaEncuesta = DateTime.Now;
                pRespuesta.IdUsuario = UsuarioConectado.IdEncuestador;
                var nroEncuesta = int.Parse(txtNroEncuesta.Text);
                pRespuesta.NroEncuesta = nroEncuesta;

                this.Size = new Size(388, 260);
                panelNroEncuesta.Visible = false;
                panelSitiosEncuestas.Visible = true;
                SumarPorcentajeAvance();
            }
        }

        private void IrAVehiculos()
        {
            if (validarControlesSitioEncuesta())
            {
                pRespuesta.IdSitio = pSitioSeleccionado.IdSitios;
                pRespuesta.Sentido = pSentidoSeleccionado;

                panelSitiosEncuestas.Visible = false;
                panelDatosVehiculo.Visible = true;
                SumarPorcentajeAvance();
            }
        }

        private void SumarPorcentajeAvance()
        {
            pbPorcentajeAvance.Value += 13;
        }

        private void CargarDatos()
        {
            this.Text = this.Text + " - " + UsuarioConectado.User;

            CargarSitios();
            CargarSentidos();
        }

        private void CargarSitios()
        {
            try
            {
                var lista = pGestorSitios.ObtenerTodosSitios().ToList();                
                lista.Add(new Sitio() { IdSitios = 0, Descripcion = "Seleccione el Sitio" });
                var listaOrdenada = lista.OrderBy(x => x.IdSitios).ToList();
                cmbSitios.DataSource = listaOrdenada;
                cmbSitios.DisplayMember = "Descripcion";
                cmbSitios.ValueMember = "IdSitios";
            }
            catch (Exception ex)
            {
                Logger.WriteXMLError("frmControl", "frmControl", "CargarSitios", ex.Message);
                throw;
            }
        }
        private void CargarSentidos()
        {
            try
            {

                var lista = new List<Sentido>();
                lista.Add(new Sentido() { IdSentido =0, Descripcion = "Seleccione el Sentido" });
                lista.Add(new Sentido() { IdSentido=1, Descripcion = "Ida" });
                lista.Add(new Sentido() { IdSentido = 2, Descripcion = "Vuelta" });
                cmbSentido.DataSource = lista;
                cmbSentido.DisplayMember = "Descripcion";
                cmbSentido.ValueMember = "IdSentido";
            }
            catch (Exception ex)
            {
                Logger.WriteXMLError("frmControl", "frmControl", "CargarSentidos", ex.Message);
                throw;
            }
        }
        #endregion

        #region Eventos
        private void btnIrSitiosEncuesta_Click(object sender, EventArgs e)
        {
            IrASitiosEncuestas();
        }

        private void btnIrDatosVehiculos_Click(object sender, EventArgs e)
        {
            IrAVehiculos();
        }

        private void btnIrMotivoViajes_Click(object sender, EventArgs e)
        {
            panelDatosVehiculo.Visible = false;
            panelMotivoViaje.Visible = true;
            SumarPorcentajeAvance();
        }

        private void frmControl_Load(object sender, EventArgs e)
        {
            CargarDatos();
            pCantidadTotal = Comunes.GetCountControls(Controls);
            pbPorcentajeAvance.Value = 0;
            panelNroEncuesta.Visible = true;
        }

        private void btnIrCasos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNroEncuesta_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            if (e.KeyChar != (char)8 && !char.IsNumber(e.KeyChar))
                e.Handled = true;
            if ((int)e.KeyChar == (int)Keys.Enter)
                IrASitiosEncuestas();
        }

        private void cmbSitios_DropDown(object sender, EventArgs e)
        {
            int pw = -1;
            Comunes.GetLargestTextExtent(this.cmbSitios, ref pw);
            this.cmbSitios.DropDownWidth = pw;
        }

        private void cmbSentido_DropDown(object sender, EventArgs e)
        {
            int pw = -1;
            Comunes.GetLargestTextExtent(this.cmbSentido, ref pw);
            this.cmbSentido.DropDownWidth = pw;
        }

        private void cmbSitios_SelectionChangeCommitted(object sender, EventArgs e)
        {
            pSitioSeleccionado = (Sitio)cmbSitios.SelectedItem;
            txtUbicacion.Text = pSitioSeleccionado.Descripcion;
        }

        private void cmbSentido_SelectionChangeCommitted(object sender, EventArgs e)
        {
            pSentidoSeleccionado = cmbSentido.SelectedItem.ToString();
        }

        #endregion


    }
}
