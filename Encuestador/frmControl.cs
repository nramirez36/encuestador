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




        private bool pDistanciaCambio = false;
        private bool pMotivoCambio = false;


        private Respuesta pRespuesta = new Respuesta();

        private DistanciaViaje pDistancia = new DistanciaViaje();
        private MotivoViaje pMotivo = new MotivoViaje();

        private List<Caso> pLstCasosPorId = new List<Caso>();



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
            //return ucCaso1.validarSeleccionRespuesta();
            return false;
        }

        private bool validarControlesCaso2()
        {
            // return ucCaso2.validarSeleccionRespuesta();
            return false;
        }

        private bool validarControlesCaso3()
        {
            //return ucCaso3.validarSeleccionRespuesta();
            return false;
        }

        #endregion

        #region Metodos para pasar de Panel





        private void IrACasos1()
        {
            try
            {
                if (validarControlesMotivos())
                {
                    //pRespuesta.IdMotivoViaje = pMotivo.IdMotivoViaje;
                    //pRespuesta.IdDistanciaViaje = pDistancia.IdDistanciaViaje;

                    //panelMotivoViaje.Visible = false;
                    //panelCaso1.Visible = true;
                    ////ucCaso1.DistanciaViajeSeleccionada = pDistancia;
                    ////ucCaso1.MotivoSeleccionado = pMotivo;

                    //CargarCasos();
                    ////ucCaso1.CasoSeleccionado = pLstCasosPorId.Single(p => p.OrdenCaso == 1);
                    ////ucCaso1.CargarDatos();

                    //SumarPorcentajeAvance();
                }
            }
            catch (Exception ex)
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
                    //pRespuesta.RespuestaCaso1 = ucCaso1.IdRutaSeleccionada;
                    //panelCaso1.Visible = false;

                    //panelCaso2.Visible = true;
                    //ucCaso2.DistanciaViajeSeleccionada = pDistancia;
                    //ucCaso2.MotivoSeleccionado = pMotivo;

                    //CargarCasos();
                    //ucCaso2.CasoSeleccionado = pLstCasosPorId.Single(p => p.OrdenCaso == 2);
                    //ucCaso2.CargarDatos();

                    //SumarPorcentajeAvance();
                }
            }
            catch (Exception ex)
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
                    //pRespuesta.RespuestaCaso2 = ucCaso2.IdRutaSeleccionada;
                    //panelCaso2.Visible = false;

                    //panelCaso3.Visible = true;
                    //ucCaso3.DistanciaViajeSeleccionada = pDistancia;
                    //ucCaso3.MotivoSeleccionado = pMotivo;

                    //CargarCasos();
                    //ucCaso3.CasoSeleccionado = pLstCasosPorId.Single(p => p.OrdenCaso == 3);
                    //ucCaso3.CargarDatos();

                    //SumarPorcentajeAvance();
                }
            }
            catch (Exception ex)
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
                    //pbPorcentajeAvance.Value = 100;

                    //pRespuesta.RespuestaCaso3 = ucCaso3.IdRutaSeleccionada;

                    //var resultado = pGestorRespuestas.RegistrarEncuesta(pRespuesta);

                    //if (resultado > 0)
                    //{
                    //    pRegistroFinalizado = true;
                    //    MessageBox.Show("Se ha registrado exitosamente la encuesta", "Encustra Registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //    this.Close();
                    //}
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

            //this.Size = new Size(388, 260);
            panelSitiosEncuestas.Visible = true;
            SumarPorcentajeAvance();


            CargarDistancias();
            CargarMotivos();
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

            //TODO 07: Revisar si esta bien
            pbPorcentajeAvance.Width = this.Size.Width - 50;

            CargarDatos();
            pCantidadTotal = Comunes.GetCountControls(Controls);
            double porcentaje = 100 / (pCantidadTotal + 1);
            pCantidadSumar = int.Parse(Math.Round(porcentaje).ToString());
            pbPorcentajeAvance.Value = pCantidadSumar;
            panelSitiosEncuestas.Visible = true;
        }

        private void btnIrDatosVehiculos_Click(object sender, EventArgs e)
        {
            //IrAVehiculos();
        }

        private void btnIrMotivoViajes_Click(object sender, EventArgs e)
        {
            //IrAMotivosViajes();
        }

        private void btnIrCasos_Click(object sender, EventArgs e)
        {
            IrACasos1();
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
