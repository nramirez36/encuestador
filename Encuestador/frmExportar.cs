using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Encuestador.Entities;
using Encuestador.BL;
using Encuestador.Utiles;
using Encuestador.Excel;
using System.IO;

namespace Encuestador
{
    public partial class frmExportar : Form
    {
        #region Variables
        private string pPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Reportes\\";
        private string pMensaje = "Se encontraron #n resultados";
        private bool pBajaRealizada = false;
        private DateTime pFechaDesdeSeleccionada;
        private DateTime pFechaHastaSeleccionada;
        private Login pUsuarioSeleccionado;
        private List<EncuestaReportar> pListaResultado;
        #endregion

        #region Propiedades
        private GestorRespuestas pGestorRespuestas = new GestorRespuestas();
        private GestorUsuarioEncuestador pGestorUsuarios = new GestorUsuarioEncuestador();
        #endregion

        #region Constuctor

        #endregion

        #region Metodos
        private void buscarEncuestas()
        {
            try
            {
                if (validar())
                {
                    lblResultados.Text = pMensaje;
                    pFechaDesdeSeleccionada = dtpDesde.Value;
                    pFechaHastaSeleccionada = dtpHasta.Value;

                    pListaResultado = pGestorRespuestas.ObtenerEncuestasParametros(pFechaDesdeSeleccionada, pFechaHastaSeleccionada, pUsuarioSeleccionado.IdEncuestador);
                    var cont = pListaResultado.Count;
                    lblResultados.Text = lblResultados.Text.Replace("#n", cont.ToString());
                    lblResultados.Visible = true;
                    if (cont > 0)
                    {
                        lblResultados.ForeColor = Color.Green;
                        btnExportarCSV.Visible = true;
                        btnExportarXLS.Visible = true;
                    }
                    else
                    {
                        lblResultados.ForeColor = Color.Red;
                        btnExportarCSV.Visible = false;
                        btnExportarXLS.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CargarUsuarios()
        {
            try
            {
                var lista = pGestorUsuarios.ObtenerTodosUsuarios().ToList();
                lista.Add(new Login() { IdEncuestador = 0, User = "Todos" });
                var listaOrdenada = lista.OrderBy(x => x.IdEncuestador).ToList();
                cmbUsuarios.DataSource = listaOrdenada;
                cmbUsuarios.DisplayMember = "User";
                cmbUsuarios.ValueMember = "IdEncuestador";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool validar()
        {
            if (dtpDesde.Value <= DateTime.MinValue || dtpDesde.Value >= DateTime.MaxValue || dtpDesde.Value >= DateTime.Now)
            {
                MessageBox.Show("Debe seleccionar una Fecha anterior a la actual", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (dtpHasta.Value <= DateTime.MinValue || dtpHasta.Value >= DateTime.MaxValue || dtpHasta.Value >= DateTime.Now)
            {
                MessageBox.Show("Debe seleccionar una Fecha anterior a la actual", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cmbUsuarios.SelectedValue == null || int.Parse(cmbUsuarios.SelectedValue.ToString()) < 0 || pUsuarioSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar el Usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void CrearDirectorio()
        {
            if (!Directory.Exists(pPath))
                Directory.CreateDirectory(pPath);
        }

        private void borrarEncuestasExportadas()
        {
            var filas = 0;
            try
            {
                foreach (var item in pListaResultado)
                {
                    filas += pGestorRespuestas.EliminarEncuesta(item);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Eventos

        public frmExportar()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscarEncuestas();
        }

        private void cmbUsuarios_DropDown(object sender, EventArgs e)
        {
            int pw = -1;
            Comunes.GetLargestTextExtent(this.cmbUsuarios, ref pw);
            this.cmbUsuarios.DropDownWidth = pw;
        }

        private void frmExportar_Load(object sender, EventArgs e)
        {
            try
            {
                CrearDirectorio();
                CargarUsuarios();
                dtpDesde.Value = DateTime.Now.AddDays(-7);
                dtpHasta.Value = DateTime.Now.AddDays(-1);
                cmbUsuarios.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void dtpDesde_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDesde.Value >= DateTime.Now)
            {

                return;
            }
            pFechaDesdeSeleccionada = dtpDesde.Value;
        }

        private void dtpHasta_ValueChanged(object sender, EventArgs e)
        {
            if (dtpHasta.Value >= DateTime.Now)
            {
                MessageBox.Show("Debe seleccionar una Fecha anterior a la actual", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            pFechaHastaSeleccionada = dtpHasta.Value;
        }

        private void cmbUsuarios_SelectionChangeCommitted(object sender, EventArgs e)
        {
            pUsuarioSeleccionado = (Login)cmbUsuarios.SelectedItem;
        }

        private void btnExportarXLS_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            var obj = new ExcelUtility();
            var dt = Comunes.ConvertToDataTable(pListaResultado);

            obj.WriteDataTableToExcel(dt, "Encuestas_fecha", pPath + "Reporte_" + DateTime.Now.ToString("YYYYMMddHHmmss") + ".xls", "Encuestas de los días " + pFechaDesdeSeleccionada.ToShortDateString() + " y " + pFechaHastaSeleccionada.ToShortDateString() + " correspondiente a " + pUsuarioSeleccionado.User);

            if (!pBajaRealizada)
                borrarEncuestasExportadas();

            MessageBox.Show("Se creo correctamente el archivo");
            this.Cursor = Cursors.Default;

        }

        private void btnExportarCSV_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            pListaResultado.ToCSV<EncuestaReportar>(path: pPath + "Reporte_" + DateTime.Now.ToString("YYYYMMddHHmmss") + ".csv");

            if (!pBajaRealizada)
                borrarEncuestasExportadas();

            MessageBox.Show("Se creo correctamente el archivo");
            this.Cursor = Cursors.Default;
        }
        #endregion

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
