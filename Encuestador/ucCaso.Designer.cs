namespace Encuestador
{
    partial class ucCaso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucCaso));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbRuta1 = new System.Windows.Forms.RadioButton();
            this.rbRuta2 = new System.Windows.Forms.RadioButton();
            this.rbRuta3 = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblRuta2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblRuta3 = new System.Windows.Forms.Label();
            this.lblTiempo1 = new System.Windows.Forms.Label();
            this.lblTiempo2 = new System.Windows.Forms.Label();
            this.lblTiempo3 = new System.Windows.Forms.Label();
            this.lblCosto1 = new System.Windows.Forms.Label();
            this.lblCosto2 = new System.Windows.Forms.Label();
            this.lblCosto3 = new System.Windows.Forms.Label();
            this.lblRuta1 = new System.Windows.Forms.Label();
            this.rbRuta4 = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(459, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Elección de Ruta:";
            // 
            // rbRuta1
            // 
            this.rbRuta1.AutoSize = true;
            this.rbRuta1.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rbRuta1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRuta1.Location = new System.Drawing.Point(134, 168);
            this.rbRuta1.Name = "rbRuta1";
            this.rbRuta1.Size = new System.Drawing.Size(54, 34);
            this.rbRuta1.TabIndex = 3;
            this.rbRuta1.TabStop = true;
            this.rbRuta1.Text = "Ruta 1";
            this.rbRuta1.UseVisualStyleBackColor = true;
            this.rbRuta1.CheckedChanged += new System.EventHandler(this.rbRuta1_CheckedChanged);
            // 
            // rbRuta2
            // 
            this.rbRuta2.AutoSize = true;
            this.rbRuta2.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rbRuta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRuta2.Location = new System.Drawing.Point(194, 168);
            this.rbRuta2.Name = "rbRuta2";
            this.rbRuta2.Size = new System.Drawing.Size(54, 34);
            this.rbRuta2.TabIndex = 4;
            this.rbRuta2.TabStop = true;
            this.rbRuta2.Text = "Ruta 2";
            this.rbRuta2.UseVisualStyleBackColor = true;
            this.rbRuta2.CheckedChanged += new System.EventHandler(this.rbRuta2_CheckedChanged);
            // 
            // rbRuta3
            // 
            this.rbRuta3.AutoSize = true;
            this.rbRuta3.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rbRuta3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRuta3.Location = new System.Drawing.Point(254, 168);
            this.rbRuta3.Name = "rbRuta3";
            this.rbRuta3.Size = new System.Drawing.Size(54, 34);
            this.rbRuta3.TabIndex = 5;
            this.rbRuta3.TabStop = true;
            this.rbRuta3.Text = "Ruta 3";
            this.rbRuta3.UseVisualStyleBackColor = true;
            this.rbRuta3.CheckedChanged += new System.EventHandler(this.rbRuta3_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.lblRuta2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblRuta3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTiempo1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTiempo2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTiempo3, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCosto1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblCosto2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblCosto3, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblRuta1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(25, 78);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(467, 74);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblRuta2
            // 
            this.lblRuta2.AutoSize = true;
            this.lblRuta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuta2.Location = new System.Drawing.Point(274, 2);
            this.lblRuta2.Name = "lblRuta2";
            this.lblRuta2.Padding = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.lblRuta2.Size = new System.Drawing.Size(86, 27);
            this.lblRuta2.TabIndex = 1;
            this.lblRuta2.Text = "Ruta 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tiempo de Viaje";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Costo de Viaje";
            // 
            // lblRuta3
            // 
            this.lblRuta3.AutoSize = true;
            this.lblRuta3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuta3.Location = new System.Drawing.Point(372, 2);
            this.lblRuta3.Name = "lblRuta3";
            this.lblRuta3.Padding = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.lblRuta3.Size = new System.Drawing.Size(86, 27);
            this.lblRuta3.TabIndex = 2;
            this.lblRuta3.Text = "Ruta 3";
            // 
            // lblTiempo1
            // 
            this.lblTiempo1.AutoSize = true;
            this.lblTiempo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo1.Location = new System.Drawing.Point(176, 36);
            this.lblTiempo1.Name = "lblTiempo1";
            this.lblTiempo1.Size = new System.Drawing.Size(87, 17);
            this.lblTiempo1.TabIndex = 4;
            this.lblTiempo1.Text = "## minutos";
            // 
            // lblTiempo2
            // 
            this.lblTiempo2.AutoSize = true;
            this.lblTiempo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo2.Location = new System.Drawing.Point(274, 36);
            this.lblTiempo2.Name = "lblTiempo2";
            this.lblTiempo2.Size = new System.Drawing.Size(87, 17);
            this.lblTiempo2.TabIndex = 5;
            this.lblTiempo2.Text = "## minutos";
            // 
            // lblTiempo3
            // 
            this.lblTiempo3.AutoSize = true;
            this.lblTiempo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo3.Location = new System.Drawing.Point(372, 36);
            this.lblTiempo3.Name = "lblTiempo3";
            this.lblTiempo3.Size = new System.Drawing.Size(87, 17);
            this.lblTiempo3.TabIndex = 6;
            this.lblTiempo3.Text = "## minutos";
            // 
            // lblCosto1
            // 
            this.lblCosto1.AutoSize = true;
            this.lblCosto1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCosto1.Location = new System.Drawing.Point(176, 55);
            this.lblCosto1.Name = "lblCosto1";
            this.lblCosto1.Padding = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.lblCosto1.Size = new System.Drawing.Size(90, 17);
            this.lblCosto1.TabIndex = 8;
            this.lblCosto1.Text = "$ ##";
            // 
            // lblCosto2
            // 
            this.lblCosto2.AutoSize = true;
            this.lblCosto2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCosto2.Location = new System.Drawing.Point(274, 55);
            this.lblCosto2.Name = "lblCosto2";
            this.lblCosto2.Padding = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.lblCosto2.Size = new System.Drawing.Size(90, 17);
            this.lblCosto2.TabIndex = 9;
            this.lblCosto2.Text = "$ ##";
            // 
            // lblCosto3
            // 
            this.lblCosto3.AutoSize = true;
            this.lblCosto3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCosto3.Location = new System.Drawing.Point(372, 55);
            this.lblCosto3.Name = "lblCosto3";
            this.lblCosto3.Padding = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.lblCosto3.Size = new System.Drawing.Size(90, 17);
            this.lblCosto3.TabIndex = 10;
            this.lblCosto3.Text = "$ ##";
            // 
            // lblRuta1
            // 
            this.lblRuta1.AutoSize = true;
            this.lblRuta1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuta1.Location = new System.Drawing.Point(176, 2);
            this.lblRuta1.Name = "lblRuta1";
            this.lblRuta1.Padding = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.lblRuta1.Size = new System.Drawing.Size(86, 27);
            this.lblRuta1.TabIndex = 0;
            this.lblRuta1.Text = "Ruta 1";
            // 
            // rbRuta4
            // 
            this.rbRuta4.AutoSize = true;
            this.rbRuta4.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rbRuta4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRuta4.Location = new System.Drawing.Point(314, 168);
            this.rbRuta4.Name = "rbRuta4";
            this.rbRuta4.Size = new System.Drawing.Size(168, 34);
            this.rbRuta4.TabIndex = 6;
            this.rbRuta4.TabStop = true;
            this.rbRuta4.Text = "Ninguna de las opciones";
            this.rbRuta4.UseVisualStyleBackColor = true;
            this.rbRuta4.CheckedChanged += new System.EventHandler(this.rbRuta4_CheckedChanged);
            // 
            // ucCaso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rbRuta4);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.rbRuta3);
            this.Controls.Add(this.rbRuta2);
            this.Controls.Add(this.rbRuta1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ucCaso";
            this.Size = new System.Drawing.Size(564, 232);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbRuta1;
        private System.Windows.Forms.RadioButton rbRuta2;
        private System.Windows.Forms.RadioButton rbRuta3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblRuta1;
        private System.Windows.Forms.Label lblRuta2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblRuta3;
        private System.Windows.Forms.Label lblTiempo1;
        private System.Windows.Forms.Label lblTiempo2;
        private System.Windows.Forms.Label lblTiempo3;
        private System.Windows.Forms.Label lblCosto1;
        private System.Windows.Forms.Label lblCosto2;
        private System.Windows.Forms.Label lblCosto3;
        private System.Windows.Forms.RadioButton rbRuta4;
    }
}
