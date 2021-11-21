using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Forms
{
    public partial class FormCompras : Form
    {
        ListaCompras listaComp = new ListaCompras();
        int posicionSeleccionada = -1;

        public FormCompras()
        {
            InitializeComponent();
        }

        private void btnCerrarCompra_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarCompras_Click(object sender, EventArgs e)
        {
            string error = listaComp.guardarEnArchivoCompras();
            if (error != "")
                MessageBox.Show(error);
        }

        private void btnRegistrarCompra_Click(object sender, EventArgs e)
        {
            Compra nuevaCompra = new Compra();
            if ((txtCategoria.Text != "") && (txtDescripcion.Text != "") && (txtMarca.Text != "") && (txtPrecio.Text != "") && (txtUnidades.Text != ""))
            {                
                nuevaCompra.categoria = txtCategoria.Text;
                nuevaCompra.descripcion = txtDescripcion.Text;
                nuevaCompra.marca = txtMarca.Text;
                nuevaCompra.precio = double.Parse(txtPrecio.Text);
                nuevaCompra.unidades = int.Parse(txtUnidades.Text);
                listaComp.agregarCompra(nuevaCompra);
                actualizarGrilla();
                limpiar();
                lblErrorMessage.Visible = false;
            }
            else
            {
                msgError("Ingrese todos los campos correctamente.  \n     Inténtalo de nuevo");
                txtUnidades.Text = "";
                txtCategoria.Focus();
            }
        }
        private void msgError(string msg)
        {
            lblErrorMessage.Text = "     " + msg;
            lblErrorMessage.Visible = true;
        }
        private void actualizarGrilla()
        {
            List<Compra> compras = listaComp.getLista();
            dgvCompras.Rows.Clear();
            foreach (Compra p in compras)
            {
                int indiceNuevaFila = dgvCompras.Rows.Add();
                DataGridViewRow filaNueva = dgvCompras.Rows[indiceNuevaFila];
                filaNueva.Cells[0].Value = p.categoria;
                filaNueva.Cells[1].Value = p.descripcion;
                filaNueva.Cells[2].Value = p.marca;
                filaNueva.Cells[3].Value = p.precio;
                filaNueva.Cells[4].Value = p.unidades;
            }
        }
        private void limpiar()
        {            
            txtCategoria.Text = "";
            txtDescripcion.Text = "";
            txtMarca.Text = "";
            txtPrecio.Text = "";
            txtUnidades.Text = "";
            txtCategoria.Focus();
        }

        private void btnCargarCompras_Click(object sender, EventArgs e)
        {
            string error = listaComp.cargarDesdeArchivoCompras();
            if (error != "")
                MessageBox.Show(error);
            actualizarGrilla();
            lblErrorMessage.Visible = false;
        }

        private void dgvCompras_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvCompras.SelectedRows.Count > 0)
                {
                    DataGridViewRow filaSeleccionada = dgvCompras.SelectedRows[0];
                    posicionSeleccionada = filaSeleccionada.Index;
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnEliminarCompras_Click(object sender, EventArgs e)
        {
            if (posicionSeleccionada > -1)
            {
                listaComp.eliminarCompra(posicionSeleccionada);
                actualizarGrilla();
                limpiar();
                txtCategoria.Focus();
            }
            else
            {
                MessageBox.Show("Seleccione un Producto");
            }
        }

        private void dgvCompras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            posicionSeleccionada = dgvCompras.CurrentRow.Index;
            txtCategoria.Text = dgvCompras[0, posicionSeleccionada].Value.ToString();
            txtDescripcion.Text = dgvCompras[1, posicionSeleccionada].Value.ToString();
            txtMarca.Text = dgvCompras[2, posicionSeleccionada].Value.ToString();
            txtPrecio.Text = dgvCompras[3, posicionSeleccionada].Value.ToString();
            txtUnidades.Text = dgvCompras[4, posicionSeleccionada].Value.ToString();
            txtCategoria.Focus();
        }

        private void btnModificarCompra_Click(object sender, EventArgs e)
        {
            string categoria, descripcion, marca, precio, unidades;
            if (dgvCompras.SelectedRows.Count > 0)
            {
                categoria = txtCategoria.Text;
                descripcion = txtDescripcion.Text;
                marca = txtMarca.Text;
                precio = txtPrecio.Text;
                unidades = txtUnidades.Text;
                dgvCompras[0, posicionSeleccionada].Value = txtCategoria.Text;
                dgvCompras[1, posicionSeleccionada].Value = txtDescripcion.Text;
                dgvCompras[2, posicionSeleccionada].Value = txtMarca.Text;
                dgvCompras[3, posicionSeleccionada].Value = txtPrecio.Text;
                dgvCompras[4, posicionSeleccionada].Value = txtUnidades.Text;
                limpiar();
                txtCategoria.Focus();
            }
            else
                MessageBox.Show("Debe seleccionar fila");
        }
    }
}
