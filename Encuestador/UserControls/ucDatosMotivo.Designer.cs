namespace Encuestador.UserControls
{
    partial class ucDatosMotivo
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
            this.cmbMotivoViaje = new System.Windows.Forms.ComboBox();
            this.cmbDistanciaViaje = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblExplicacionEncuesta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mskDistancia = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // cmbMotivoViaje
            // 
            this.cmbMotivoViaje.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbMotivoViaje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMotivoViaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMotivoViaje.FormattingEnabled = true;
            this.cmbMotivoViaje.Location = new System.Drawing.Point(251, 207);
            this.cmbMotivoViaje.Name = "cmbMotivoViaje";
            this.cmbMotivoViaje.Size = new System.Drawing.Size(376, 37);
            this.cmbMotivoViaje.TabIndex = 7;
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
            this.cmbDistanciaViaje.Location = new System.Drawing.Point(251, 143);
            this.cmbDistanciaViaje.Name = "cmbDistanciaViaje";
            this.cmbDistanciaViaje.Size = new System.Drawing.Size(376, 37);
            this.cmbDistanciaViaje.TabIndex = 5;
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
            this.label8.Location = new System.Drawing.Point(3, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 29);
            this.label8.TabIndex = 6;
            this.label8.Text = "Motivo de Viaje:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 88);
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
            this.lblExplicacionEncuesta.Location = new System.Drawing.Point(3, 12);
            this.lblExplicacionEncuesta.Name = "lblExplicacionEncuesta";
            this.lblExplicacionEncuesta.Size = new System.Drawing.Size(624, 58);
            this.lblExplicacionEncuesta.TabIndex = 0;
            this.lblExplicacionEncuesta.Text = "Esta es una encuesta de elección de alternativas de \r\nviajes interurbanos";
            this.lblExplicacionEncuesta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tiempo de Viaje:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(424, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Km";
            // 
            // mskDistancia
            // 
            this.mskDistancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskDistancia.Location = new System.Drawing.Point(251, 88);
            this.mskDistancia.Mask = "99999999";
            this.mskDistancia.Name = "mskDistancia";
            this.mskDistancia.Size = new System.Drawing.Size(167, 32);
            this.mskDistancia.TabIndex = 2;
            // 
            // ucDatosMotivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mskDistancia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMotivoViaje);
            this.Controls.Add(this.cmbDistanciaViaje);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblExplicacionEncuesta);
            this.Name = "ucDatosMotivo";
            this.Size = new System.Drawing.Size(646, 286);
            this.Load += new System.EventHandler(this.ucDatosMotivo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMotivoViaje;
        private System.Windows.Forms.ComboBox cmbDistanciaViaje;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblExplicacionEncuesta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskDistancia;
    }
}
