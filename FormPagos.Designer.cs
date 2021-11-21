
namespace Presentacion.Forms
{
    partial class FormPagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPagos));
            this.btnCargarPago = new System.Windows.Forms.Button();
            this.btnGuardarPago = new System.Windows.Forms.Button();
            this.btnEliminarPago = new System.Windows.Forms.Button();
            this.btnAgregarPago = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTipoProd = new System.Windows.Forms.TextBox();
            this.dtpFechaPago = new System.Windows.Forms.DateTimePicker();
            this.txtNombreEmpresa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCerrarPago = new System.Windows.Forms.Button();
            this.iconoPagos = new FontAwesome.Sharp.IconPictureBox();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.dgvPagos = new System.Windows.Forms.DataGridView();
            this.NOMBREEMPRESA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPOPRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MONTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHAPAGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconoPagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCargarPago
            // 
            this.btnCargarPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCargarPago.Location = new System.Drawing.Point(470, 140);
            this.btnCargarPago.Name = "btnCargarPago";
            this.btnCargarPago.Size = new System.Drawing.Size(111, 37);
            this.btnCargarPago.TabIndex = 20;
            this.btnCargarPago.Text = "Cargar";
            this.btnCargarPago.UseVisualStyleBackColor = true;
            this.btnCargarPago.Click += new System.EventHandler(this.btnCargarPago_Click);
            // 
            // btnGuardarPago
            // 
            this.btnGuardarPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarPago.Location = new System.Drawing.Point(640, 490);
            this.btnGuardarPago.Name = "btnGuardarPago";
            this.btnGuardarPago.Size = new System.Drawing.Size(111, 37);
            this.btnGuardarPago.TabIndex = 19;
            this.btnGuardarPago.Text = "Guardar";
            this.btnGuardarPago.UseVisualStyleBackColor = true;
            this.btnGuardarPago.Click += new System.EventHandler(this.btnGuardarPago_Click);
            // 
            // btnEliminarPago
            // 
            this.btnEliminarPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarPago.Location = new System.Drawing.Point(470, 201);
            this.btnEliminarPago.Name = "btnEliminarPago";
            this.btnEliminarPago.Size = new System.Drawing.Size(111, 37);
            this.btnEliminarPago.TabIndex = 17;
            this.btnEliminarPago.Text = "Eliminar";
            this.btnEliminarPago.UseVisualStyleBackColor = true;
            this.btnEliminarPago.Click += new System.EventHandler(this.btnEliminarPago_Click);
            // 
            // btnAgregarPago
            // 
            this.btnAgregarPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarPago.Location = new System.Drawing.Point(470, 82);
            this.btnAgregarPago.Name = "btnAgregarPago";
            this.btnAgregarPago.Size = new System.Drawing.Size(111, 37);
            this.btnAgregarPago.TabIndex = 16;
            this.btnAgregarPago.Text = "Agregar";
            this.btnAgregarPago.UseVisualStyleBackColor = true;
            this.btnAgregarPago.Click += new System.EventHandler(this.btnAgregarPago_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtCantidad);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtMonto);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtTipoProd);
            this.groupBox2.Controls.Add(this.dtpFechaPago);
            this.groupBox2.Controls.Add(this.txtNombreEmpresa);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(35, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(388, 173);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pagos";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCantidad.Location = new System.Drawing.Point(131, 78);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(243, 20);
            this.txtCantidad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Cantidad :";
            // 
            // txtMonto
            // 
            this.txtMonto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMonto.Location = new System.Drawing.Point(131, 104);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(243, 20);
            this.txtMonto.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tipo de producto :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Fecha de pago :";
            // 
            // txtTipoProd
            // 
            this.txtTipoProd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTipoProd.Location = new System.Drawing.Point(131, 51);
            this.txtTipoProd.Name = "txtTipoProd";
            this.txtTipoProd.Size = new System.Drawing.Size(243, 20);
            this.txtTipoProd.TabIndex = 2;
            // 
            // dtpFechaPago
            // 
            this.dtpFechaPago.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaPago.Location = new System.Drawing.Point(131, 136);
            this.dtpFechaPago.Name = "dtpFechaPago";
            this.dtpFechaPago.Size = new System.Drawing.Size(243, 20);
            this.dtpFechaPago.TabIndex = 5;
            // 
            // txtNombreEmpresa
            // 
            this.txtNombreEmpresa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreEmpresa.Location = new System.Drawing.Point(131, 24);
            this.txtNombreEmpresa.Name = "txtNombreEmpresa";
            this.txtNombreEmpresa.Size = new System.Drawing.Size(243, 20);
            this.txtNombreEmpresa.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Monto :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre de la empresa :";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(31, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 24);
            this.label5.TabIndex = 21;
            this.label5.Text = "Pagos realizados";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.LightGray;
            this.label8.Location = new System.Drawing.Point(31, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(364, 24);
            this.label8.TabIndex = 22;
            this.label8.Text = "Descripcion de los egresos de la empresa";
            // 
            // btnCerrarPago
            // 
            this.btnCerrarPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarPago.Location = new System.Drawing.Point(766, 490);
            this.btnCerrarPago.Name = "btnCerrarPago";
            this.btnCerrarPago.Size = new System.Drawing.Size(111, 37);
            this.btnCerrarPago.TabIndex = 23;
            this.btnCerrarPago.Text = "Cerrar";
            this.btnCerrarPago.UseVisualStyleBackColor = true;
            this.btnCerrarPago.Click += new System.EventHandler(this.btnCerrarPago_Click);
            // 
            // iconoPagos
            // 
            this.iconoPagos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconoPagos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.iconoPagos.ForeColor = System.Drawing.Color.Gold;
            this.iconoPagos.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckAlt;
            this.iconoPagos.IconColor = System.Drawing.Color.Gold;
            this.iconoPagos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconoPagos.IconSize = 261;
            this.iconoPagos.Location = new System.Drawing.Point(614, 45);
            this.iconoPagos.Name = "iconoPagos";
            this.iconoPagos.Size = new System.Drawing.Size(283, 261);
            this.iconoPagos.TabIndex = 24;
            this.iconoPagos.TabStop = false;
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
            this.lblErrorMessage.TabIndex = 33;
            this.lblErrorMessage.Text = "Error Message";
            this.lblErrorMessage.Visible = false;
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
            this.dgvPagos.Location = new System.Drawing.Point(35, 298);
            this.dgvPagos.Name = "dgvPagos";
            this.dgvPagos.ReadOnly = true;
            this.dgvPagos.RowHeadersVisible = false;
            this.dgvPagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPagos.Size = new System.Drawing.Size(842, 168);
            this.dgvPagos.TabIndex = 34;
            this.dgvPagos.SelectionChanged += new System.EventHandler(this.dgvPagos_SelectionChanged);
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
            // FormPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(909, 554);
            this.Controls.Add(this.dgvPagos);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.btnCerrarPago);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCargarPago);
            this.Controls.Add(this.btnGuardarPago);
            this.Controls.Add(this.btnEliminarPago);
            this.Controls.Add(this.btnAgregarPago);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.iconoPagos);
            this.Name = "FormPagos";
            this.Text = "Pagos";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconoPagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCargarPago;
        private System.Windows.Forms.Button btnGuardarPago;
        private System.Windows.Forms.Button btnEliminarPago;
        private System.Windows.Forms.Button btnAgregarPago;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTipoProd;
        private System.Windows.Forms.DateTimePicker dtpFechaPago;
        private System.Windows.Forms.TextBox txtNombreEmpresa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCerrarPago;
        private FontAwesome.Sharp.IconPictureBox iconoPagos;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.DataGridView dgvPagos;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBREEMPRESA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPOPRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MONTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHAPAGO;
    }
}