namespace Encuestador.UserControls
{
    partial class ucDatosVehiculo
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mskPlacaNumeros = new System.Windows.Forms.MaskedTextBox();
            this.txtFechaHoraEncuesta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chkPlacaExtranjera = new System.Windows.Forms.CheckBox();
            this.txtPatenteLetras = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // mskPlacaNumeros
            // 
            this.mskPlacaNumeros.BeepOnError = true;
            this.mskPlacaNumeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskPlacaNumeros.Location = new System.Drawing.Point(337, 69);
            this.mskPlacaNumeros.Mask = "999";
            this.mskPlacaNumeros.Name = "mskPlacaNumeros";
            this.mskPlacaNumeros.Size = new System.Drawing.Size(58, 35);
            this.mskPlacaNumeros.TabIndex = 4;
            // 
            // txtFechaHoraEncuesta
            // 
            this.txtFechaHoraEncuesta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFechaHoraEncuesta.Enabled = false;
            this.txtFechaHoraEncuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaHoraEncuesta.Location = new System.Drawing.Point(273, 128);
            this.txtFechaHoraEncuesta.Name = "txtFechaHoraEncuesta";
            this.txtFechaHoraEncuesta.Size = new System.Drawing.Size(419, 35);
            this.txtFechaHoraEncuesta.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Fecha Encuesta:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 29);
            this.label6.TabIndex = 2;
            this.label6.Text = "Placa:";
            // 
            // cmbTipoVehiculo
            // 
            this.cmbTipoVehiculo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTipoVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoVehiculo.FormattingEnabled = true;
            this.cmbTipoVehiculo.Location = new System.Drawing.Point(273, 22);
            this.cmbTipoVehiculo.Name = "cmbTipoVehiculo";
            this.cmbTipoVehiculo.Size = new System.Drawing.Size(419, 37);
            this.cmbTipoVehiculo.TabIndex = 1;
            this.cmbTipoVehiculo.DropDown += new System.EventHandler(this.cmbTipoVehiculo_DropDown);
            this.cmbTipoVehiculo.SelectionChangeCommitted += new System.EventHandler(this.cmbTipoVehiculo_SelectionChangeCommitted);
            // 
            // txtPatente
            // 
            this.txtPatente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPatente.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatente.Location = new System.Drawing.Point(273, 69);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(199, 35);
            this.txtPatente.TabIndex = 6;
            this.txtPatente.Visible = false;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 29);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tipo de Vehículo:";
            // 
            // chkPlacaExtranjera
            // 
            this.chkPlacaExtranjera.AutoSize = true;
            this.chkPlacaExtranjera.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPlacaExtranjera.Location = new System.Drawing.Point(478, 72);
            this.chkPlacaExtranjera.Name = "chkPlacaExtranjera";
            this.chkPlacaExtranjera.Size = new System.Drawing.Size(206, 33);
            this.chkPlacaExtranjera.TabIndex = 5;
            this.chkPlacaExtranjera.Text = "Placa Extranjera";
            this.chkPlacaExtranjera.UseVisualStyleBackColor = true;
            this.chkPlacaExtranjera.CheckedChanged += new System.EventHandler(this.chkPlacaExtranjera_CheckedChanged);
            // 
            // txtPatenteLetras
            // 
            this.txtPatenteLetras.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatenteLetras.Location = new System.Drawing.Point(273, 69);
            this.txtPatenteLetras.MaxLength = 3;
            this.txtPatenteLetras.Name = "txtPatenteLetras";
            this.txtPatenteLetras.Size = new System.Drawing.Size(58, 35);
            this.txtPatenteLetras.TabIndex = 3;
            this.txtPatenteLetras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPatenteNro_KeyPress);
            // 
            // ucDatosVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtPatenteLetras);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbTipoVehiculo);
            this.Controls.Add(this.txtFechaHoraEncuesta);
            this.Controls.Add(this.mskPlacaNumeros);
            this.Controls.Add(this.txtPatente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chkPlacaExtranjera);
            this.Name = "ucDatosVehiculo";
            this.Size = new System.Drawing.Size(704, 190);
            this.Load += new System.EventHandler(this.ucDatosVehiculo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskPlacaNumeros;
        private System.Windows.Forms.TextBox txtFechaHoraEncuesta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbTipoVehiculo;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkPlacaExtranjera;
        private System.Windows.Forms.TextBox txtPatenteLetras;
    }
}
