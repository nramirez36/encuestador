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
using Encuestador.Utiles;
using Encuestador.BL;
namespace Encuestador.UserControls
{
    public partial class ucDatosVehiculo : UserControl
    {
        #region Variables
        private bool pTipoVehiculoCambio = false;

        private Vehiculo pVehiculo = new Vehiculo();

        private GestorVehiculos pGestorVehiculos = new GestorVehiculos();

        #endregion
        #region Propiedades
        public Respuesta oRespuesta { get; set; }

        #endregion
        #region Constructor
        public ucDatosVehiculo()
        {
            InitializeComponent();
        }
        #endregion
        #region Metodos
        private void CargarDatos()
        {
            this.txtFechaHoraEncuesta.Text = oRespuesta.FechaEncuesta.ToShortDateString();
            this.txtHoraEncuesta.Text = oRespuesta.FechaEncuesta.ToShortTimeString();
            CargarVehiculos();
        }
        private bool validarControlesTipoVehiculo()
        {
            if (cmbTipoVehiculo.SelectedValue == null || int.Parse(cmbTipoVehiculo.SelectedValue.ToString()) < 1 || !pTipoVehiculoCambio)
            {
                MessageBox.Show("Debe seleccionar el Tipo de Vehículo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //if (txtPatente.Text == null || txtPatente.Text.Equals(""))
            //{
            //       MessageBox.Show("Debe ingresar la Placa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return false;
            //}
            //else
            //{
            //    if (txtPatenteLetras.Text == null || txtPatenteLetras.Text.Equals(""))
            //    {
            //        MessageBox.Show("Debe ingresar las Letras de la Placa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return false;
            //    }
            //    if (!mskPlacaNumeros.MaskFull)
            //    {
            //        MessageBox.Show("Debe ingresar los Números de la Placa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return false;
            //    }
            //}

            return true;
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
                throw ex;
            }
        }
        public bool IrAMotivosViajes()
        {
            try
            {
                if (validarControlesTipoVehiculo())
                {
                    oRespuesta.IdVehiculo = pVehiculo.IdVehiculo;
                    //oRespuesta.PatenteExtranjera = chkPlacaExtranjera.Checked ? txtPatente.Text : string.Empty;
                    //oRespuesta.PatenteLetras = !chkPlacaExtranjera.Checked ? txtPatenteLetras.Text : string.Empty;
                    //oRespuesta.PatenteNumero = !chkPlacaExtranjera.Checked ? mskPlacaNumeros.Text : string.Empty;

                    oRespuesta.PatenteExtranjera = txtPatente.Text;
                    oRespuesta.PatenteLetras = txtPatenteLetras.Text;
                    oRespuesta.PatenteNumero = mskPlacaNumeros.Text;

                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                throw new Exception("Hubo un problema al cargar los datos");
            }
        }

        #endregion
        #region Eventos
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

        //private void chkPlacaExtranjera_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (chkPlacaExtranjera.Checked)
        //    {
        //        txtPatenteLetras.Visible = false;
        //        mskPlacaNumeros.Visible = false;
        //        txtPatente.Visible = true;
        //    }
        //    else
        //    {
        //        txtPatenteLetras.Visible = true;
        //        mskPlacaNumeros.Visible = true;
        //        txtPatente.Visible = false;
        //    }
        //}
        private void ucDatosVehiculo_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void txtPatenteNro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
                mskPlacaNumeros.Focus();

            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        #endregion

        private void mskPlacaNumeros_TextChanged(object sender, EventArgs e)
        {
            //if (!string.IsNullOrEmpty(txtPatenteLetras.Text) || !string.IsNullOrEmpty(mskPlacaNumeros.Text))
            //{   
            //    txtPatenteLetras.Enabled = true;
            //    mskPlacaNumeros.Enabled = true;
            //    txtPatente.Enabled = false;
            //}
            //else
            //{
            //    txtPatenteLetras.Enabled = false;
            //    mskPlacaNumeros.Enabled = false;
            //    txtPatente.Enabled = true;
            //}
        }

        
    }
}
