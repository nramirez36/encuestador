using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Encuestador.Entities;
using Encuestador.BL;
using Encuestador.Utiles;
using nramirez36.Logger;
namespace Encuestador
{
    public partial class frmExportar : Form
    {
        #region Variables
        private string pMensaje = "Se encontraron #n resultados";
        private DateTime pFechaDesdeSeleccionada;
        private DateTime pFechaHastaSeleccionada;
        private Login pUsuarioSeleccionado;
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
                    //var lista = pGestorRespuestas.ObtenerEncuestas().ToList();
                    lblResultados.Text = pMensaje;
                    pFechaDesdeSeleccionada = dtpDesde.Value;
                    pFechaHastaSeleccionada = dtpHasta.Value;
                    
                    var lista = pGestorRespuestas.ObtenerEncuestasParametros(pFechaDesdeSeleccionada, pFechaHastaSeleccionada, pUsuarioSeleccionado.IdEncuestador);
                    var cont = lista.Count;
                    lblResultados.Text = lblResultados.Text.Replace("#n", cont.ToString());
                    lblResultados.Visible = true;
                    if (lista.Count > 0)
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
                Logger.WriteXMLError("frmExportar", "frmExportar", "buscarEncuestas", ex.Message);
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
                Logger.WriteXMLError("frmExportar", "frmExportar", "CargarUsuarios", ex.Message);
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

        //public void ListToExcel(List<string> list)
        //{
        //    //start excel
        //    NsExcel.ApplicationClass excapp = new Microsoft.Office.Interop.Excel.ApplicationClass();

        //    //if you want to make excel visible           
        //    excapp.Visible = true;

        //    //create a blank workbook
        //    var workbook = excapp.Workbooks.Add(NsExcel.XlWBATemplate.xlWBATWorksheet);

        //    //or open one - this is no pleasant, but yue're probably interested in the first parameter
        //    string workbookPath = "C:\test.xls";
        //    var workbook = Workbooks.Open(workbookPath,
        //        0, false, 5, "", "", false, Excel.XlPlatform.xlWindows, "",
        //        true, false, 0, true, false, false);

        //    //Not done yet. You have to work on a specific sheet - note the cast
        //    //You may not have any sheets at all. Then you have to add one with NsExcel.Worksheet.Add()
        //    var sheet = (NsExcel.Worksheet)workbook.Sheets[1]; //indexing starts from 1

        //    //do something usefull: you select now an individual cell
        //    var range = sheet.get_Range("A1", "A1");
        //    range.Value2 = "test"; //Value2 is not a typo

        //    //now the list
        //    string cellName;
        //    int counter = 1;
        //    foreach (var item in list)
        //    {
        //        cellName = "A" + counter.ToString();
        //        var range = sheet.get_Range(cellName, cellName);
        //        range.Value2 = item.ToString();
        //        ++counter;
        //    }

        //    //you've probably got the point by now, so a detailed explanation about workbook.SaveAs and workbook.Close is not necessary
        //    //important: if you did not make excel visible terminating your application will terminate excel as well - I tested it
        //    //but if you did it - to be honest - I don't know how to close the main excel window - maybee somewhere around excapp.Windows or excapp.ActiveWindow
        //}
        #endregion

        #region Eventos

        #endregion
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
                CargarUsuarios();
                dtpDesde.Value = DateTime.Now.AddDays(-7);
                dtpHasta.Value = DateTime.Now.AddDays(-1);
                cmbUsuarios.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                Logger.WriteXMLError("frmExportar", "frmExportar", "frmExportar_Load", ex.Message);
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
    }
}
