namespace Encuestador
{
    partial class frmMotivoViajes
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDistanciaViaje = new System.Windows.Forms.ComboBox();
            this.cmbMotivoViaje = new System.Windows.Forms.ComboBox();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.lblExplicacionEncuesta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Motivo de Viaje:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Distancia de Viaje:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cmbDistanciaViaje
            // 
            this.cmbDistanciaViaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDistanciaViaje.FormattingEnabled = true;
            this.cmbDistanciaViaje.Location = new System.Drawing.Point(134, 80);
            this.cmbDistanciaViaje.Name = "cmbDistanciaViaje";
            this.cmbDistanciaViaje.Size = new System.Drawing.Size(199, 24);
            this.cmbDistanciaViaje.TabIndex = 2;
            this.cmbDistanciaViaje.SelectedIndexChanged += new System.EventHandler(this.cmbDistanciaViaje_SelectedIndexChanged);
            // 
            // cmbMotivoViaje
            // 
            this.cmbMotivoViaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMotivoViaje.FormattingEnabled = true;
            this.cmbMotivoViaje.Location = new System.Drawing.Point(134, 121);
            this.cmbMotivoViaje.Name = "cmbMotivoViaje";
            this.cmbMotivoViaje.Size = new System.Drawing.Size(199, 24);
            this.cmbMotivoViaje.TabIndex = 4;
            this.cmbMotivoViaje.SelectedIndexChanged += new System.EventHandler(this.cmbMotivoViaje_SelectedIndexChanged);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.Location = new System.Drawing.Point(209, 160);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(124, 32);
            this.btnSiguiente.TabIndex = 5;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // lblExplicacionEncuesta
            // 
            this.lblExplicacionEncuesta.AutoSize = true;
            this.lblExplicacionEncuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplicacionEncuesta.Location = new System.Drawing.Point(10, 18);
            this.lblExplicacionEncuesta.Name = "lblExplicacionEncuesta";
            this.lblExplicacionEncuesta.Size = new System.Drawing.Size(176, 17);
            this.lblExplicacionEncuesta.TabIndex = 0;
            this.lblExplicacionEncuesta.Text = "Explicacion de la Encuesta";
            this.lblExplicacionEncuesta.Click += new System.EventHandler(this.lblExplicacionEncuesta_Click);
            // 
            // frmMotivoViajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 203);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.cmbMotivoViaje);
            this.Controls.Add(this.cmbDistanciaViaje);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblExplicacionEncuesta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMotivoViajes";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Motivo del Viaje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDistanciaViaje;
        private System.Windows.Forms.ComboBox cmbMotivoViaje;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Label lblExplicacionEncuesta;
    }
}