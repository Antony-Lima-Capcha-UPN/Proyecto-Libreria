
namespace Presentacion.Forms
{
    partial class FormCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCompras));
            this.btnCargarCompras = new System.Windows.Forms.Button();
            this.btnGuardarCompras = new System.Windows.Forms.Button();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUnidades = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.dgvCompras = new System.Windows.Forms.DataGridView();
            this.btnCerrarCompra = new System.Windows.Forms.Button();
            this.btnEliminarCompras = new System.Windows.Forms.Button();
            this.btnModificarCompra = new System.Windows.Forms.Button();
            this.btnRegistrarCompra = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CATEGORIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MARCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UNIDADES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCargarCompras
            // 
            this.btnCargarCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarCompras.Location = new System.Drawing.Point(75, 302);
            this.btnCargarCompras.Name = "btnCargarCompras";
            this.btnCargarCompras.Size = new System.Drawing.Size(111, 37);
            this.btnCargarCompras.TabIndex = 59;
            this.btnCargarCompras.Text = "Cargar";
            this.btnCargarCompras.UseVisualStyleBackColor = true;
            this.btnCargarCompras.Click += new System.EventHandler(this.btnCargarCompras_Click);
            // 
            // btnGuardarCompras
            // 
            this.btnGuardarCompras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCompras.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGuardarCompras.Location = new System.Drawing.Point(649, 490);
            this.btnGuardarCompras.Name = "btnGuardarCompras";
            this.btnGuardarCompras.Size = new System.Drawing.Size(111, 37);
            this.btnGuardarCompras.TabIndex = 58;
            this.btnGuardarCompras.Text = "Guardar";
            this.btnGuardarCompras.UseVisualStyleBackColor = true;
            this.btnGuardarCompras.Click += new System.EventHandler(this.btnGuardarCompras_Click);
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMessage.ForeColor = System.Drawing.Color.DarkGray;
            this.lblErrorMessage.Image = ((System.Drawing.Image)(resources.GetObject("lblErrorMessage.Image")));
            this.lblErrorMessage.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblErrorMessage.Location = new System.Drawing.Point(32, 433);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(109, 18);
            this.lblErrorMessage.TabIndex = 57;
            this.lblErrorMessage.Text = "Error Message";
            this.lblErrorMessage.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.LightGray;
            this.label7.Location = new System.Drawing.Point(32, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "UNIDADES:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(32, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "PRECIO:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.LightGray;
            this.label6.Location = new System.Drawing.Point(32, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "MARCA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(32, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "DESCRIPCION:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(32, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "CATEGORIA:";
            // 
            // txtUnidades
            // 
            this.txtUnidades.Location = new System.Drawing.Point(158, 170);
            this.txtUnidades.Name = "txtUnidades";
            this.txtUnidades.Size = new System.Drawing.Size(201, 20);
            this.txtUnidades.TabIndex = 42;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(158, 118);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(201, 20);
            this.txtMarca.TabIndex = 39;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(158, 144);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(201, 20);
            this.txtPrecio.TabIndex = 41;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(158, 92);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(201, 20);
            this.txtDescripcion.TabIndex = 38;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(158, 66);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(201, 20);
            this.txtCategoria.TabIndex = 37;
            // 
            // dgvCompras
            // 
            this.dgvCompras.AllowUserToAddRows = false;
            this.dgvCompras.AllowUserToDeleteRows = false;
            this.dgvCompras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCompras.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CATEGORIA,
            this.DESCRIPCION,
            this.MARCA,
            this.PRECIO,
            this.UNIDADES});
            this.dgvCompras.Location = new System.Drawing.Point(377, 66);
            this.dgvCompras.Name = "dgvCompras";
            this.dgvCompras.ReadOnly = true;
            this.dgvCompras.RowHeadersVisible = false;
            this.dgvCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompras.Size = new System.Drawing.Size(500, 409);
            this.dgvCompras.TabIndex = 49;
            this.dgvCompras.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompras_CellClick);
            this.dgvCompras.SelectionChanged += new System.EventHandler(this.dgvCompras_SelectionChanged);
            // 
            // btnCerrarCompra
            // 
            this.btnCerrarCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarCompra.Location = new System.Drawing.Point(766, 490);
            this.btnCerrarCompra.Name = "btnCerrarCompra";
            this.btnCerrarCompra.Size = new System.Drawing.Size(111, 37);
            this.btnCerrarCompra.TabIndex = 46;
            this.btnCerrarCompra.Text = "Cerrar";
            this.btnCerrarCompra.UseVisualStyleBackColor = true;
            this.btnCerrarCompra.Click += new System.EventHandler(this.btnCerrarCompra_Click);
            // 
            // btnEliminarCompras
            // 
            this.btnEliminarCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCompras.Location = new System.Drawing.Point(225, 302);
            this.btnEliminarCompras.Name = "btnEliminarCompras";
            this.btnEliminarCompras.Size = new System.Drawing.Size(111, 37);
            this.btnEliminarCompras.TabIndex = 45;
            this.btnEliminarCompras.Text = "Eliminar";
            this.btnEliminarCompras.UseVisualStyleBackColor = true;
            this.btnEliminarCompras.Click += new System.EventHandler(this.btnEliminarCompras_Click);
            // 
            // btnModificarCompra
            // 
            this.btnModificarCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarCompra.Location = new System.Drawing.Point(225, 246);
            this.btnModificarCompra.Name = "btnModificarCompra";
            this.btnModificarCompra.Size = new System.Drawing.Size(111, 37);
            this.btnModificarCompra.TabIndex = 44;
            this.btnModificarCompra.Text = "Modificar";
            this.btnModificarCompra.UseVisualStyleBackColor = true;
            this.btnModificarCompra.Click += new System.EventHandler(this.btnModificarCompra_Click);
            // 
            // btnRegistrarCompra
            // 
            this.btnRegistrarCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarCompra.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRegistrarCompra.Location = new System.Drawing.Point(75, 246);
            this.btnRegistrarCompra.Name = "btnRegistrarCompra";
            this.btnRegistrarCompra.Size = new System.Drawing.Size(111, 37);
            this.btnRegistrarCompra.TabIndex = 43;
            this.btnRegistrarCompra.Text = "Registrar";
            this.btnRegistrarCompra.UseVisualStyleBackColor = true;
            this.btnRegistrarCompra.Click += new System.EventHandler(this.btnRegistrarCompra_Click);
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
            this.label1.TabIndex = 35;
            this.label1.Text = "Lista de Compras";
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
            // FormCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(909, 554);
            this.Controls.Add(this.btnCargarCompras);
            this.Controls.Add(this.btnGuardarCompras);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUnidades);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.dgvCompras);
            this.Controls.Add(this.btnCerrarCompra);
            this.Controls.Add(this.btnEliminarCompras);
            this.Controls.Add(this.btnModificarCompra);
            this.Controls.Add(this.btnRegistrarCompra);
            this.Controls.Add(this.label1);
            this.Name = "FormCompras";
            this.Text = "Compras";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCargarCompras;
        private System.Windows.Forms.Button btnGuardarCompras;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUnidades;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Button btnCerrarCompra;
        private System.Windows.Forms.Button btnEliminarCompras;
        private System.Windows.Forms.Button btnModificarCompra;
        private System.Windows.Forms.Button btnRegistrarCompra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATEGORIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn MARCA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn UNIDADES;
        public System.Windows.Forms.DataGridView dgvCompras;
    }
}