using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Encuestador.BL;
using Encuestador.Entities;
using Encuestador.Utiles;
namespace Encuestador.UserControls
{
    public partial class ucDatosMotivo : UserControl
    {
        #region Variables
        private bool pDistanciaCambio = false;
        private bool pMotivoCambio = false;

        private TiempoViaje pDistancia = new TiempoViaje();
        private MotivoViaje pMotivo = new MotivoViaje();

        private GestorDistanciasViajes pGestorDistancias = new GestorDistanciasViajes();
        private GestorMotivosViajes pGestorMotivos = new GestorMotivosViajes();

        #endregion

        #region Propiedades
        public Respuesta oRespuesta { get; set; }
        public TiempoViaje pDistanciaSeleccionada { get; set; }
        public MotivoViaje pMotivoSeleccionado { get; set; }
        #endregion

        #region Constructor
        public ucDatosMotivo()
        {
            InitializeComponent();
        }
        #endregion
        #region Metodos
        private void CargarDatos()
        {
            CargarDistancias();
            CargarMotivos();
        }
        private bool validarControlesMotivos()
        {
            if (txtDistancia.Text.Equals(""))
            {
                MessageBox.Show("Debe ingresar la Distancia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cmbDistanciaViaje.SelectedValue == null || int.Parse(cmbDistanciaViaje.SelectedValue.ToString()) < 1 || !pDistanciaCambio)
            {
                MessageBox.Show("Debe seleccionar el Tiempo de Viaje", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (cmbMotivoViaje.SelectedValue == null || int.Parse(cmbMotivoViaje.SelectedValue.ToString()) < 1 || !pMotivoCambio)
            {
                MessageBox.Show("Debe ingresar el Motivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        public bool IrACasos1()
        {
            try
            {
                if (validarControlesMotivos())
                {
                    oRespuesta.IdMotivoViaje = pMotivo.IdMotivoViaje;
                    oRespuesta.IdTiempoViaje = pDistancia.IdTiempoViaje;
                    oRespuesta.DistanciaViaje = int.Parse(txtDistancia.Text);
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                throw new Exception("Hubo un problema al cargar los datos");
            }
        }
        private void CargarDistancias()
        {
            try
            {
                var lista = pGestorDistancias.ObtenerTodosTiemposViaje().ToList();
                lista.Add(new TiempoViaje() { IdTiempoViaje = 0, Descripcion = "Seleccione el Tiempo" });
                var listaOrdenada = lista.OrderBy(x => x.IdTiempoViaje).ToList();
                cmbDistanciaViaje.DataSource = listaOrdenada;
                cmbDistanciaViaje.DisplayMember = "Descripcion";
                cmbDistanciaViaje.ValueMember = "IdTiempoViaje";
                cmbDistanciaViaje.MaxDropDownItems = 6;
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
        #endregion
        #region Eventos

        private void cmbDistanciaViaje_SelectionChangeCommitted(object sender, EventArgs e)
        {
            pDistancia = (TiempoViaje)cmbDistanciaViaje.SelectedItem;
            pDistanciaCambio = true;
            pDistanciaSeleccionada = pDistancia;
        }

        private void cmbDistanciaViaje_DropDown(object sender, EventArgs e)
        {
            int pw = -1;
            Comunes.GetLargestTextExtent(this.cmbDistanciaViaje, ref pw);
            this.cmbDistanciaViaje.DropDownWidth = pw;
        }

        private void cmbMotivoViaje_SelectionChangeCommitted(object sender, EventArgs e)
        {
            pMotivo = (MotivoViaje)cmbMotivoViaje.SelectedItem;
            pMotivoCambio = true;
            pMotivoSeleccionado = pMotivo;
        }

        private void cmbMotivoViaje_DropDown(object sender, EventArgs e)
        {
            int pw = -1;
            Comunes.GetLargestTextExtent(this.cmbMotivoViaje, ref pw);
            this.cmbMotivoViaje.DropDownWidth = pw;
        }


        private void ucDatosMotivo_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }


        private void txtDistancia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                //MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        #endregion
    }
}
