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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelNroEncuesta = new System.Windows.Forms.Panel();
            this.panelSitiosEncuestas = new System.Windows.Forms.Panel();
            this.btnIrSitiosEncuesta = new System.Windows.Forms.Button();
            this.txtNroEncuesta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.statusStrip1.SuspendLayout();
            this.panelNroEncuesta.SuspendLayout();
            this.panelSitiosEncuestas.SuspendLayout();
            this.panelDatosVehiculo.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 189);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(372, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(224, 17);
            this.toolStripStatusLabel1.Text = "Aca voy a indicar el porcentaje de avance";
            // 
            // panelNroEncuesta
            // 
            this.panelNroEncuesta.Controls.Add(this.btnIrSitiosEncuesta);
            this.panelNroEncuesta.Controls.Add(this.txtNroEncuesta);
            this.panelNroEncuesta.Controls.Add(this.label1);
            this.panelNroEncuesta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNroEncuesta.Location = new System.Drawing.Point(0, 0);
            this.panelNroEncuesta.Name = "panelNroEncuesta";
            this.panelNroEncuesta.Size = new System.Drawing.Size(372, 189);
            this.panelNroEncuesta.TabIndex = 1;
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
            this.panelSitiosEncuestas.Size = new System.Drawing.Size(372, 189);
            this.panelSitiosEncuestas.TabIndex = 6;
            // 
            // btnIrSitiosEncuesta
            // 
            this.btnIrSitiosEncuesta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIrSitiosEncuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIrSitiosEncuesta.Location = new System.Drawing.Point(236, 137);
            this.btnIrSitiosEncuesta.Name = "btnIrSitiosEncuesta";
            this.btnIrSitiosEncuesta.Size = new System.Drawing.Size(124, 32);
            this.btnIrSitiosEncuesta.TabIndex = 5;
            this.btnIrSitiosEncuesta.Text = "Siguiente";
            this.btnIrSitiosEncuesta.UseVisualStyleBackColor = true;
            this.btnIrSitiosEncuesta.Click += new System.EventHandler(this.btnIrSitiosEncuesta_Click);
            // 
            // txtNroEncuesta
            // 
            this.txtNroEncuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroEncuesta.Location = new System.Drawing.Point(15, 39);
            this.txtNroEncuesta.Name = "txtNroEncuesta";
            this.txtNroEncuesta.Size = new System.Drawing.Size(213, 26);
            this.txtNroEncuesta.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingresar el Número de Encuesta:";
            // 
            // cmbSentido
            // 
            this.cmbSentido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSentido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSentido.FormattingEnabled = true;
            this.cmbSentido.Items.AddRange(new object[] {
            "Ida",
            "Vuelta"});
            this.cmbSentido.Location = new System.Drawing.Point(135, 106);
            this.cmbSentido.Name = "cmbSentido";
            this.cmbSentido.Size = new System.Drawing.Size(199, 24);
            this.cmbSentido.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Sentido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ubicación:";
            // 
            // cmbSitios
            // 
            this.cmbSitios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSitios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSitios.FormattingEnabled = true;
            this.cmbSitios.Location = new System.Drawing.Point(135, 16);
            this.cmbSitios.Name = "cmbSitios";
            this.cmbSitios.Size = new System.Drawing.Size(199, 24);
            this.cmbSitios.TabIndex = 8;
            // 
            // btnIrDatosVehiculos
            // 
            this.btnIrDatosVehiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIrDatosVehiculos.Location = new System.Drawing.Point(210, 146);
            this.btnIrDatosVehiculos.Name = "btnIrDatosVehiculos";
            this.btnIrDatosVehiculos.Size = new System.Drawing.Size(124, 32);
            this.btnIrDatosVehiculos.TabIndex = 13;
            this.btnIrDatosVehiculos.Text = "Siguiente";
            this.btnIrDatosVehiculos.UseVisualStyleBackColor = true;
            this.btnIrDatosVehiculos.Click += new System.EventHandler(this.btnIrDatosVehiculos_Click);
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Enabled = false;
            this.txtUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUbicacion.Location = new System.Drawing.Point(135, 61);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(199, 26);
            this.txtUbicacion.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 7;
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
            this.panelDatosVehiculo.Size = new System.Drawing.Size(372, 189);
            this.panelDatosVehiculo.TabIndex = 14;
            // 
            // txtFechaHoraEncuesta
            // 
            this.txtFechaHoraEncuesta.Enabled = false;
            this.txtFechaHoraEncuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaHoraEncuesta.Location = new System.Drawing.Point(149, 92);
            this.txtFechaHoraEncuesta.Name = "txtFechaHoraEncuesta";
            this.txtFechaHoraEncuesta.Size = new System.Drawing.Size(199, 26);
            this.txtFechaHoraEncuesta.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fecha Encuesta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Patente:";
            // 
            // cmbTipoVehiculo
            // 
            this.cmbTipoVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoVehiculo.FormattingEnabled = true;
            this.cmbTipoVehiculo.Location = new System.Drawing.Point(149, 12);
            this.cmbTipoVehiculo.Name = "cmbTipoVehiculo";
            this.cmbTipoVehiculo.Size = new System.Drawing.Size(199, 24);
            this.cmbTipoVehiculo.TabIndex = 8;
            // 
            // btnIrMotivoViajes
            // 
            this.btnIrMotivoViajes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIrMotivoViajes.Location = new System.Drawing.Point(224, 145);
            this.btnIrMotivoViajes.Name = "btnIrMotivoViajes";
            this.btnIrMotivoViajes.Size = new System.Drawing.Size(124, 32);
            this.btnIrMotivoViajes.TabIndex = 13;
            this.btnIrMotivoViajes.Text = "Siguiente";
            this.btnIrMotivoViajes.UseVisualStyleBackColor = true;
            this.btnIrMotivoViajes.Click += new System.EventHandler(this.btnIrMotivoViajes_Click);
            // 
            // txtPatente
            // 
            this.txtPatente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatente.Location = new System.Drawing.Point(149, 51);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(199, 26);
            this.txtPatente.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Tipo de Vehículo:";
            // 
            // frmControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 211);
            this.Controls.Add(this.panelDatosVehiculo);
            this.Controls.Add(this.panelSitiosEncuestas);
            this.Controls.Add(this.panelNroEncuesta);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmControl";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "frmControl";
            this.Load += new System.EventHandler(this.frmControl_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panelNroEncuesta.ResumeLayout(false);
            this.panelNroEncuesta.PerformLayout();
            this.panelSitiosEncuestas.ResumeLayout(false);
            this.panelSitiosEncuestas.PerformLayout();
            this.panelDatosVehiculo.ResumeLayout(false);
            this.panelDatosVehiculo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel panelNroEncuesta;
        private System.Windows.Forms.Button btnIrSitiosEncuesta;
        private System.Windows.Forms.TextBox txtNroEncuesta;
        private System.Windows.Forms.Label label1;
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
    }
}