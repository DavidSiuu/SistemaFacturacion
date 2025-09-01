namespace PRACTICA_AEAE_2
{
    partial class UserControlAcercaDe
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
            this.labelNombrePrograma = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAutores = new System.Windows.Forms.TextBox();
            this.textBoxNombrePrograma = new System.Windows.Forms.TextBox();
            this.labelAcercaDe = new System.Windows.Forms.Label();
            this.textBoxNombreU = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelNombrePrograma
            // 
            this.labelNombrePrograma.AutoSize = true;
            this.labelNombrePrograma.BackColor = System.Drawing.Color.Brown;
            this.labelNombrePrograma.Font = new System.Drawing.Font("Rockwell", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombrePrograma.ForeColor = System.Drawing.Color.GhostWhite;
            this.labelNombrePrograma.Location = new System.Drawing.Point(316, 59);
            this.labelNombrePrograma.Name = "labelNombrePrograma";
            this.labelNombrePrograma.Size = new System.Drawing.Size(154, 20);
            this.labelNombrePrograma.TabIndex = 4;
            this.labelNombrePrograma.Text = "Nombre Programa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Font = new System.Drawing.Font("Rockwell", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(361, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Autores";
            // 
            // textBoxAutores
            // 
            this.textBoxAutores.Font = new System.Drawing.Font("Normal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAutores.Location = new System.Drawing.Point(243, 147);
            this.textBoxAutores.Multiline = true;
            this.textBoxAutores.Name = "textBoxAutores";
            this.textBoxAutores.Size = new System.Drawing.Size(302, 90);
            this.textBoxAutores.TabIndex = 6;
            this.textBoxAutores.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxAutores.TextChanged += new System.EventHandler(this.textBoxAutores_TextChanged);
            // 
            // textBoxNombrePrograma
            // 
            this.textBoxNombrePrograma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombrePrograma.Location = new System.Drawing.Point(243, 82);
            this.textBoxNombrePrograma.Name = "textBoxNombrePrograma";
            this.textBoxNombrePrograma.Size = new System.Drawing.Size(302, 26);
            this.textBoxNombrePrograma.TabIndex = 7;
            this.textBoxNombrePrograma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxNombrePrograma.TextChanged += new System.EventHandler(this.textBoxNombrePrograma_TextChanged);
            // 
            // labelAcercaDe
            // 
            this.labelAcercaDe.AutoSize = true;
            this.labelAcercaDe.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelAcercaDe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAcercaDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAcercaDe.ForeColor = System.Drawing.Color.Coral;
            this.labelAcercaDe.Location = new System.Drawing.Point(309, 0);
            this.labelAcercaDe.Name = "labelAcercaDe";
            this.labelAcercaDe.Size = new System.Drawing.Size(153, 28);
            this.labelAcercaDe.TabIndex = 13;
            this.labelAcercaDe.Text = "ACERCA DE";
            // 
            // textBoxNombreU
            // 
            this.textBoxNombreU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreU.Location = new System.Drawing.Point(208, 265);
            this.textBoxNombreU.Name = "textBoxNombreU";
            this.textBoxNombreU.Size = new System.Drawing.Size(367, 23);
            this.textBoxNombreU.TabIndex = 14;
            this.textBoxNombreU.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxNombreU.TextChanged += new System.EventHandler(this.textBoxNombreU_TextChanged);
            // 
            // UserControlAcercaDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxNombreU);
            this.Controls.Add(this.labelAcercaDe);
            this.Controls.Add(this.textBoxNombrePrograma);
            this.Controls.Add(this.textBoxAutores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNombrePrograma);
            this.Name = "UserControlAcercaDe";
            this.Size = new System.Drawing.Size(776, 359);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombrePrograma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAutores;
        private System.Windows.Forms.TextBox textBoxNombrePrograma;
        private System.Windows.Forms.Label labelAcercaDe;
        private System.Windows.Forms.TextBox textBoxNombreU;
    }
}
