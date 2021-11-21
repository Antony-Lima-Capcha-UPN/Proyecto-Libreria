
namespace Presentacion.Forms
{
    partial class FormReportes
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
            this.label1 = new System.Windows.Forms.Label();
            this.gbPedidos = new System.Windows.Forms.GroupBox();
            this.btnBuscarReportPedidos = new FontAwesome.Sharp.IconButton();
            this.gpCompras = new System.Windows.Forms.GroupBox();
            this.dgvReportCompras = new System.Windows.Forms.DataGridView();
            this.CATEGORIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MARCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UNIDADES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscarReportCompras = new FontAwesome.Sharp.IconButton();
            this.gpPagos = new System.Windows.Forms.GroupBox();
            this.dgvPagos = new System.Windows.Forms.DataGridView();
            this.NOMBREEMPRESA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPOPRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MONTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHAPAGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscarReportPagos = new FontAwesome.Sharp.IconButton();
            this.btnCerrarReportes = new System.Windows.Forms.Button();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MONTOTOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbPedidos.SuspendLayout();
            this.gpCompras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportCompras)).BeginInit();
            this.gpPagos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(155, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de Reportes";
            // 
            // gbPedidos
            // 
            this.gbPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPedidos.Controls.Add(this.dgvPedidos);
            this.gbPedidos.Controls.Add(this.btnBuscarReportPedidos);
            this.gbPedidos.ForeColor = System.Drawing.Color.LightGray;
            this.gbPedidos.Location = new System.Drawing.Point(35, 55);
            this.gbPedidos.Name = "gbPedidos";
            this.gbPedidos.Size = new System.Drawing.Size(841, 154);
            this.gbPedidos.TabIndex = 2;
            this.gbPedidos.TabStop = false;
            this.gbPedidos.Text = "Pedidos";
            // 
            // btnBuscarReportPedidos
            // 
            this.btnBuscarReportPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarReportPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarReportPedidos.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarReportPedidos.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btnBuscarReportPedidos.IconColor = System.Drawing.Color.Black;
            this.btnBuscarReportPedidos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarReportPedidos.IconSize = 80;
            this.btnBuscarReportPedidos.Location = new System.Drawing.Point(723, 19);
            this.btnBuscarReportPedidos.Name = "btnBuscarReportPedidos";
            this.btnBuscarReportPedidos.Size = new System.Drawing.Size(112, 118);
            this.btnBuscarReportPedidos.TabIndex = 1;
            this.btnBuscarReportPedidos.UseVisualStyleBackColor = true;
            this.btnBuscarReportPedidos.Click += new System.EventHandler(this.btnBuscarReportPedidos_Click);
            // 
            // gpCompras
            // 
            this.gpCompras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpCompras.Controls.Add(this.dgvReportCompras);
            this.gpCompras.Controls.Add(this.btnBuscarReportCompras);
            this.gpCompras.ForeColor = System.Drawing.Color.LightGray;
            this.gpCompras.Location = new System.Drawing.Point(35, 213);
            this.gpCompras.Name = "gpCompras";
            this.gpCompras.Size = new System.Drawing.Size(841, 154);
            this.gpCompras.TabIndex = 2;
            this.gpCompras.TabStop = false;
            this.gpCompras.Text = "Compras";
            // 
            // dgvReportCompras
            // 
            this.dgvReportCompras.AllowUserToAddRows = false;
            this.dgvReportCompras.AllowUserToDeleteRows = false;
            this.dgvReportCompras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReportCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReportCompras.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvReportCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CATEGORIA,
            this.DESCRIPCION,
            this.MARCA,
            this.PRECIO,
            this.UNIDADES});
            this.dgvReportCompras.GridColor = System.Drawing.Color.Black;
            this.dgvReportCompras.Location = new System.Drawing.Point(17, 19);
            this.dgvReportCompras.Name = "dgvReportCompras";
            this.dgvReportCompras.ReadOnly = true;
            this.dgvReportCompras.RowHeadersVisible = false;
            this.dgvReportCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReportCompras.Size = new System.Drawing.Size(700, 118);
            this.dgvReportCompras.TabIndex = 50;
            // 
            // CATEGORIA
            // 
            this.CATEGORIA.HeaderText = "CATEGORIA";
            this.CATEGORIA.Name = "CATEGORIA";
            this.CATEGORIA.ReadOnly = true;
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.HeaderText = "DESCRIPCION";
            this.DESCRIPCION.Name = "DESCRIPCION";
            this.DESCRIPCION.ReadOnly = true;
            // 
            // MARCA
            // 
            this.MARCA.HeaderText = "MARCA";
            this.MARCA.Name = "MARCA";
            this.MARCA.ReadOnly = true;
            // 
            // PRECIO
            // 
            this.PRECIO.HeaderText = "PRECIO";
            this.PRECIO.Name = "PRECIO";
            this.PRECIO.ReadOnly = true;
            // 
            // UNIDADES
            // 
            this.UNIDADES.HeaderText = "UNIDADES";
            this.UNIDADES.Name = "UNIDADES";
            this.UNIDADES.ReadOnly = true;
            // 
            // btnBuscarReportCompras
            // 
            this.btnBuscarReportCompras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarReportCompras.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarReportCompras.IconChar = FontAwesome.Sharp.IconChar.Truck;
            this.btnBuscarReportCompras.IconColor = System.Drawing.Color.Black;
            this.btnBuscarReportCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarReportCompras.IconSize = 80;
            this.btnBuscarReportCompras.Location = new System.Drawing.Point(723, 19);
            this.btnBuscarReportCompras.Name = "btnBuscarReportCompras";
            this.btnBuscarReportCompras.Size = new System.Drawing.Size(112, 118);
            this.btnBuscarReportCompras.TabIndex = 1;
            this.btnBuscarReportCompras.UseVisualStyleBackColor = true;
            this.btnBuscarReportCompras.Click += new System.EventHandler(this.btnBuscarReportCompras_Click);
            // 
            // gpPagos
            // 
            this.gpPagos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpPagos.Controls.Add(this.dgvPagos);
            this.gpPagos.Controls.Add(this.btnBuscarReportPagos);
            this.gpPagos.ForeColor = System.Drawing.Color.LightGray;
            this.gpPagos.Location = new System.Drawing.Point(35, 373);
            this.gpPagos.Name = "gpPagos";
            this.gpPagos.Size = new System.Drawing.Size(841, 154);
            this.gpPagos.TabIndex = 2;
            this.gpPagos.TabStop = false;
            this.gpPagos.Text = "Pagos";
            // 
            // dgvPagos
            // 
            this.dgvPagos.AllowUserToAddRows = false;
            this.dgvPagos.AllowUserToDeleteRows = false;
            this.dgvPagos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPagos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPagos.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NOMBREEMPRESA,
            this.TIPOPRODUCTO,
            this.CANTIDAD,
            this.MONTO,
            this.FECHAPAGO});
            this.dgvPagos.Location = new System.Drawing.Point(17, 19);
            this.dgvPagos.Name = "dgvPagos";
            this.dgvPagos.ReadOnly = true;
            this.dgvPagos.RowHeadersVisible = false;
            this.dgvPagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPagos.Size = new System.Drawing.Size(700, 118);
            this.dgvPagos.TabIndex = 35;
            // 
            // NOMBREEMPRESA
            // 
            this.NOMBREEMPRESA.HeaderText = "NOMBRE DE LA EMPRESA";
            this.NOMBREEMPRESA.Name = "NOMBREEMPRESA";
            this.NOMBREEMPRESA.ReadOnly = true;
            // 
            // TIPOPRODUCTO
            // 
            this.TIPOPRODUCTO.HeaderText = "TIPO DE PRODUCTO";
            this.TIPOPRODUCTO.Name = "TIPOPRODUCTO";
            this.TIPOPRODUCTO.ReadOnly = true;
            // 
            // CANTIDAD
            // 
            this.CANTIDAD.HeaderText = "CANTIDAD";
            this.CANTIDAD.Name = "CANTIDAD";
            this.CANTIDAD.ReadOnly = true;
            // 
            // MONTO
            // 
            this.MONTO.HeaderText = "MONTO";
            this.MONTO.Name = "MONTO";
            this.MONTO.ReadOnly = true;
            // 
            // FECHAPAGO
            // 
            this.FECHAPAGO.HeaderText = "FECHA DE PAGO";
            this.FECHAPAGO.Name = "FECHAPAGO";
            this.FECHAPAGO.ReadOnly = true;
            // 
            // btnBuscarReportPagos
            // 
            this.btnBuscarReportPagos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarReportPagos.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarReportPagos.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            this.btnBuscarReportPagos.IconColor = System.Drawing.Color.Black;
            this.btnBuscarReportPagos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarReportPagos.IconSize = 80;
            this.btnBuscarReportPagos.Location = new System.Drawing.Point(723, 19);
            this.btnBuscarReportPagos.Name = "btnBuscarReportPagos";
            this.btnBuscarReportPagos.Size = new System.Drawing.Size(112, 118);
            this.btnBuscarReportPagos.TabIndex = 1;
            this.btnBuscarReportPagos.UseVisualStyleBackColor = true;
            this.btnBuscarReportPagos.Click += new System.EventHandler(this.btnBuscarReportPagos_Click);
            // 
            // btnCerrarReportes
            // 
            this.btnCerrarReportes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarReportes.Location = new System.Drawing.Point(801, 31);
            this.btnCerrarReportes.Name = "btnCerrarReportes";
            this.btnCerrarReportes.Size = new System.Drawing.Size(75, 23);
            this.btnCerrarReportes.TabIndex = 3;
            this.btnCerrarReportes.Text = "Cerrar";
            this.btnCerrarReportes.UseVisualStyleBackColor = true;
            this.btnCerrarReportes.Click += new System.EventHandler(this.btnCerrarReportes_Click);
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
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.MONTOTOTAL});
            this.dgvPedidos.Location = new System.Drawing.Point(17, 19);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.ReadOnly = true;
            this.dgvPedidos.RowHeadersVisible = false;
            this.dgvPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidos.Size = new System.Drawing.Size(700, 118);
            this.dgvPedidos.TabIndex = 21;
            // 
            // NOMBRE
            // 
            this.NOMBRE.HeaderText = "NOMBRE";
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "PRECIO";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "CANTIDAD";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // MONTOTOTAL
            // 
            this.MONTOTOTAL.HeaderText = "MONTO TOTAL";
            this.MONTOTOTAL.Name = "MONTOTOTAL";
            this.MONTOTOTAL.ReadOnly = true;
            // 
            // FormReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(909, 554);
            this.Controls.Add(this.btnCerrarReportes);
            this.Controls.Add(this.gpPagos);
            this.Controls.Add(this.gpCompras);
            this.Controls.Add(this.gbPedidos);
            this.Controls.Add(this.label1);
            this.Name = "FormReportes";
            this.Text = "Reportes";
            this.gbPedidos.ResumeLayout(false);
            this.gpCompras.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportCompras)).EndInit();
            this.gpPagos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbPedidos;
        private FontAwesome.Sharp.IconButton btnBuscarReportPedidos;
        private System.Windows.Forms.GroupBox gpCompras;
        private System.Windows.Forms.GroupBox gpPagos;
        private FontAwesome.Sharp.IconButton btnBuscarReportCompras;
        private FontAwesome.Sharp.IconButton btnBuscarReportPagos;
        public System.Windows.Forms.DataGridView dgvReportCompras;
        private System.Windows.Forms.Button btnCerrarReportes;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATEGORIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn MARCA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn UNIDADES;
        private System.Windows.Forms.DataGridView dgvPagos;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBREEMPRESA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPOPRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MONTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHAPAGO;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MONTOTOTAL;
    }
}