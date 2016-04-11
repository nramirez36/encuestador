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
            this.btnIrDatosVehiculos = new System.Windows.Forms.Button();
            this.ucDatosSitio1 = new Encuestador.UserControls.ucDatosSitio();
            this.panelDatosVehiculo = new System.Windows.Forms.Panel();
            this.btnIrMotivoViajes = new System.Windows.Forms.Button();
            this.ucDatosVehiculo1 = new Encuestador.UserControls.ucDatosVehiculo();
            this.panelMotivoViaje = new System.Windows.Forms.Panel();
            this.btnIrCasos = new System.Windows.Forms.Button();
            this.ucDatosMotivo1 = new Encuestador.UserControls.ucDatosMotivo();
            this.panelCaso1 = new System.Windows.Forms.Panel();
            this.btnCaso2 = new System.Windows.Forms.Button();
            this.ucCaso1 = new Encuestador.UserControls.ucCaso();
            this.btnIrACaso2 = new System.Windows.Forms.Button();
            this.panelCaso2 = new System.Windows.Forms.Panel();
            this.btnCaso3 = new System.Windows.Forms.Button();
            this.ucCaso2 = new Encuestador.UserControls.ucCaso();
            this.btnIrACaso3 = new System.Windows.Forms.Button();
            this.panelCaso3 = new System.Windows.Forms.Panel();
            this.btnFinalizarEncuesta = new System.Windows.Forms.Button();
            this.ucCaso3 = new Encuestador.UserControls.ucCaso();
            this.btnFinalizar = new System.Windows.Forms.Button();
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
            this.panelSitiosEncuestas.Controls.Add(this.btnIrDatosVehiculos);
            this.panelSitiosEncuestas.Controls.Add(this.ucDatosSitio1);
            this.panelSitiosEncuestas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSitiosEncuestas.Location = new System.Drawing.Point(0, 0);
            this.panelSitiosEncuestas.Name = "panelSitiosEncuestas";
            this.panelSitiosEncuestas.Size = new System.Drawing.Size(765, 489);
            this.panelSitiosEncuestas.TabIndex = 0;
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
            // ucDatosSitio1
            // 
            this.ucDatosSitio1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDatosSitio1.Location = new System.Drawing.Point(0, 0);
            this.ucDatosSitio1.Name = "ucDatosSitio1";
            this.ucDatosSitio1.oRespuesta = null;
            this.ucDatosSitio1.Size = new System.Drawing.Size(765, 489);
            this.ucDatosSitio1.TabIndex = 7;
            // 
            // panelDatosVehiculo
            // 
            this.panelDatosVehiculo.Controls.Add(this.btnIrMotivoViajes);
            this.panelDatosVehiculo.Controls.Add(this.ucDatosVehiculo1);
            this.panelDatosVehiculo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDatosVehiculo.Location = new System.Drawing.Point(0, 0);
            this.panelDatosVehiculo.Name = "panelDatosVehiculo";
            this.panelDatosVehiculo.Size = new System.Drawing.Size(765, 489);
            this.panelDatosVehiculo.TabIndex = 1;
            this.panelDatosVehiculo.Visible = false;
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
            // ucDatosVehiculo1
            // 
            this.ucDatosVehiculo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDatosVehiculo1.Location = new System.Drawing.Point(0, 0);
            this.ucDatosVehiculo1.Name = "ucDatosVehiculo1";
            this.ucDatosVehiculo1.oRespuesta = null;
            this.ucDatosVehiculo1.Size = new System.Drawing.Size(765, 489);
            this.ucDatosVehiculo1.TabIndex = 7;
            // 
            // panelMotivoViaje
            // 
            this.panelMotivoViaje.Controls.Add(this.btnIrCasos);
            this.panelMotivoViaje.Controls.Add(this.ucDatosMotivo1);
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
            // ucDatosMotivo1
            // 
            this.ucDatosMotivo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDatosMotivo1.Location = new System.Drawing.Point(0, 0);
            this.ucDatosMotivo1.Name = "ucDatosMotivo1";
            this.ucDatosMotivo1.oRespuesta = null;
            this.ucDatosMotivo1.pDistanciaSeleccionada = null;
            this.ucDatosMotivo1.pMotivoSeleccionado = null;
            this.ucDatosMotivo1.Size = new System.Drawing.Size(765, 489);
            this.ucDatosMotivo1.TabIndex = 6;
            // 
            // panelCaso1
            // 
            this.panelCaso1.Controls.Add(this.btnCaso2);
            this.panelCaso1.Controls.Add(this.ucCaso1);
            this.panelCaso1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCaso1.Location = new System.Drawing.Point(0, 0);
            this.panelCaso1.Name = "panelCaso1";
            this.panelCaso1.Size = new System.Drawing.Size(765, 489);
            this.panelCaso1.TabIndex = 3;
            // 
            // btnCaso2
            // 
            this.btnCaso2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCaso2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaso2.Location = new System.Drawing.Point(554, 426);
            this.btnCaso2.Name = "btnCaso2";
            this.btnCaso2.Size = new System.Drawing.Size(199, 48);
            this.btnCaso2.TabIndex = 7;
            this.btnCaso2.Text = "Siguiente";
            this.btnCaso2.UseVisualStyleBackColor = true;
            this.btnCaso2.Click += new System.EventHandler(this.btnCaso2_Click);
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
            // btnIrACaso2
            // 
            this.btnIrACaso2.Location = new System.Drawing.Point(0, 0);
            this.btnIrACaso2.Name = "btnIrACaso2";
            this.btnIrACaso2.Size = new System.Drawing.Size(75, 23);
            this.btnIrACaso2.TabIndex = 0;
            // 
            // panelCaso2
            // 
            this.panelCaso2.Controls.Add(this.btnCaso3);
            this.panelCaso2.Controls.Add(this.ucCaso2);
            this.panelCaso2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCaso2.Location = new System.Drawing.Point(0, 0);
            this.panelCaso2.Name = "panelCaso2";
            this.panelCaso2.Size = new System.Drawing.Size(765, 489);
            this.panelCaso2.TabIndex = 4;
            // 
            // btnCaso3
            // 
            this.btnCaso3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCaso3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaso3.Location = new System.Drawing.Point(554, 426);
            this.btnCaso3.Name = "btnCaso3";
            this.btnCaso3.Size = new System.Drawing.Size(199, 48);
            this.btnCaso3.TabIndex = 7;
            this.btnCaso3.Text = "Siguiente";
            this.btnCaso3.UseVisualStyleBackColor = true;
            this.btnCaso3.Click += new System.EventHandler(this.btnCaso3_Click);
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
            // btnIrACaso3
            // 
            this.btnIrACaso3.Location = new System.Drawing.Point(0, 0);
            this.btnIrACaso3.Name = "btnIrACaso3";
            this.btnIrACaso3.Size = new System.Drawing.Size(75, 23);
            this.btnIrACaso3.TabIndex = 0;
            // 
            // panelCaso3
            // 
            this.panelCaso3.Controls.Add(this.btnFinalizarEncuesta);
            this.panelCaso3.Controls.Add(this.ucCaso3);
            this.panelCaso3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCaso3.Location = new System.Drawing.Point(0, 0);
            this.panelCaso3.Name = "panelCaso3";
            this.panelCaso3.Size = new System.Drawing.Size(765, 489);
            this.panelCaso3.TabIndex = 5;
            // 
            // btnFinalizarEncuesta
            // 
            this.btnFinalizarEncuesta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinalizarEncuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarEncuesta.Location = new System.Drawing.Point(554, 426);
            this.btnFinalizarEncuesta.Name = "btnFinalizarEncuesta";
            this.btnFinalizarEncuesta.Size = new System.Drawing.Size(199, 48);
            this.btnFinalizarEncuesta.TabIndex = 7;
            this.btnFinalizarEncuesta.Text = "Siguiente";
            this.btnFinalizarEncuesta.UseVisualStyleBackColor = true;
            this.btnFinalizarEncuesta.Click += new System.EventHandler(this.btnFinalizarEncuesta_Click);
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
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(0, 0);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(75, 23);
            this.btnFinalizar.TabIndex = 0;
            // 
            // frmControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 511);
            this.Controls.Add(this.panelSitiosEncuestas);
            this.Controls.Add(this.panelDatosVehiculo);
            this.Controls.Add(this.panelMotivoViaje);
            this.Controls.Add(this.panelCaso1);
            this.Controls.Add(this.panelCaso2);
            this.Controls.Add(this.panelCaso3);
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
            this.panelDatosVehiculo.ResumeLayout(false);
            this.panelMotivoViaje.ResumeLayout(false);
            this.panelCaso1.ResumeLayout(false);
            this.panelCaso2.ResumeLayout(false);
            this.panelCaso3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panelSitiosEncuestas;
        private System.Windows.Forms.Button btnIrDatosVehiculos;
        private System.Windows.Forms.Panel panelDatosVehiculo;
        private System.Windows.Forms.Button btnIrMotivoViajes;
        private System.Windows.Forms.Panel panelMotivoViaje;
        private System.Windows.Forms.Button btnIrCasos;
        private System.Windows.Forms.ToolStripProgressBar pbPorcentajeAvance;
        private System.Windows.Forms.Panel panelCaso1;
        private System.Windows.Forms.Button btnIrACaso2;
        private System.Windows.Forms.Panel panelCaso2;
        private System.Windows.Forms.Button btnIrACaso3;
        private System.Windows.Forms.Panel panelCaso3;
        private System.Windows.Forms.Button btnFinalizar;
        private UserControls.ucDatosVehiculo ucDatosVehiculo1;
        private UserControls.ucDatosSitio ucDatosSitio1;
        private UserControls.ucDatosMotivo ucDatosMotivo1;
        private UserControls.ucCaso ucCaso3;
        private UserControls.ucCaso ucCaso2;
        private UserControls.ucCaso ucCaso1;
        private System.Windows.Forms.Button btnCaso2;
        private System.Windows.Forms.Button btnCaso3;
        private System.Windows.Forms.Button btnFinalizarEncuesta;
    }
}