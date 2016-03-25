using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Encuestador.BL;
using Encuestador.Entities;
using Encuestador.Utiles;
using nramirez36.Logger;
namespace Encuestador
{
    public partial class frmSitioEncuesta : Form
    {
        #region Variables
        private string oSentidoSeleccionado = string.Empty;
        private GestorSitios oGestorSitios = new GestorSitios();
        private Sitio oSitioSeleccionado = new Sitio();
        #endregion

        #region Propiedades

        #endregion

        #region Constructor
        public frmSitioEncuesta()
        {
            InitializeComponent();
        }
        #endregion

        #region Metodos
        private void CargarSitios()
        {
            try
            {
                Sitio i = new Sitio();

                cmbSitios.DataSource = oGestorSitios.ObtenerTodosSitios().ToList();
                cmbSitios.DisplayMember = "Descripcion";
                cmbSitios.ValueMember = "IdSitios";
            }
            catch (Exception ex)
            {
                Logger.WriteXMLError("frmSitioEncuesta", "frmSitioEncuesta", "CargarSitios", ex.Message);
                throw;
            }
        }

        #endregion

        #region Eventos

        private void btnSiguiente_Click(object sender, EventArgs e)
        {


            var frmDatosVehiculos = new frmDatosVehiculos();
            this.Close();
            frmDatosVehiculos.ShowDialog();
        }

        #endregion

        private void frmSitioEncuesta_Load(object sender, EventArgs e)
        {
            CargarSitios();
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
            oSitioSeleccionado =(Sitio) cmbSitios.SelectedItem;
            txtUbicacion.Text = oSitioSeleccionado.Descripcion;
        }

        private void cmbSentido_SelectionChangeCommitted(object sender, EventArgs e)
        {
            oSentidoSeleccionado = cmbSentido.SelectedItem.ToString();
        }
    }
}
