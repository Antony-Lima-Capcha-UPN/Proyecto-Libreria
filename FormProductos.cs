using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Amazon.S3.Model;

namespace Presentacion.Forms
{
    public partial class FormProductos : Form
    {
        ListaProductos lista = new ListaProductos();
        int posicionSeleccionada = -1;
        public FormProductos()
        {
            InitializeComponent();
            actualizarGrilla();
        }

        
        private void FormProductos_Load(object sender, EventArgs e)
        {
            
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Buscar...")
            {
                txtBuscar.Text = "";
                txtBuscar.ForeColor = Color.Black; 
            }
            
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                txtBuscar.Text = "Buscar...";
                txtBuscar.ForeColor = Color.DimGray;
            }
            
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            string id, categoria,descripcion,marca,precioCompra,precioVenta,stock;
            if (dgvProductos.SelectedRows.Count > 0)
            {

                id = txtId.Text;
                categoria = txtCategoria.Text;
                descripcion = txtDescripcion.Text;
                marca = txtMarca.Text;
                precioCompra = txtPrecioCompra.Text;
                precioVenta = txtPrecioVenta.Text;
                stock = txtStock.Text;
                dgvProductos[0, posicionSeleccionada].Value = txtId.Text;
                dgvProductos[1, posicionSeleccionada].Value = txtCategoria.Text;
                dgvProductos[2, posicionSeleccionada].Value = txtDescripcion.Text;
                dgvProductos[3, posicionSeleccionada].Value = txtMarca.Text;
                dgvProductos[4, posicionSeleccionada].Value = txtPrecioCompra.Text;
                dgvProductos[5, posicionSeleccionada].Value = txtPrecioVenta.Text;
                dgvProductos[6, posicionSeleccionada].Value = txtStock.Text;
                limpiar();
                txtId.Focus();
            }
            else
                MessageBox.Show("Debe seleccionar fila");
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Producto nuevoProducto = new Producto();
            if ((txtId.Text != "") && (txtCategoria.Text != "") && (txtDescripcion.Text != "") && (txtMarca.Text != "") && (txtPrecioCompra.Text != "")
                && (txtPrecioVenta.Text != "") && (txtStock.Text != ""))
            {                   
                nuevoProducto.id = int.Parse(txtId.Text);
                nuevoProducto.categoria = txtCategoria.Text;
                nuevoProducto.descripcion = txtDescripcion.Text;
                nuevoProducto.marca = txtMarca.Text;
                nuevoProducto.precioCompra = double.Parse(txtPrecioCompra.Text);
                nuevoProducto.precioVenta = double.Parse(txtPrecioVenta.Text);
                nuevoProducto.stock = int.Parse(txtStock.Text);
                lista.agregarProducto(nuevoProducto);
                actualizarGrilla();
                limpiar();
                lblErrorMessage.Visible = false;
            }
            else
            {
                msgError("Ingrese todos los campos correctamente.  \n     Inténtalo de nuevo");
                txtStock.Text = "";
                txtId.Focus();
            }
        }
        private void msgError(string msg)
        {
            lblErrorMessage.Text = "     " + msg;
            lblErrorMessage.Visible = true;
        }
        private void actualizarGrilla()
        {
            List<Producto> productos = lista.getLista();
            dgvProductos.Rows.Clear();
            foreach (Producto p in productos)
            {
                int indiceNuevaFila = dgvProductos.Rows.Add();
                DataGridViewRow filaNueva = dgvProductos.Rows[indiceNuevaFila];
                filaNueva.Cells[0].Value = p.id;
                filaNueva.Cells[1].Value = p.categoria;
                filaNueva.Cells[2].Value = p.descripcion;
                filaNueva.Cells[3].Value = p.marca;
                filaNueva.Cells[4].Value = p.precioCompra;
                filaNueva.Cells[5].Value = p.precioVenta;
                filaNueva.Cells[6].Value = p.stock;
            }
        }
        private void limpiar()
        {
            txtId.Text = "";
            txtCategoria.Text = "";
            txtDescripcion.Text = "";
            txtMarca.Text = "";
            txtPrecioCompra.Text = "";
            txtPrecioVenta.Text = "";
            txtStock.Text = "";
            txtId.Focus();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void btnGuardarProductos_Click(object sender, EventArgs e)
        {
            string error = lista.guardarEnArchivo();
            if (error != "")
                MessageBox.Show(error);
        }

        private void btnCargarProductos_Click_1(object sender, EventArgs e)
        {
            string error = lista.cargarDesdeArchivo();
            if (error != "")
                MessageBox.Show(error);
            actualizarGrilla();
            lblErrorMessage.Visible = false;
        }        

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (posicionSeleccionada > -1)
            {
                lista.eliminarProducto(posicionSeleccionada);
                actualizarGrilla();
                limpiar();
                txtId.Focus();
            }
            else
            {
                MessageBox.Show("Seleccione un Producto");
            }
        }

        private void dgvProductos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvProductos.SelectedRows.Count > 0)
                {
                    DataGridViewRow filaSeleccionada = dgvProductos.SelectedRows[0];
                    posicionSeleccionada = filaSeleccionada.Index;
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            posicionSeleccionada = dgvProductos.CurrentRow.Index;
            txtId.Text = dgvProductos[0, posicionSeleccionada].Value.ToString();
            txtCategoria.Text = dgvProductos[1, posicionSeleccionada].Value.ToString();
            txtDescripcion.Text = dgvProductos[2, posicionSeleccionada].Value.ToString();
            txtMarca.Text = dgvProductos[3, posicionSeleccionada].Value.ToString();
            txtPrecioCompra.Text = dgvProductos[4, posicionSeleccionada].Value.ToString();
            txtPrecioVenta.Text = dgvProductos[5, posicionSeleccionada].Value.ToString();
            txtStock.Text = dgvProductos[6, posicionSeleccionada].Value.ToString();
            txtId.Focus();
        }

        private void dgvProductos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormPedidos frmPed = Owner as FormPedidos;
            frmPed.txtnombre.Text = dgvProductos.CurrentRow.Cells[2].Value.ToString();
            frmPed.txtprecio.Text = dgvProductos.CurrentRow.Cells[5].Value.ToString();
            this.Close();
        }
    }
}
