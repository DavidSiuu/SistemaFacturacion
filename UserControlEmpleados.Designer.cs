namespace PRACTICA_AEAE_2
{
    partial class UserControlEmpleados
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
            this.dataGridViewEmpleados = new System.Windows.Forms.DataGridView();
            this.txtNombreEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtRolEmpleado = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.txtFechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFechaRetiro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.labelEmpleados = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEmpleados
            // 
            this.dataGridViewEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtNombreEmpleado,
            this.txtDocumento,
            this.txtDireccion,
            this.txtTelefono,
            this.txtEmail,
            this.txtRolEmpleado,
            this.txtFechaIngreso,
            this.txtFechaRetiro});
            this.dataGridViewEmpleados.Location = new System.Drawing.Point(-3, 49);
            this.dataGridViewEmpleados.Name = "dataGridViewEmpleados";
            this.dataGridViewEmpleados.Size = new System.Drawing.Size(776, 251);
            this.dataGridViewEmpleados.TabIndex = 1;
            this.dataGridViewEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmpleados_CellContentClick);
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.HeaderText = "Nombre Empleado";
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            // 
            // txtDocumento
            // 
            this.txtDocumento.HeaderText = "Documento";
            this.txtDocumento.Name = "txtDocumento";
            // 
            // txtDireccion
            // 
            this.txtDireccion.HeaderText = "Dirección";
            this.txtDireccion.Name = "txtDireccion";
            // 
            // txtTelefono
            // 
            this.txtTelefono.HeaderText = "Teléfono";
            this.txtTelefono.Name = "txtTelefono";
            // 
            // txtEmail
            // 
            this.txtEmail.HeaderText = "Email";
            this.txtEmail.Name = "txtEmail";
            // 
            // txtRolEmpleado
            // 
            this.txtRolEmpleado.HeaderText = "Rol";
            this.txtRolEmpleado.Name = "txtRolEmpleado";
            // 
            // txtFechaIngreso
            // 
            this.txtFechaIngreso.HeaderText = "Ingreso";
            this.txtFechaIngreso.Name = "txtFechaIngreso";
            // 
            // txtFechaRetiro
            // 
            this.txtFechaRetiro.HeaderText = "Retiro";
            this.txtFechaRetiro.Name = "txtFechaRetiro";
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnEditar.Location = new System.Drawing.Point(271, 315);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(221, 23);
            this.btnEditar.TabIndex = 11;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.OrangeRed;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnEliminar.Location = new System.Drawing.Point(11, 315);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(221, 23);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Green;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnAgregar.Location = new System.Drawing.Point(528, 315);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(221, 23);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // labelEmpleados
            // 
            this.labelEmpleados.AutoSize = true;
            this.labelEmpleados.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpleados.ForeColor = System.Drawing.Color.Coral;
            this.labelEmpleados.Location = new System.Drawing.Point(293, 0);
            this.labelEmpleados.Name = "labelEmpleados";
            this.labelEmpleados.Size = new System.Drawing.Size(161, 28);
            this.labelEmpleados.TabIndex = 12;
            this.labelEmpleados.Text = "EMPLEADOS";
            // 
            // UserControlEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelEmpleados);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dataGridViewEmpleados);
            this.Name = "UserControlEmpleados";
            this.Size = new System.Drawing.Size(776, 359);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewEmpleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNombreEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtEmail;
        private System.Windows.Forms.DataGridViewComboBoxColumn txtRolEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtFechaIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtFechaRetiro;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label labelEmpleados;
    }
}
