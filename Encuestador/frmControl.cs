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
        private int pCantidadSumar;
        private string pSentidoSeleccionado = string.Empty;
        private DateTime pFechaEncuesta = DateTime.Now;

        private Sitio pSitioSeleccionado = new Sitio();
        private Respuesta pRespuesta = new Respuesta();
        private Vehiculo pVehiculo = new Vehiculo();
        private DistanciaViaje pDistancia = new DistanciaViaje();
        private MotivoViaje pMotivo = new MotivoViaje();

        private GestorSitios pGestorSitios = new GestorSitios();
        private GestorVehiculos pGestorVehiculos = new GestorVehiculos();
        private GestorDistanciasViajes pGestorDistancias = new GestorDistanciasViajes();
        private GestorMotivosViajes pGestorMotivos = new GestorMotivosViajes();

        #endregion

        #region Propiedades
        public Login UsuarioConectado { get; set; }
        public int NroEncuesta { get; set; }
        #endregion


        #region Constuctor
        public frmControl()
        {
            InitializeComponent();
        }
        #endregion

        #region Metodos

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

        private bool validarControlesTipoVehiculo()
        {
            if (cmbTipoVehiculo.SelectedValue == null || int.Parse(cmbTipoVehiculo.SelectedValue.ToString()) < 1)
            {
                MessageBox.Show("Debe seleccionar el Tipo de Vehículo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtPatente.Text == null || txtPatente.Text.Equals(""))
            {
                MessageBox.Show("Debe ingresar la Patente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool validarControlesMotivos()
        {
            if (cmbDistanciaViaje.SelectedValue == null || int.Parse(cmbDistanciaViaje.SelectedValue.ToString()) < 1)
            {
                MessageBox.Show("Debe seleccionar la Distancia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (cmbMotivoViaje.SelectedValue == null || int.Parse(cmbMotivoViaje.SelectedValue.ToString()) < 1)
            {
                MessageBox.Show("Debe ingresar el Motivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
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

        private void IrAMotivosViajes()
        {
            if (validarControlesTipoVehiculo())
            {
                pRespuesta.FechaEncuesta = pFechaEncuesta;
                pRespuesta.IdVehiculo = pVehiculo.IdVehiculo;
                pRespuesta.Patente = txtPatente.Text;

                panelDatosVehiculo.Visible = false;
                panelMotivoViaje.Visible = true;
                SumarPorcentajeAvance();
            }
        }

        private void IrACasos1()
        {
            if (validarControlesMotivos())
            {
                pRespuesta.IdMotivoViaje = pMotivo.IdMotivoViaje;
                pRespuesta.IdDistanciaViaje = pDistancia.IdDistanciaViaje;

                panelMotivoViaje.Visible = false;
                //TODO 01: Aca debe ir el panel de casos
                //panelMotivoViaje.Visible = true;
                SumarPorcentajeAvance();
            }
        }

        private void SumarPorcentajeAvance()
        {
            pbPorcentajeAvance.Value += pCantidadSumar;
        }

        private void CargarDatos()
        {
            this.Text = this.Text + " - " + UsuarioConectado.User;
            this.txtFechaHoraEncuesta.Text = pFechaEncuesta.ToShortDateString();

            pRespuesta.FechaEncuesta = DateTime.Now;
            pRespuesta.IdUsuario = UsuarioConectado.IdEncuestador;
            pRespuesta.NroEncuesta = NroEncuesta;

            this.Size = new Size(388, 260);
            panelSitiosEncuestas.Visible = true;
            SumarPorcentajeAvance();

            CargarSitios();
            CargarSentidos();
            CargarVehiculos();
            CargarDistancias();
            CargarMotivos();
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
                lista.Add(new Sentido() { IdSentido = 0, Descripcion = "Seleccione el Sentido" });
                lista.Add(new Sentido() { IdSentido = 1, Descripcion = "Ida" });
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

        private void CargarVehiculos()
        {
            try
            {
                var lista = pGestorVehiculos.ObtenerTodosVehiculos().ToList();
                lista.Add(new Vehiculo() { IdVehiculo = 0, Descripcion = "Seleccione el Tipo de Vehículo" });
                var listaOrdenada = lista.OrderBy(x => x.IdVehiculo).ToList();
                cmbTipoVehiculo.DataSource = listaOrdenada;
                cmbTipoVehiculo.DisplayMember = "Descripcion";
                cmbTipoVehiculo.ValueMember = "IdVehiculo";
            }
            catch (Exception ex)
            {
                Logger.WriteXMLError("frmControl", "frmControl", "CargarVehiculos", ex.Message);
                throw;
            }
        }

        private void CargarDistancias()
        {
            try
            {
                var lista = pGestorDistancias.ObtenerTodasDistanciasViaje().ToList();
                lista.Add(new DistanciaViaje() { IdDistanciaViaje = 0, Descripcion = "Seleccione la Distancia" });
                var listaOrdenada = lista.OrderBy(x => x.IdDistanciaViaje).ToList();
                cmbDistanciaViaje.DataSource = listaOrdenada;
                cmbDistanciaViaje.DisplayMember = "Descripcion";
                cmbDistanciaViaje.ValueMember = "IdDistanciaViaje";
            }
            catch (Exception ex)
            {
                Logger.WriteXMLError("frmControl", "frmControl", "CargarDistancias", ex.Message);
                throw;
            }
        }

        private void CargarMotivos()
        {
            try
            {
                var lista = pGestorMotivos.ObtenerTodosMotivosViaje().ToList();
                lista.Add(new MotivoViaje() { IdMotivoViaje = 0, Descripcion = "Seleccione el Motivo" });
                var listaOrdenada = lista.OrderBy(x => x.IdMotivoViaje).ToList();
                cmbMotivoViaje.DataSource = listaOrdenada;
                cmbMotivoViaje.DisplayMember = "Descripcion";
                cmbMotivoViaje.ValueMember = "IdMotivoViaje";
            }
            catch (Exception ex)
            {
                Logger.WriteXMLError("frmControl", "frmControl", "CargarMotivos", ex.Message);
                throw;
            }
        }
        #endregion

        #region Eventos
        private void frmControl_Load(object sender, EventArgs e)
        {
            CargarDatos();
            pCantidadTotal = Comunes.GetCountControls(Controls);
            double porcentaje = 100 / (pCantidadTotal + 1);
            pCantidadSumar = int.Parse(Math.Round(porcentaje).ToString());
            pbPorcentajeAvance.Value = pCantidadSumar;
            //panelNroEncuesta.Visible = true;
        }


        private void btnIrDatosVehiculos_Click(object sender, EventArgs e)
        {
            IrAVehiculos();
        }

        private void btnIrMotivoViajes_Click(object sender, EventArgs e)
        {
            IrAMotivosViajes();
        }

        private void btnIrCasos_Click(object sender, EventArgs e)
        {
            IrACasos1();
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

        private void cmbTipoVehiculo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            pVehiculo = (Vehiculo)cmbTipoVehiculo.SelectedItem;
        }

        private void cmbTipoVehiculo_DropDown(object sender, EventArgs e)
        {
            int pw = -1;
            Comunes.GetLargestTextExtent(this.cmbTipoVehiculo, ref pw);
            this.cmbTipoVehiculo.DropDownWidth = pw;
        }

        private void cmbDistanciaViaje_DropDown(object sender, EventArgs e)
        {
            int pw = -1;
            Comunes.GetLargestTextExtent(this.cmbDistanciaViaje, ref pw);
            this.cmbDistanciaViaje.DropDownWidth = pw;
        }

        private void cmbMotivoViaje_DropDown(object sender, EventArgs e)
        {
            int pw = -1;
            Comunes.GetLargestTextExtent(this.cmbMotivoViaje, ref pw);
            this.cmbMotivoViaje.DropDownWidth = pw;
        }

        private void cmbDistanciaViaje_SelectionChangeCommitted(object sender, EventArgs e)
        {
            pDistancia = (DistanciaViaje)cmbDistanciaViaje.SelectedItem;
        }

        private void cmbMotivoViaje_SelectionChangeCommitted(object sender, EventArgs e)
        {
            pMotivo = (MotivoViaje)cmbMotivoViaje.SelectedItem;
        }

        #endregion

        private void frmControl_FormClosed(object sender, FormClosedEventArgs e)
        {
            //TODO 02: Aca se debe preguntar si esta seguro que desea cerrar
            this.Close();
        }
    }
}
