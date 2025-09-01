namespace PRACTICA_AEAE_2
{
    partial class UserControlInforme
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
            this.labelInforme = new System.Windows.Forms.Label();
            this.buttonGenerarInforme = new System.Windows.Forms.Button();
            this.labelInformePdf = new System.Windows.Forms.Label();
            this.comboBoxtTiposInforme = new System.Windows.Forms.ComboBox();
            this.labelSeleccionarInforme = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelInforme
            // 
            this.labelInforme.AutoSize = true;
            this.labelInforme.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelInforme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelInforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInforme.ForeColor = System.Drawing.Color.Coral;
            this.labelInforme.Location = new System.Drawing.Point(313, 0);
            this.labelInforme.Name = "labelInforme";
            this.labelInforme.Size = new System.Drawing.Size(122, 28);
            this.labelInforme.TabIndex = 13;
            this.labelInforme.Text = "INFORME";
            // 
            // buttonGenerarInforme
            // 
            this.buttonGenerarInforme.BackColor = System.Drawing.Color.Blue;
            this.buttonGenerarInforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerarInforme.ForeColor = System.Drawing.Color.GhostWhite;
            this.buttonGenerarInforme.Location = new System.Drawing.Point(292, 155);
            this.buttonGenerarInforme.Name = "buttonGenerarInforme";
            this.buttonGenerarInforme.Size = new System.Drawing.Size(161, 61);
            this.buttonGenerarInforme.TabIndex = 14;
            this.buttonGenerarInforme.Text = "GENERAR INFORME";
            this.buttonGenerarInforme.UseVisualStyleBackColor = false;
            this.buttonGenerarInforme.Click += new System.EventHandler(this.buttonGenerarInforme_Click);
            // 
            // labelInformePdf
            // 
            this.labelInformePdf.AutoSize = true;
            this.labelInformePdf.BackColor = System.Drawing.Color.Brown;
            this.labelInformePdf.Font = new System.Drawing.Font("Rockwell", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInformePdf.ForeColor = System.Drawing.Color.GhostWhite;
            this.labelInformePdf.Location = new System.Drawing.Point(309, 124);
            this.labelInformePdf.Name = "labelInformePdf";
            this.labelInformePdf.Size = new System.Drawing.Size(122, 20);
            this.labelInformePdf.TabIndex = 15;
            this.labelInformePdf.Text = "INFORME PDF";
            // 
            // comboBoxtTiposInforme
            // 
            this.comboBoxtTiposInforme.FormattingEnabled = true;
            this.comboBoxtTiposInforme.Location = new System.Drawing.Point(266, 88);
            this.comboBoxtTiposInforme.Name = "comboBoxtTiposInforme";
            this.comboBoxtTiposInforme.Size = new System.Drawing.Size(208, 21);
            this.comboBoxtTiposInforme.TabIndex = 16;
            this.comboBoxtTiposInforme.SelectedIndexChanged += new System.EventHandler(this.comboBoxtTiposInforme_SelectedIndexChanged);
            // 
            // labelSeleccionarInforme
            // 
            this.labelSeleccionarInforme.AutoSize = true;
            this.labelSeleccionarInforme.BackColor = System.Drawing.Color.Brown;
            this.labelSeleccionarInforme.Font = new System.Drawing.Font("Rockwell", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeleccionarInforme.ForeColor = System.Drawing.Color.GhostWhite;
            this.labelSeleccionarInforme.Location = new System.Drawing.Point(268, 52);
            this.labelSeleccionarInforme.Name = "labelSeleccionarInforme";
            this.labelSeleccionarInforme.Size = new System.Drawing.Size(206, 20);
            this.labelSeleccionarInforme.TabIndex = 17;
            this.labelSeleccionarInforme.Text = "SELECCIONAR INFORME";
            // 
            // UserControlInforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelSeleccionarInforme);
            this.Controls.Add(this.comboBoxtTiposInforme);
            this.Controls.Add(this.labelInformePdf);
            this.Controls.Add(this.buttonGenerarInforme);
            this.Controls.Add(this.labelInforme);
            this.Name = "UserControlInforme";
            this.Size = new System.Drawing.Size(776, 359);
            this.Load += new System.EventHandler(this.UserControlInforme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInforme;
        private System.Windows.Forms.Button buttonGenerarInforme;
        private System.Windows.Forms.Label labelInformePdf;
        private System.Windows.Forms.ComboBox comboBoxtTiposInforme;
        private System.Windows.Forms.Label labelSeleccionarInforme;
    }
}
