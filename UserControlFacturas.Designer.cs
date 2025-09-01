namespace PRACTICA_AEAE_2
{
    partial class UserControlFacturas
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
            this.dataGridViewFactura = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtTotalFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTotalIva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEstadoFactura = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.txtFechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEmpleado = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.txtCliente = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.txtNumeroFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelFacturas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFactura
            // 
            this.dataGridViewFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtNumeroFactura,
            this.txtCliente,
            this.txtEmpleado,
            this.txtDescuento,
            this.txtFechaRegistro,
            this.txtEstadoFactura,
            this.txtTotalIva,
            this.txtTotalFactura});
            this.dataGridViewFactura.Location = new System.Drawing.Point(0, 45);
            this.dataGridViewFactura.Name = "dataGridViewFactura";
            this.dataGridViewFactura.Size = new System.Drawing.Size(776, 251);
            this.dataGridViewFactura.TabIndex = 0;
            this.dataGridViewFactura.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFactura_CellContentClick);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnEditar.Location = new System.Drawing.Point(275, 304);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(221, 23);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.OrangeRed;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnEliminar.Location = new System.Drawing.Point(15, 304);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(221, 23);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Green;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnAgregar.Location = new System.Drawing.Point(532, 304);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(221, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtTotalFactura
            // 
            this.txtTotalFactura.HeaderText = "Total Factura";
            this.txtTotalFactura.Name = "txtTotalFactura";
            // 
            // txtTotalIva
            // 
            this.txtTotalIva.HeaderText = "Total Iva";
            this.txtTotalIva.Name = "txtTotalIva";
            this.txtTotalIva.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.txtTotalIva.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // txtEstadoFactura
            // 
            this.txtEstadoFactura.HeaderText = "Estado Factura";
            this.txtEstadoFactura.Name = "txtEstadoFactura";
            // 
            // txtFechaRegistro
            // 
            this.txtFechaRegistro.HeaderText = "Fecha Registro";
            this.txtFechaRegistro.Name = "txtFechaRegistro";
            // 
            // txtDescuento
            // 
            this.txtDescuento.HeaderText = "Descuento";
            this.txtDescuento.Name = "txtDescuento";
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.HeaderText = "Empleado";
            this.txtEmpleado.Name = "txtEmpleado";
            // 
            // txtCliente
            // 
            this.txtCliente.HeaderText = "Cliente";
            this.txtCliente.Name = "txtCliente";
            // 
            // txtNumeroFactura
            // 
            this.txtNumeroFactura.HeaderText = "NumFactura";
            this.txtNumeroFactura.Name = "txtNumeroFactura";
            // 
            // labelFacturas
            // 
            this.labelFacturas.AutoSize = true;
            this.labelFacturas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelFacturas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelFacturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFacturas.ForeColor = System.Drawing.Color.Coral;
            this.labelFacturas.Location = new System.Drawing.Point(310, 0);
            this.labelFacturas.Name = "labelFacturas";
            this.labelFacturas.Size = new System.Drawing.Size(140, 28);
            this.labelFacturas.TabIndex = 9;
            this.labelFacturas.Text = "FACTURAS";
            // 
            // UserControlFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelFacturas);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dataGridViewFactura);
            this.Name = "UserControlFacturas";
            this.Size = new System.Drawing.Size(776, 359);
            this.Load += new System.EventHandler(this.UserControlFacturas_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFactura;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNumeroFactura;
        private System.Windows.Forms.DataGridViewComboBoxColumn txtCliente;
        private System.Windows.Forms.DataGridViewComboBoxColumn txtEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtFechaRegistro;
        private System.Windows.Forms.DataGridViewComboBoxColumn txtEstadoFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTotalIva;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTotalFactura;
        private System.Windows.Forms.Label labelFacturas;
    }
}
