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
        private bool pRegistroFinalizado = false;
        private int pCantidadTotal;
        private int pCantidadSumar;
        private string pSentidoSeleccionado = string.Empty;
        private DateTime pFechaEncuesta = DateTime.Now;
        private bool pSitioCambio = false;
        private bool pSentidoCambio = false;
        private bool pTipoVehiculoCambio = false;
        private bool pDistanciaCambio = false;
        private bool pMotivoCambio = false;

        private Sitio pSitioSeleccionado = new Sitio();
        private Respuesta pRespuesta = new Respuesta();
        private Vehiculo pVehiculo = new Vehiculo();
        private DistanciaViaje pDistancia = new DistanciaViaje();
        private MotivoViaje pMotivo = new MotivoViaje();

        private List<Caso> pLstCasosPorId = new List<Caso>();

        private GestorSitios pGestorSitios = new GestorSitios();
        private GestorVehiculos pGestorVehiculos = new GestorVehiculos();
        private GestorDistanciasViajes pGestorDistancias = new GestorDistanciasViajes();
        private GestorMotivosViajes pGestorMotivos = new GestorMotivosViajes();
        private GestorCasos pGestorCasos = new GestorCasos();
        private GestorRespuestas pGestorRespuestas = new GestorRespuestas();
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

        #region Validaciones para pasar de Panel

        private bool validarControlesSitioEncuesta()
        {
            if (cmbSitios.SelectedValue == null || int.Parse(cmbSitios.SelectedValue.ToString()) < 1 || !pSitioCambio)
            {
                MessageBox.Show("Debe seleccionar el Número de Sitio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (cmbSentido.SelectedValue == null || int.Parse(cmbSentido.SelectedValue.ToString()) < 1 || !pSentidoCambio)
            {
                MessageBox.Show("Debe seleccionar el Sentido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool validarControlesTipoVehiculo()
        {
            if (cmbTipoVehiculo.SelectedValue == null || int.Parse(cmbTipoVehiculo.SelectedValue.ToString()) < 1 || !pTipoVehiculoCambio)
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
            if (cmbDistanciaViaje.SelectedValue == null || int.Parse(cmbDistanciaViaje.SelectedValue.ToString()) < 1 || !pDistanciaCambio)
            {
                MessageBox.Show("Debe seleccionar la Distancia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (cmbMotivoViaje.SelectedValue == null || int.Parse(cmbMotivoViaje.SelectedValue.ToString()) < 1 || !pMotivoCambio)
            {
                MessageBox.Show("Debe ingresar el Motivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool validarControlesCaso1()
        {
            return ucCaso1.validarSeleccionRespuesta();
        }

        private bool validarControlesCaso2()
        {
            return ucCaso2.validarSeleccionRespuesta();
        }

        private bool validarControlesCaso3()
        {
            return ucCaso3.validarSeleccionRespuesta();
        }

        #endregion

        #region Metodos para pasar de Panel

        private void IrAVehiculos()
        {
            try
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
            catch (Exception ex)
            {
                Logger.WriteXMLError("frmControl.cs", "frmControl.cs", "IrAVehiculos", ex.Message);
                throw new Exception("Hubo un problema al cargar los datos");
            }
        }

        private void IrAMotivosViajes()
        {
            try
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
            catch (Exception ex)
            {
                Logger.WriteXMLError("frmControl.cs", "frmControl.cs", "IrAMotivosViajes", ex.Message);
                throw new Exception("Hubo un problema al cargar los datos");
            }
        }

        private void IrACasos1()
        {
            try
            {
                if (validarControlesMotivos())
                {
                    pRespuesta.IdMotivoViaje = pMotivo.IdMotivoViaje;
                    pRespuesta.IdDistanciaViaje = pDistancia.IdDistanciaViaje;

                    panelMotivoViaje.Visible = false;
                    panelCaso1.Visible = true;
                    ucCaso1.DistanciaViajeSeleccionada = pDistancia;
                    ucCaso1.MotivoSeleccionado = pMotivo;

                    CargarCasos();
                    ucCaso1.CasoSeleccionado = pLstCasosPorId.Single(p => p.OrdenCaso == 1);
                    ucCaso1.CargarDatos();

                    //this.Size = new Size(570, 381);
                    SumarPorcentajeAvance();
                }
            }
            catch (Exception ex)
            {
                Logger.WriteXMLError("frmControl.cs", "frmControl.cs", "IrACasos1", ex.Message);
                throw new Exception("Hubo un problema al cargar los datos");
            }
        }

        private void IrACasos2()
        {
            try
            {
                if (validarControlesCaso1())
                {
                    pRespuesta.RespuestaCaso1 = ucCaso1.IdRutaSeleccionada;
                    panelCaso1.Visible = false;

                    panelCaso2.Visible = true;
                    ucCaso2.DistanciaViajeSeleccionada = pDistancia;
                    ucCaso2.MotivoSeleccionado = pMotivo;

                    CargarCasos();
                    ucCaso2.CasoSeleccionado = pLstCasosPorId.Single(p => p.OrdenCaso == 2);
                    ucCaso2.CargarDatos();

                    //this.Size = new Size(570, 381);
                    SumarPorcentajeAvance();
                }
            }
            catch (Exception ex)
            {
                Logger.WriteXMLError("frmControl.cs", "frmControl.cs", "IrACasos2", ex.Message);
                throw new Exception("Hubo un problema al cargar los datos");
            }
        }

        private void IrACasos3()
        {
            try
            {
                if (validarControlesCaso2())
                {
                    pRespuesta.RespuestaCaso2 = ucCaso2.IdRutaSeleccionada;
                    panelCaso2.Visible = false;

                    panelCaso3.Visible = true;
                    ucCaso3.DistanciaViajeSeleccionada = pDistancia;
                    ucCaso3.MotivoSeleccionado = pMotivo;

                    CargarCasos();
                    ucCaso3.CasoSeleccionado = pLstCasosPorId.Single(p => p.OrdenCaso == 3);
                    ucCaso3.CargarDatos();

                    //this.Size = new Size(570, 381);
                    SumarPorcentajeAvance();
                }
            }
            catch (Exception ex)
            {
                Logger.WriteXMLError("frmControl.cs", "frmControl.cs", "IrACasos3", ex.Message);
                throw new Exception("Hubo un problema al cargar los datos");
            }
        }

        #endregion

        private void Finalizar()
        {
            try
            {
                //TODO 01: Validar que los datos del ultimo control esten completos
                if (validarControlesCaso3())
                {
                    pbPorcentajeAvance.Value = 100;

                    pRespuesta.RespuestaCaso3 = ucCaso3.IdRutaSeleccionada;

                    //TODO 02: Registrar respuesta
                    var resultado = pGestorRespuestas.RegistrarEncuesta(pRespuesta);

                    //TODO 04: Mostrar mensaje e ir a la pagina principal
                    if (resultado > 0)
                    {
                        pRegistroFinalizado = true;
                        MessageBox.Show("Se ha registrado exitosamente la encuesta", "Encustra Registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.WriteXMLError("frmControl", "frmControl", "Finalizar", ex.Message);
                throw ex;
            }

        }

        #region Carga de Datos

        private void CargarDatos()
        {
            this.Text = this.Text + " - " + UsuarioConectado.User;
            this.txtFechaHoraEncuesta.Text = pFechaEncuesta.ToString();

            pRespuesta.FechaEncuesta = DateTime.Now;
            pRespuesta.IdUsuario = UsuarioConectado.IdEncuestador;
            pRespuesta.NroEncuesta = NroEncuesta;

            //this.Size = new Size(388, 260);
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
                throw ex;
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
                throw ex;
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
                throw ex;
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
                throw ex;
            }
        }

        private void CargarCasos()
        {
            try
            {
                pLstCasosPorId = new List<Caso>();
                pLstCasosPorId = pGestorCasos.ObtenerCasosPorIdDistancia(pDistancia.IdDistanciaViaje).ToList();
            }
            catch (Exception ex)
            {
                Logger.WriteXMLError("frmControl", "frmControl", "CargarCasos", ex.Message);
                throw ex;
            }
        }

        #endregion

        private void SumarPorcentajeAvance()
        {
            pbPorcentajeAvance.Value += pCantidadSumar;
        }

        #endregion

        #region Eventos
        private void frmControl_Load(object sender, EventArgs e)
        {
            //this.Size = SystemInformation.PrimaryMonitorSize;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            
            CargarDatos();
            pCantidadTotal = Comunes.GetCountControls(Controls);
            double porcentaje = 100 / (pCantidadTotal + 1);
            pCantidadSumar = int.Parse(Math.Round(porcentaje).ToString());
            pbPorcentajeAvance.Value = pCantidadSumar;
            panelSitiosEncuestas.Visible = true;
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
            pSitioCambio = true;
        }

        private void cmbSentido_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var seleccionado = (Sentido)cmbSentido.SelectedItem;
            pSentidoSeleccionado = seleccionado.Descripcion;
            pSentidoCambio = true;
        }

        private void cmbTipoVehiculo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            pVehiculo = (Vehiculo)cmbTipoVehiculo.SelectedItem;
            pTipoVehiculoCambio = true;
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
            pDistanciaCambio = true;
        }

        private void cmbMotivoViaje_SelectionChangeCommitted(object sender, EventArgs e)
        {
            pMotivo = (MotivoViaje)cmbMotivoViaje.SelectedItem;
            pMotivoCambio = true;
        }

        private void txtPatente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
                IrAMotivosViajes();
        }

        private void frmControl_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!pRegistroFinalizado)
            {
                DialogResult dialogo = MessageBox.Show("Aún no termino la encuestra ¿Desea cerrar la encuesta actual? (Se van a perder los datos)",
                 "Cerrar la encuesta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogo == DialogResult.No)
                {
                    this.Close();
                }
            }
        }

        private void btnIrACaso2_Click(object sender, EventArgs e)
        {
            IrACasos2();
        }

        private void btnIrACaso3_Click(object sender, EventArgs e)
        {
            IrACasos3();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            Finalizar();
        }

        #endregion
    }
}
