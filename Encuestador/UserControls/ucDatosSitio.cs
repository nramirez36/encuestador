using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Encuestador.Entities;
using Encuestador.BL;
using Encuestador.Utiles;
namespace Encuestador.UserControls
{
    public partial class ucDatosSitio : UserControl
    {
        #region Variables
        private string pSentidoSeleccionado = string.Empty;
        private bool pSitioCambio = false;
        private bool pSentidoCambio = false;


        private Sitio pSitioSeleccionado = new Sitio();

        private GestorSitios pGestorSitios = new GestorSitios();

        #endregion

        #region Propiedades
        public Respuesta oRespuesta { get; set; }
        #endregion

        #region Constructor
        public ucDatosSitio()
        {
            InitializeComponent();
        }
        #endregion

        #region Metodos
        private void CargarDatos()
        {
            CargarSitios();
        }
        private void CargarSentidos(Sitio pSitio)
        {
            try
            {
                var lista = new List<Sentido>();
                lista.Add(new Sentido() { IdSentido = 0, Descripcion = "Seleccione el Sentido" });
                lista.Add(new Sentido() { IdSentido = 1, Descripcion = pSitio.Sentido1 });
                lista.Add(new Sentido() { IdSentido = 2, Descripcion = pSitio.Sentido2 });
                cmbSentido.DataSource = lista;
                cmbSentido.DisplayMember = "Descripcion";
                cmbSentido.ValueMember = "IdSentido";
            }
            catch (Exception)
            {
                throw new Exception("Hubo un problema al Obtener los Sentidos");
            }
        }
        public bool IrAVehiculos()
        {
            try
            {
                if (validarControlesSitioEncuesta())
                {
                    oRespuesta.IdSitio = pSitioSeleccionado.IdSitios;
                    oRespuesta.Sentido = pSentidoSeleccionado;
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                throw new Exception("Hubo un problema al cargar los datos");
            }
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
                throw ex;
            }
        }
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
        #endregion

        #region Eventos

        private void ucDatosSitio_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void cmbSentido_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var seleccionado = (Sentido)cmbSentido.SelectedItem;
            pSentidoSeleccionado = seleccionado.Descripcion;
            pSentidoCambio = true;
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

            this.cmbSentido.Enabled = true;

            CargarSentidos(pSitioSeleccionado);
        }

        private void cmbSitios_DropDown(object sender, EventArgs e)
        {
            int pw = -1;
            Comunes.GetLargestTextExtent(this.cmbSitios, ref pw);
            this.cmbSitios.DropDownWidth = pw;
        }
        #endregion
    }
}
