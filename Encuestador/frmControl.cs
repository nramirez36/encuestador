using System;
using System.Drawing;
using System.Windows.Forms;
using Encuestador.Utiles;
using Encuestador.BL;
using Encuestador.Entities;
using System.Linq;
using System.Collections.Generic;
using Encuestador.UserControls;
namespace Encuestador
{
    public partial class frmControl : Form
    {
        #region Variables
        private bool pRegistroFinalizado = false;
        private int pCantidadTotal;
        private int pCantidadSumar;

        private Respuesta pRespuesta = new Respuesta();
        private TiempoViaje pDistancia = new TiempoViaje();
        private MotivoViaje pMotivo = new MotivoViaje();

        private List<Caso> pLstCasosPorId = new List<Caso>();

        private GestorCasos pGestorCasos = new GestorCasos();
        private GestorRespuestas pGestorRespuestas = new GestorRespuestas();
        #endregion

        #region Propiedades
        public Login UsuarioConectado { get; set; }
        public string NroEncuesta { get; set; }
        #endregion

        #region Constuctor
        public frmControl()
        {
            InitializeComponent();
        }
        #endregion

        #region Metodos

        #region Validaciones para pasar de Panel

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
        private void IrACasos1()
        {
            try
            {
                if (ucDatosMotivo1.IrACasos1())
                {
                    pRespuesta.IdMotivoViaje = ucDatosMotivo1.oRespuesta.IdMotivoViaje;
                    pRespuesta.DistanciaViaje = ucDatosMotivo1.oRespuesta.DistanciaViaje;
                    pRespuesta.IdTiempoViaje = ucDatosMotivo1.oRespuesta.IdTiempoViaje;

                    pDistancia = ucDatosMotivo1.pDistanciaSeleccionada;
                    pMotivo = ucDatosMotivo1.pMotivoSeleccionado;

                    ucCaso1.DistanciaViajeSeleccionada = pDistancia;
                    ucCaso1.MotivoSeleccionado = pMotivo;

                    CargarCasos();
                    ucCaso1.CasoSeleccionado = pLstCasosPorId.Single(p => p.OrdenCaso == 1);
                    ucCaso1.CargarDatos();                    

                    panelMotivoViaje.Visible = false;
                    panelCaso1.Visible = true;

                    SumarPorcentajeAvance();
                }
            }
            catch (Exception)
            {
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

                    SumarPorcentajeAvance();
                }
            }
            catch (Exception)
            {
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

                    SumarPorcentajeAvance();
                }
            }
            catch (Exception)
            {
                throw new Exception("Hubo un problema al cargar los datos");
            }
        }

        #endregion

        private void Finalizar()
        {
            try
            {
                if (validarControlesCaso3())
                {
                    pbPorcentajeAvance.Value = 100;

                    pRespuesta.RespuestaCaso3 = ucCaso3.IdRutaSeleccionada;


                    var resultado = pGestorRespuestas.RegistrarEncuesta(pRespuesta);

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
                throw ex;
            }

        }

        #region Carga de Datos

        private void CargarDatos()
        {
            this.Text = this.Text + " - " + UsuarioConectado.User;

            pRespuesta.FechaEncuesta = DateTime.Now;
            pRespuesta.IdUsuario = UsuarioConectado.IdEncuestador;
            pRespuesta.NroEncuesta = NroEncuesta;

            panelSitiosEncuestas.Visible = true;
            ucDatosSitio1.oRespuesta = pRespuesta;
            SumarPorcentajeAvance();

        }

        private void CargarCasos()
        {
            try
            {
                pLstCasosPorId = new List<Caso>();
                pLstCasosPorId = pGestorCasos.ObtenerCasosPorIdDistancia(pDistancia.IdTiempoViaje,pRespuesta.IdVehiculo).ToList();
            }
            catch (Exception ex)
            {
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
            if (ucDatosSitio1.IrAVehiculos())
            {
                pRespuesta.IdSitio = ucDatosSitio1.oRespuesta.IdSitio;
                pRespuesta.Sentido = ucDatosSitio1.oRespuesta.Sentido;

                ucDatosVehiculo1.oRespuesta = pRespuesta;

                panelSitiosEncuestas.Visible = false;
                panelDatosVehiculo.Visible = true;
                SumarPorcentajeAvance();
            }
        }

        private void btnIrMotivoViajes_Click(object sender, EventArgs e)
        {
            if (ucDatosVehiculo1.IrAMotivosViajes())
            {
                pRespuesta.IdVehiculo = ucDatosVehiculo1.oRespuesta.IdVehiculo;
                pRespuesta.PatenteExtranjera = ucDatosVehiculo1.oRespuesta.PatenteExtranjera;
                pRespuesta.PatenteLetras = ucDatosVehiculo1.oRespuesta.PatenteLetras;
                pRespuesta.PatenteNumero = ucDatosVehiculo1.oRespuesta.PatenteNumero;

                ucDatosMotivo1.oRespuesta = pRespuesta;

                panelDatosVehiculo.Visible = false;
                panelMotivoViaje.Visible = true;
                SumarPorcentajeAvance();
            }
        }

        private void btnIrCasos_Click(object sender, EventArgs e)
        {
            IrACasos1();
        }

        private void frmControl_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!pRegistroFinalizado)
            {
                DialogResult dialogo = MessageBox.Show("Aún no termino la encuestra ¿Desea cerrar la encuesta actual? (Se van a perder los datos)",
                 "Cerrar la encuesta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogo == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        #endregion

        private void btnCaso2_Click(object sender, EventArgs e)
        {
            IrACasos2();
        }

        private void btnCaso3_Click(object sender, EventArgs e)
        {
            IrACasos3();
        }

        private void btnFinalizarEncuesta_Click(object sender, EventArgs e)
        {
            Finalizar();
        }
    }
}
