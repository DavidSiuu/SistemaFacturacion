namespace PRACTICA_AEAE_2
{
    partial class FrmLogin
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxLoginPassword = new System.Windows.Forms.TextBox();
            this.labelLoginName = new System.Windows.Forms.Label();
            this.buttonEnterUser = new System.Windows.Forms.Button();
            this.buttonRegistrerUser = new System.Windows.Forms.Button();
            this.labelInicio = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelLoginPassword = new System.Windows.Forms.Label();
            this.btnVerPassword = new System.Windows.Forms.Button();
            this.btnNoVerPassword = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(382, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxLogin.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxLogin.Location = new System.Drawing.Point(325, 160);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(219, 20);
            this.textBoxLogin.TabIndex = 1;
            this.textBoxLogin.TextChanged += new System.EventHandler(this.textBoxLogin_TextChanged);
            // 
            // textBoxLoginPassword
            // 
            this.textBoxLoginPassword.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxLoginPassword.Location = new System.Drawing.Point(325, 213);
            this.textBoxLoginPassword.Name = "textBoxLoginPassword";
            this.textBoxLoginPassword.PasswordChar = '*';
            this.textBoxLoginPassword.Size = new System.Drawing.Size(219, 20);
            this.textBoxLoginPassword.TabIndex = 2;
            this.textBoxLoginPassword.TextChanged += new System.EventHandler(this.textBoxLoginPassword_TextChanged);
            // 
            // labelLoginName
            // 
            this.labelLoginName.AutoSize = true;
            this.labelLoginName.BackColor = System.Drawing.Color.Black;
            this.labelLoginName.Font = new System.Drawing.Font("Rockwell", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginName.ForeColor = System.Drawing.Color.GhostWhite;
            this.labelLoginName.Location = new System.Drawing.Point(227, 160);
            this.labelLoginName.Name = "labelLoginName";
            this.labelLoginName.Size = new System.Drawing.Size(79, 20);
            this.labelLoginName.TabIndex = 3;
            this.labelLoginName.Text = "USUARIO";
            // 
            // buttonEnterUser
            // 
            this.buttonEnterUser.BackColor = System.Drawing.Color.Green;
            this.buttonEnterUser.ForeColor = System.Drawing.Color.GhostWhite;
            this.buttonEnterUser.Location = new System.Drawing.Point(325, 253);
            this.buttonEnterUser.Name = "buttonEnterUser";
            this.buttonEnterUser.Size = new System.Drawing.Size(219, 47);
            this.buttonEnterUser.TabIndex = 5;
            this.buttonEnterUser.Text = "INGRESAR";
            this.buttonEnterUser.UseVisualStyleBackColor = false;
            this.buttonEnterUser.Click += new System.EventHandler(this.buttonEnterUser_Click);
            // 
            // buttonRegistrerUser
            // 
            this.buttonRegistrerUser.BackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonRegistrerUser.ForeColor = System.Drawing.Color.GhostWhite;
            this.buttonRegistrerUser.Location = new System.Drawing.Point(325, 306);
            this.buttonRegistrerUser.Name = "buttonRegistrerUser";
            this.buttonRegistrerUser.Size = new System.Drawing.Size(219, 47);
            this.buttonRegistrerUser.TabIndex = 6;
            this.buttonRegistrerUser.Text = "REGISTRARSE";
            this.buttonRegistrerUser.UseVisualStyleBackColor = false;
            this.buttonRegistrerUser.Click += new System.EventHandler(this.buttonRegistrerUser_Click);
            // 
            // labelInicio
            // 
            this.labelInicio.AutoSize = true;
            this.labelInicio.BackColor = System.Drawing.Color.Azure;
            this.labelInicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelInicio.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInicio.Location = new System.Drawing.Point(301, 100);
            this.labelInicio.Name = "labelInicio";
            this.labelInicio.Size = new System.Drawing.Size(265, 28);
            this.labelInicio.TabIndex = 7;
            this.labelInicio.Text = "VALIDACIÓN DE USUARIO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PRACTICA_AEAE_2.Properties.Resources.pexels_lukas_hartmann_304281_1055613;
            this.pictureBox1.Location = new System.Drawing.Point(-13, -31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(801, 480);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelLoginPassword
            // 
            this.labelLoginPassword.AutoSize = true;
            this.labelLoginPassword.BackColor = System.Drawing.Color.Black;
            this.labelLoginPassword.Font = new System.Drawing.Font("Rockwell", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginPassword.ForeColor = System.Drawing.Color.GhostWhite;
            this.labelLoginPassword.Location = new System.Drawing.Point(186, 213);
            this.labelLoginPassword.Name = "labelLoginPassword";
            this.labelLoginPassword.Size = new System.Drawing.Size(120, 20);
            this.labelLoginPassword.TabIndex = 9;
            this.labelLoginPassword.Text = "CONTRASEÑA";
            // 
            // btnVerPassword
            // 
            this.btnVerPassword.BackColor = System.Drawing.Color.White;
            this.btnVerPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerPassword.Image = ((System.Drawing.Image)(resources.GetObject("btnVerPassword.Image")));
            this.btnVerPassword.Location = new System.Drawing.Point(585, 211);
            this.btnVerPassword.Name = "btnVerPassword";
            this.btnVerPassword.Size = new System.Drawing.Size(29, 23);
            this.btnVerPassword.TabIndex = 10;
            this.btnVerPassword.UseVisualStyleBackColor = false;
            this.btnVerPassword.Click += new System.EventHandler(this.btnVerPassword_Click);
            // 
            // btnNoVerPassword
            // 
            this.btnNoVerPassword.BackColor = System.Drawing.Color.White;
            this.btnNoVerPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoVerPassword.Image = ((System.Drawing.Image)(resources.GetObject("btnNoVerPassword.Image")));
            this.btnNoVerPassword.Location = new System.Drawing.Point(550, 211);
            this.btnNoVerPassword.Name = "btnNoVerPassword";
            this.btnNoVerPassword.Size = new System.Drawing.Size(29, 23);
            this.btnNoVerPassword.TabIndex = 11;
            this.btnNoVerPassword.UseVisualStyleBackColor = false;
            this.btnNoVerPassword.Click += new System.EventHandler(this.btnNoVerPassword_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNoVerPassword);
            this.Controls.Add(this.btnVerPassword);
            this.Controls.Add(this.labelLoginPassword);
            this.Controls.Add(this.labelInicio);
            this.Controls.Add(this.buttonRegistrerUser);
            this.Controls.Add(this.buttonEnterUser);
            this.Controls.Add(this.labelLoginName);
            this.Controls.Add(this.textBoxLoginPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmLogin";
            this.Text = "Formulario de Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxLoginPassword;
        private System.Windows.Forms.Label labelLoginName;
        private System.Windows.Forms.Button buttonEnterUser;
        private System.Windows.Forms.Button buttonRegistrerUser;
        private System.Windows.Forms.Label labelInicio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelLoginPassword;
        private System.Windows.Forms.Button btnVerPassword;
        private System.Windows.Forms.Button btnNoVerPassword;
    }
}

