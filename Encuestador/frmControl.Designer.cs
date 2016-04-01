namespace Encuestador
{
    partial class frmControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmControl));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pbPorcentajeAvance = new System.Windows.Forms.ToolStripProgressBar();
            this.panelSitiosEncuestas = new System.Windows.Forms.Panel();
            this.cmbSentido = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSitios = new System.Windows.Forms.ComboBox();
            this.btnIrDatosVehiculos = new System.Windows.Forms.Button();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelDatosVehiculo = new System.Windows.Forms.Panel();
            this.txtFechaHoraEncuesta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.btnIrMotivoViajes = new System.Windows.Forms.Button();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panelMotivoViaje = new System.Windows.Forms.Panel();
            this.btnIrCasos = new System.Windows.Forms.Button();
            this.cmbMotivoViaje = new System.Windows.Forms.ComboBox();
            this.cmbDistanciaViaje = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblExplicacionEncuesta = new System.Windows.Forms.Label();
            this.panelCaso1 = new System.Windows.Forms.Panel();
            this.btnIrACaso2 = new System.Windows.Forms.Button();
            this.ucCaso1 = new Encuestador.ucCaso();
            this.panelCaso2 = new System.Windows.Forms.Panel();
            this.btnIrACaso3 = new System.Windows.Forms.Button();
            this.ucCaso2 = new Encuestador.ucCaso();
            this.panelCaso3 = new System.Windows.Forms.Panel();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.ucCaso3 = new Encuestador.ucCaso();
            this.statusStrip1.SuspendLayout();
            this.panelSitiosEncuestas.SuspendLayout();
            this.panelDatosVehiculo.SuspendLayout();
            this.panelMotivoViaje.SuspendLayout();
            this.panelCaso1.SuspendLayout();
            this.panelCaso2.SuspendLayout();
            this.panelCaso3.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pbPorcentajeAvance});
            this.statusStrip1.Location = new System.Drawing.Point(0, 489);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(765, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // pbPorcentajeAvance
            // 
            this.pbPorcentajeAvance.Margin = new System.Windows.Forms.Padding(170, 1, 1, 1);
            this.pbPorcentajeAvance.Name = "pbPorcentajeAvance";
            this.pbPorcentajeAvance.Size = new System.Drawing.Size(400, 20);
            this.pbPorcentajeAvance.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // panelSitiosEncuestas
            // 
            this.panelSitiosEncuestas.Controls.Add(this.cmbSentido);
            this.panelSitiosEncuestas.Controls.Add(this.label3);
            this.panelSitiosEncuestas.Controls.Add(this.label2);
            this.panelSitiosEncuestas.Controls.Add(this.cmbSitios);
            this.panelSitiosEncuestas.Controls.Add(this.btnIrDatosVehiculos);
            this.panelSitiosEncuestas.Controls.Add(this.txtUbicacion);
            this.panelSitiosEncuestas.Controls.Add(this.label4);
            this.panelSitiosEncuestas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSitiosEncuestas.Location = new System.Drawing.Point(0, 0);
            this.panelSitiosEncuestas.Name = "panelSitiosEncuestas";
            this.panelSitiosEncuestas.Size = new System.Drawing.Size(765, 489);
            this.panelSitiosEncuestas.TabIndex = 0;
            // 
            // cmbSentido
            // 
            this.cmbSentido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSentido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSentido.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSentido.FormattingEnabled = true;
            this.cmbSentido.Location = new System.Drawing.Point(242, 164);
            this.cmbSentido.Name = "cmbSentido";
            this.cmbSentido.Size = new System.Drawing.Size(511, 37);
            this.cmbSentido.TabIndex = 5;
            this.cmbSentido.DropDown += new System.EventHandler(this.cmbSentido_DropDown);
            this.cmbSentido.SelectionChangeCommitted += new System.EventHandler(this.cmbSentido_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sentido:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ubicación:";
            // 
            // cmbSitios
            // 
            this.cmbSitios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSitios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSitios.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSitios.FormattingEnabled = true;
            this.cmbSitios.IntegralHeight = false;
            this.cmbSitios.ItemHeight = 29;
            this.cmbSitios.Location = new System.Drawing.Point(242, 16);
            this.cmbSitios.Name = "cmbSitios";
            this.cmbSitios.Size = new System.Drawing.Size(511, 37);
            this.cmbSitios.TabIndex = 1;
            this.cmbSitios.DropDown += new System.EventHandler(this.cmbSitios_DropDown);
            this.cmbSitios.SelectionChangeCommitted += new System.EventHandler(this.cmbSitios_SelectionChangeCommitted);
            // 
            // btnIrDatosVehiculos
            // 
            this.btnIrDatosVehiculos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIrDatosVehiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIrDatosVehiculos.Location = new System.Drawing.Point(554, 372);
            this.btnIrDatosVehiculos.Name = "btnIrDatosVehiculos";
            this.btnIrDatosVehiculos.Size = new System.Drawing.Size(199, 48);
            this.btnIrDatosVehiculos.TabIndex = 6;
            this.btnIrDatosVehiculos.Text = "Siguiente";
            this.btnIrDatosVehiculos.UseVisualStyleBackColor = true;
            this.btnIrDatosVehiculos.Click += new System.EventHandler(this.btnIrDatosVehiculos_Click);
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUbicacion.Enabled = false;
            this.txtUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUbicacion.Location = new System.Drawing.Point(242, 69);
            this.txtUbicacion.Multiline = true;
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(511, 74);
            this.txtUbicacion.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Número de Sitio:";
            // 
            // panelDatosVehiculo
            // 
            this.panelDatosVehiculo.Controls.Add(this.txtFechaHoraEncuesta);
            this.panelDatosVehiculo.Controls.Add(this.label5);
            this.panelDatosVehiculo.Controls.Add(this.label6);
            this.panelDatosVehiculo.Controls.Add(this.cmbTipoVehiculo);
            this.panelDatosVehiculo.Controls.Add(this.btnIrMotivoViajes);
            this.panelDatosVehiculo.Controls.Add(this.txtPatente);
            this.panelDatosVehiculo.Controls.Add(this.label7);
            this.panelDatosVehiculo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDatosVehiculo.Location = new System.Drawing.Point(0, 0);
            this.panelDatosVehiculo.Name = "panelDatosVehiculo";
            this.panelDatosVehiculo.Size = new System.Drawing.Size(765, 489);
            this.panelDatosVehiculo.TabIndex = 1;
            this.panelDatosVehiculo.Visible = false;
            // 
            // txtFechaHoraEncuesta
            // 
            this.txtFechaHoraEncuesta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFechaHoraEncuesta.Enabled = false;
            this.txtFechaHoraEncuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaHoraEncuesta.Location = new System.Drawing.Point(273, 113);
            this.txtFechaHoraEncuesta.Name = "txtFechaHoraEncuesta";
            this.txtFechaHoraEncuesta.Size = new System.Drawing.Size(480, 35);
            this.txtFechaHoraEncuesta.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 29);
            this.label5.TabIndex = 4;
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
            this.cmbTipoVehiculo.Size = new System.Drawing.Size(480, 37);
            this.cmbTipoVehiculo.TabIndex = 1;
            this.cmbTipoVehiculo.DropDown += new System.EventHandler(this.cmbTipoVehiculo_DropDown);
            this.cmbTipoVehiculo.SelectionChangeCommitted += new System.EventHandler(this.cmbTipoVehiculo_SelectionChangeCommitted);
            // 
            // btnIrMotivoViajes
            // 
            this.btnIrMotivoViajes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIrMotivoViajes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIrMotivoViajes.Location = new System.Drawing.Point(554, 372);
            this.btnIrMotivoViajes.Name = "btnIrMotivoViajes";
            this.btnIrMotivoViajes.Size = new System.Drawing.Size(199, 48);
            this.btnIrMotivoViajes.TabIndex = 6;
            this.btnIrMotivoViajes.Text = "Siguiente";
            this.btnIrMotivoViajes.UseVisualStyleBackColor = true;
            this.btnIrMotivoViajes.Click += new System.EventHandler(this.btnIrMotivoViajes_Click);
            // 
            // txtPatente
            // 
            this.txtPatente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPatente.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatente.Location = new System.Drawing.Point(273, 69);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(199, 35);
            this.txtPatente.TabIndex = 3;
            this.txtPatente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPatente_KeyPress);
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
            this.label7.TabIndex = 0;
            this.label7.Text = "Tipo de Vehículo:";
            // 
            // panelMotivoViaje
            // 
            this.panelMotivoViaje.Controls.Add(this.btnIrCasos);
            this.panelMotivoViaje.Controls.Add(this.cmbMotivoViaje);
            this.panelMotivoViaje.Controls.Add(this.cmbDistanciaViaje);
            this.panelMotivoViaje.Controls.Add(this.label8);
            this.panelMotivoViaje.Controls.Add(this.label9);
            this.panelMotivoViaje.Controls.Add(this.lblExplicacionEncuesta);
            this.panelMotivoViaje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMotivoViaje.Location = new System.Drawing.Point(0, 0);
            this.panelMotivoViaje.Name = "panelMotivoViaje";
            this.panelMotivoViaje.Size = new System.Drawing.Size(765, 489);
            this.panelMotivoViaje.TabIndex = 2;
            this.panelMotivoViaje.Visible = false;
            // 
            // btnIrCasos
            // 
            this.btnIrCasos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIrCasos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIrCasos.Location = new System.Drawing.Point(554, 372);
            this.btnIrCasos.Name = "btnIrCasos";
            this.btnIrCasos.Size = new System.Drawing.Size(199, 48);
            this.btnIrCasos.TabIndex = 5;
            this.btnIrCasos.Text = "Siguiente";
            this.btnIrCasos.UseVisualStyleBackColor = true;
            this.btnIrCasos.Click += new System.EventHandler(this.btnIrCasos_Click);
            // 
            // cmbMotivoViaje
            // 
            this.cmbMotivoViaje.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbMotivoViaje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMotivoViaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMotivoViaje.FormattingEnabled = true;
            this.cmbMotivoViaje.Location = new System.Drawing.Point(273, 149);
            this.cmbMotivoViaje.Name = "cmbMotivoViaje";
            this.cmbMotivoViaje.Size = new System.Drawing.Size(480, 37);
            this.cmbMotivoViaje.TabIndex = 4;
            this.cmbMotivoViaje.DropDown += new System.EventHandler(this.cmbMotivoViaje_DropDown);
            this.cmbMotivoViaje.SelectionChangeCommitted += new System.EventHandler(this.cmbMotivoViaje_SelectionChangeCommitted);
            // 
            // cmbDistanciaViaje
            // 
            this.cmbDistanciaViaje.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDistanciaViaje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDistanciaViaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDistanciaViaje.FormattingEnabled = true;
            this.cmbDistanciaViaje.Location = new System.Drawing.Point(273, 83);
            this.cmbDistanciaViaje.Name = "cmbDistanciaViaje";
            this.cmbDistanciaViaje.Size = new System.Drawing.Size(480, 37);
            this.cmbDistanciaViaje.TabIndex = 2;
            this.cmbDistanciaViaje.DropDown += new System.EventHandler(this.cmbDistanciaViaje_DropDown);
            this.cmbDistanciaViaje.SelectionChangeCommitted += new System.EventHandler(this.cmbDistanciaViaje_SelectionChangeCommitted);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 29);
            this.label8.TabIndex = 3;
            this.label8.Text = "Motivo de Viaje:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(25, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(211, 29);
            this.label9.TabIndex = 1;
            this.label9.Text = "Distancia de Viaje:";
            // 
            // lblExplicacionEncuesta
            // 
            this.lblExplicacionEncuesta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExplicacionEncuesta.AutoSize = true;
            this.lblExplicacionEncuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplicacionEncuesta.Location = new System.Drawing.Point(25, 7);
            this.lblExplicacionEncuesta.Name = "lblExplicacionEncuesta";
            this.lblExplicacionEncuesta.Size = new System.Drawing.Size(624, 58);
            this.lblExplicacionEncuesta.TabIndex = 0;
            this.lblExplicacionEncuesta.Text = "Esta es una encuesta de elección de alternativas de \r\nviajes interurbanos";
            this.lblExplicacionEncuesta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelCaso1
            // 
            this.panelCaso1.Controls.Add(this.btnIrACaso2);
            this.panelCaso1.Controls.Add(this.ucCaso1);
            this.panelCaso1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCaso1.Location = new System.Drawing.Point(0, 0);
            this.panelCaso1.Name = "panelCaso1";
            this.panelCaso1.Size = new System.Drawing.Size(765, 489);
            this.panelCaso1.TabIndex = 3;
            this.panelCaso1.Visible = false;
            // 
            // btnIrACaso2
            // 
            this.btnIrACaso2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIrACaso2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIrACaso2.Location = new System.Drawing.Point(554, 426);
            this.btnIrACaso2.Name = "btnIrACaso2";
            this.btnIrACaso2.Size = new System.Drawing.Size(199, 48);
            this.btnIrACaso2.TabIndex = 1;
            this.btnIrACaso2.Text = "Siguiente";
            this.btnIrACaso2.UseVisualStyleBackColor = true;
            this.btnIrACaso2.Click += new System.EventHandler(this.btnIrACaso2_Click);
            // 
            // ucCaso1
            // 
            this.ucCaso1.CasoSeleccionado = null;
            this.ucCaso1.DistanciaViajeSeleccionada = null;
            this.ucCaso1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCaso1.IdRutaSeleccionada = 0;
            this.ucCaso1.Location = new System.Drawing.Point(0, 0);
            this.ucCaso1.MotivoSeleccionado = null;
            this.ucCaso1.Name = "ucCaso1";
            this.ucCaso1.Size = new System.Drawing.Size(765, 489);
            this.ucCaso1.TabIndex = 0;
            // 
            // panelCaso2
            // 
            this.panelCaso2.Controls.Add(this.btnIrACaso3);
            this.panelCaso2.Controls.Add(this.ucCaso2);
            this.panelCaso2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCaso2.Location = new System.Drawing.Point(0, 0);
            this.panelCaso2.Name = "panelCaso2";
            this.panelCaso2.Size = new System.Drawing.Size(765, 489);
            this.panelCaso2.TabIndex = 6;
            this.panelCaso2.Visible = false;
            // 
            // btnIrACaso3
            // 
            this.btnIrACaso3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIrACaso3.Location = new System.Drawing.Point(554, 426);
            this.btnIrACaso3.Name = "btnIrACaso3";
            this.btnIrACaso3.Size = new System.Drawing.Size(199, 48);
            this.btnIrACaso3.TabIndex = 1;
            this.btnIrACaso3.Text = "Siguiente";
            this.btnIrACaso3.UseVisualStyleBackColor = true;
            this.btnIrACaso3.Click += new System.EventHandler(this.btnIrACaso3_Click);
            // 
            // ucCaso2
            // 
            this.ucCaso2.CasoSeleccionado = null;
            this.ucCaso2.DistanciaViajeSeleccionada = null;
            this.ucCaso2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCaso2.IdRutaSeleccionada = 0;
            this.ucCaso2.Location = new System.Drawing.Point(0, 0);
            this.ucCaso2.MotivoSeleccionado = null;
            this.ucCaso2.Name = "ucCaso2";
            this.ucCaso2.Size = new System.Drawing.Size(765, 489);
            this.ucCaso2.TabIndex = 0;
            // 
            // panelCaso3
            // 
            this.panelCaso3.Controls.Add(this.btnFinalizar);
            this.panelCaso3.Controls.Add(this.ucCaso3);
            this.panelCaso3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCaso3.Location = new System.Drawing.Point(0, 0);
            this.panelCaso3.Name = "panelCaso3";
            this.panelCaso3.Size = new System.Drawing.Size(765, 489);
            this.panelCaso3.TabIndex = 7;
            this.panelCaso3.Visible = false;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.Location = new System.Drawing.Point(554, 426);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(199, 48);
            this.btnFinalizar.TabIndex = 1;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // ucCaso3
            // 
            this.ucCaso3.CasoSeleccionado = null;
            this.ucCaso3.DistanciaViajeSeleccionada = null;
            this.ucCaso3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCaso3.IdRutaSeleccionada = 0;
            this.ucCaso3.Location = new System.Drawing.Point(0, 0);
            this.ucCaso3.MotivoSeleccionado = null;
            this.ucCaso3.Name = "ucCaso3";
            this.ucCaso3.Size = new System.Drawing.Size(765, 489);
            this.ucCaso3.TabIndex = 0;
            // 
            // frmControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 511);
            this.Controls.Add(this.panelCaso1);
            this.Controls.Add(this.panelCaso2);
            this.Controls.Add(this.panelCaso3);
            this.Controls.Add(this.panelSitiosEncuestas);
            this.Controls.Add(this.panelDatosVehiculo);
            this.Controls.Add(this.panelMotivoViaje);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmControl";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Encuesta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmControl_FormClosed);
            this.Load += new System.EventHandler(this.frmControl_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panelSitiosEncuestas.ResumeLayout(false);
            this.panelSitiosEncuestas.PerformLayout();
            this.panelDatosVehiculo.ResumeLayout(false);
            this.panelDatosVehiculo.PerformLayout();
            this.panelMotivoViaje.ResumeLayout(false);
            this.panelMotivoViaje.PerformLayout();
            this.panelCaso1.ResumeLayout(false);
            this.panelCaso2.ResumeLayout(false);
            this.panelCaso3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panelSitiosEncuestas;
        private System.Windows.Forms.ComboBox cmbSentido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSitios;
        private System.Windows.Forms.Button btnIrDatosVehiculos;
        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelDatosVehiculo;
        private System.Windows.Forms.TextBox txtFechaHoraEncuesta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbTipoVehiculo;
        private System.Windows.Forms.Button btnIrMotivoViajes;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelMotivoViaje;
        private System.Windows.Forms.Button btnIrCasos;
        private System.Windows.Forms.ComboBox cmbMotivoViaje;
        private System.Windows.Forms.ComboBox cmbDistanciaViaje;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblExplicacionEncuesta;
        private System.Windows.Forms.ToolStripProgressBar pbPorcentajeAvance;
        private System.Windows.Forms.Panel panelCaso1;
        private System.Windows.Forms.Button btnIrACaso2;
        private ucCaso ucCaso1;
        private System.Windows.Forms.Panel panelCaso2;
        private System.Windows.Forms.Button btnIrACaso3;
        private ucCaso ucCaso2;
        private System.Windows.Forms.Panel panelCaso3;
        private System.Windows.Forms.Button btnFinalizar;
        private ucCaso ucCaso3;
    }
}