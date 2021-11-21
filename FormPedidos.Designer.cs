
namespace Presentacion.Forms
{
    partial class FormPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPedidos));
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.btnCerrarPedidos = new System.Windows.Forms.Button();
            this.btnCargarPedidos = new System.Windows.Forms.Button();
            this.gbBuscarPedidos = new System.Windows.Forms.GroupBox();
            this.btnAddPedido = new System.Windows.Forms.Button();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnVenderPedidos = new System.Windows.Forms.Button();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvProductosPedidos = new System.Windows.Forms.DataGridView();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MONTOTOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCalcularTotalPago = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.gbBuscarPedidos.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(92, 48);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(217, 20);
            this.txtprecio.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(15, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "precio";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(92, 74);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(217, 20);
            this.txtcantidad.TabIndex = 16;
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblcantidad.Location = new System.Drawing.Point(15, 74);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(48, 13);
            this.lblcantidad.TabIndex = 15;
            this.lblcantidad.Text = "cantidad";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(92, 22);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(217, 20);
            this.txtnombre.TabIndex = 14;
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblnombre.Location = new System.Drawing.Point(15, 25);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(42, 13);
            this.lblnombre.TabIndex = 13;
            this.lblnombre.Text = "nombre";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(466, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "Ventas del dia";
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AllowUserToAddRows = false;
            this.dgvPedidos.AllowUserToDeleteRows = false;
            this.dgvPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPedidos.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NOMBRE,
            this.PRECIO,
            this.CANTIDAD,
            this.MONTOTOTAL});
            this.dgvPedidos.Location = new System.Drawing.Point(470, 58);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.ReadOnly = true;
            this.dgvPedidos.RowHeadersVisible = false;
            this.dgvPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidos.Size = new System.Drawing.Size(413, 412);
            this.dgvPedidos.TabIndex = 20;
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMessage.ForeColor = System.Drawing.Color.DarkGray;
            this.lblErrorMessage.Image = ((System.Drawing.Image)(resources.GetObject("lblErrorMessage.Image")));
            this.lblErrorMessage.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblErrorMessage.Location = new System.Drawing.Point(32, 490);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(109, 18);
            this.lblErrorMessage.TabIndex = 34;
            this.lblErrorMessage.Text = "Error Message";
            this.lblErrorMessage.Visible = false;
            // 
            // btnCerrarPedidos
            // 
            this.btnCerrarPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarPedidos.Location = new System.Drawing.Point(766, 490);
            this.btnCerrarPedidos.Name = "btnCerrarPedidos";
            this.btnCerrarPedidos.Size = new System.Drawing.Size(111, 37);
            this.btnCerrarPedidos.TabIndex = 35;
            this.btnCerrarPedidos.Text = "Cerrar";
            this.btnCerrarPedidos.UseVisualStyleBackColor = true;
            this.btnCerrarPedidos.Click += new System.EventHandler(this.btnCerrarPedidos_Click);
            // 
            // btnCargarPedidos
            // 
            this.btnCargarPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCargarPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarPedidos.Location = new System.Drawing.Point(649, 490);
            this.btnCargarPedidos.Name = "btnCargarPedidos";
            this.btnCargarPedidos.Size = new System.Drawing.Size(111, 37);
            this.btnCargarPedidos.TabIndex = 35;
            this.btnCargarPedidos.Text = "Cargar";
            this.btnCargarPedidos.UseVisualStyleBackColor = true;
            this.btnCargarPedidos.Click += new System.EventHandler(this.btnCargarPedidos_Click);
            // 
            // gbBuscarPedidos
            // 
            this.gbBuscarPedidos.Controls.Add(this.btnAddPedido);
            this.gbBuscarPedidos.Controls.Add(this.btnBuscarProducto);
            this.gbBuscarPedidos.Controls.Add(this.lblnombre);
            this.gbBuscarPedidos.Controls.Add(this.txtnombre);
            this.gbBuscarPedidos.Controls.Add(this.lblcantidad);
            this.gbBuscarPedidos.Controls.Add(this.txtcantidad);
            this.gbBuscarPedidos.Controls.Add(this.label2);
            this.gbBuscarPedidos.Controls.Add(this.txtprecio);
            this.gbBuscarPedidos.Location = new System.Drawing.Point(35, 58);
            this.gbBuscarPedidos.Name = "gbBuscarPedidos";
            this.gbBuscarPedidos.Size = new System.Drawing.Size(404, 115);
            this.gbBuscarPedidos.TabIndex = 36;
            this.gbBuscarPedidos.TabStop = false;
            // 
            // btnAddPedido
            // 
            this.btnAddPedido.Location = new System.Drawing.Point(315, 60);
            this.btnAddPedido.Name = "btnAddPedido";
            this.btnAddPedido.Size = new System.Drawing.Size(75, 23);
            this.btnAddPedido.TabIndex = 19;
            this.btnAddPedido.Text = "Add";
            this.btnAddPedido.UseVisualStyleBackColor = true;
            this.btnAddPedido.Click += new System.EventHandler(this.btnAddPedido_Click);
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Location = new System.Drawing.Point(315, 34);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarProducto.TabIndex = 19;
            this.btnBuscarProducto.Text = "Buscar";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(31, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registrar Pedidos";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(31, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 24);
            this.label4.TabIndex = 37;
            this.label4.Text = "Productos";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.dgvProductosPedidos);
            this.groupBox2.Controls.Add(this.btnVenderPedidos);
            this.groupBox2.Controls.Add(this.lblTotalPagar);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnCalcularTotalPago);
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Location = new System.Drawing.Point(35, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(404, 258);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            // 
            // btnVenderPedidos
            // 
            this.btnVenderPedidos.Location = new System.Drawing.Point(315, 99);
            this.btnVenderPedidos.Name = "btnVenderPedidos";
            this.btnVenderPedidos.Size = new System.Drawing.Size(75, 23);
            this.btnVenderPedidos.TabIndex = 41;
            this.btnVenderPedidos.Text = "vender";
            this.btnVenderPedidos.UseVisualStyleBackColor = true;
            this.btnVenderPedidos.Click += new System.EventHandler(this.btnVenderPedidos_Click);
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalPagar.AutoSize = true;
            this.lblTotalPagar.ForeColor = System.Drawing.Color.LightGray;
            this.lblTotalPagar.Location = new System.Drawing.Point(266, 228);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(43, 13);
            this.lblTotalPagar.TabIndex = 40;
            this.lblTotalPagar.Text = "S/ 0.00";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LightGray;
            this.label7.Location = new System.Drawing.Point(140, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 24);
            this.label7.TabIndex = 39;
            this.label7.Text = "Total a Pagar";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(315, 41);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 21;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvProductosPedidos
            // 
            this.dgvProductosPedidos.AllowUserToAddRows = false;
            this.dgvProductosPedidos.AllowUserToDeleteRows = false;
            this.dgvProductosPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductosPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductosPedidos.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvProductosPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn2,
            this.TOTAL});
            this.dgvProductosPedidos.Location = new System.Drawing.Point(18, 21);
            this.dgvProductosPedidos.Name = "dgvProductosPedidos";
            this.dgvProductosPedidos.ReadOnly = true;
            this.dgvProductosPedidos.RowHeadersVisible = false;
            this.dgvProductosPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductosPedidos.Size = new System.Drawing.Size(291, 196);
            this.dgvProductosPedidos.TabIndex = 42;
            this.dgvProductosPedidos.SelectionChanged += new System.EventHandler(this.dgvProductosPedidos_SelectionChanged);
            // 
            // NOMBRE
            // 
            this.NOMBRE.HeaderText = "NOMBRE";
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.ReadOnly = true;
            // 
            // PRECIO
            // 
            this.PRECIO.HeaderText = "PRECIO";
            this.PRECIO.Name = "PRECIO";
            this.PRECIO.ReadOnly = true;
            // 
            // CANTIDAD
            // 
            this.CANTIDAD.HeaderText = "CANTIDAD";
            this.CANTIDAD.Name = "CANTIDAD";
            this.CANTIDAD.ReadOnly = true;
            // 
            // MONTOTOTAL
            // 
            this.MONTOTOTAL.HeaderText = "MONTO TOTAL";
            this.MONTOTOTAL.Name = "MONTOTOTAL";
            this.MONTOTOTAL.ReadOnly = true;
            // 
            // btnCalcularTotalPago
            // 
            this.btnCalcularTotalPago.Location = new System.Drawing.Point(315, 70);
            this.btnCalcularTotalPago.Name = "btnCalcularTotalPago";
            this.btnCalcularTotalPago.Size = new System.Drawing.Size(75, 23);
            this.btnCalcularTotalPago.TabIndex = 21;
            this.btnCalcularTotalPago.Text = "Calcular";
            this.btnCalcularTotalPago.UseVisualStyleBackColor = true;
            this.btnCalcularTotalPago.Click += new System.EventHandler(this.btnCalcularTotalPago_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "NOMBRE";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "PRECIO";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "CANTIDAD";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // TOTAL
            // 
            this.TOTAL.HeaderText = "MONTO TOTAL";
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.ReadOnly = true;
            // 
            // FormPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(909, 554);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gbBuscarPedidos);
            this.Controls.Add(this.btnCargarPedidos);
            this.Controls.Add(this.btnCerrarPedidos);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.dgvPedidos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FormPedidos";
            this.Text = "Pedidos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.gbBuscarPedidos.ResumeLayout(false);
            this.gbBuscarPedidos.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.Button btnCerrarPedidos;
        private System.Windows.Forms.Button btnCargarPedidos;
        private System.Windows.Forms.GroupBox gbBuscarPedidos;
        private System.Windows.Forms.Button btnAddPedido;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotalPagar;
        private System.Windows.Forms.Button btnVenderPedidos;
        public System.Windows.Forms.TextBox txtprecio;
        public System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.DataGridView dgvProductosPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MONTOTOTAL;
        private System.Windows.Forms.Button btnCalcularTotalPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
    }
}