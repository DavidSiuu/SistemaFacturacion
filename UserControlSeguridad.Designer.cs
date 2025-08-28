namespace PRACTICA_AEAE_2
{
    partial class UserControlSeguridad
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
            this.labelSeguridad = new System.Windows.Forms.Label();
            this.comboBoxUsuarios = new System.Windows.Forms.ComboBox();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.labelLoginName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.allUsers = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSeguridad
            // 
            this.labelSeguridad.AutoSize = true;
            this.labelSeguridad.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelSeguridad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSeguridad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeguridad.ForeColor = System.Drawing.Color.Coral;
            this.labelSeguridad.Location = new System.Drawing.Point(305, 0);
            this.labelSeguridad.Name = "labelSeguridad";
            this.labelSeguridad.Size = new System.Drawing.Size(155, 28);
            this.labelSeguridad.TabIndex = 2;
            this.labelSeguridad.Text = "SEGURIDAD";
            // 
            // comboBoxUsuarios
            // 
            this.comboBoxUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUsuarios.FormattingEnabled = true;
            this.comboBoxUsuarios.Location = new System.Drawing.Point(245, 85);
            this.comboBoxUsuarios.Name = "comboBoxUsuarios";
            this.comboBoxUsuarios.Size = new System.Drawing.Size(274, 28);
            this.comboBoxUsuarios.TabIndex = 3;
            this.comboBoxUsuarios.SelectedIndexChanged += new System.EventHandler(this.comboBoxUsuarios_SelectedIndexChanged);
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(245, 152);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(274, 20);
            this.textBoxUsuario.TabIndex = 4;
            this.textBoxUsuario.TextChanged += new System.EventHandler(this.textBoxUsuario_TextChanged);
            // 
            // labelLoginName
            // 
            this.labelLoginName.AutoSize = true;
            this.labelLoginName.BackColor = System.Drawing.Color.Black;
            this.labelLoginName.Font = new System.Drawing.Font("Rockwell", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginName.ForeColor = System.Drawing.Color.GhostWhite;
            this.labelLoginName.Location = new System.Drawing.Point(144, 152);
            this.labelLoginName.Name = "labelLoginName";
            this.labelLoginName.Size = new System.Drawing.Size(79, 20);
            this.labelLoginName.TabIndex = 6;
            this.labelLoginName.Text = "USUARIO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Rockwell", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(103, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "CONTRASEÑA";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(245, 208);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(274, 20);
            this.textBoxPassword.TabIndex = 8;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // allUsers
            // 
            this.allUsers.AutoSize = true;
            this.allUsers.BackColor = System.Drawing.Color.Blue;
            this.allUsers.Font = new System.Drawing.Font("Rockwell", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allUsers.ForeColor = System.Drawing.Color.GhostWhite;
            this.allUsers.Location = new System.Drawing.Point(290, 53);
            this.allUsers.Name = "allUsers";
            this.allUsers.Size = new System.Drawing.Size(183, 20);
            this.allUsers.TabIndex = 9;
            this.allUsers.Text = "TODOS LOS USUARIOS";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.Color.GhostWhite;
            this.buttonUpdate.Location = new System.Drawing.Point(305, 245);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(146, 29);
            this.buttonUpdate.TabIndex = 10;
            this.buttonUpdate.Text = "ACTUALIZAR";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // UserControlSeguridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.allUsers);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelLoginName);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.comboBoxUsuarios);
            this.Controls.Add(this.labelSeguridad);
            this.Name = "UserControlSeguridad";
            this.Size = new System.Drawing.Size(776, 359);
            this.Load += new System.EventHandler(this.UserControlSeguridad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSeguridad;
        private System.Windows.Forms.ComboBox comboBoxUsuarios;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Label labelLoginName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label allUsers;
        private System.Windows.Forms.Button buttonUpdate;
    }
}
