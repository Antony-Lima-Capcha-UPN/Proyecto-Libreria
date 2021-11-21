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
    public partial class FormPedidos : Form
    {
        ListaPedidos listaPed = new ListaPedidos();
        int posicionSeleccionada = -1;

        public FormPedidos()
        {
            InitializeComponent();
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            FormProductos frmProd = new FormProductos();
            AddOwnedForm(frmProd);
            frmProd.FormBorderStyle = FormBorderStyle.None;
            frmProd.TopLevel = false;
            frmProd.Dock = DockStyle.Fill;
            this.Controls.Add(frmProd);
            this.Tag = frmProd;
            frmProd.BringToFront();
            frmProd.Show();
        }

        private void btnCerrarPedidos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddPedido_Click(object sender, EventArgs e)
        {
            Pedido nuevoPedido = new Pedido();
            if ((txtnombre.Text != "") && (txtprecio.Text != "") && (txtcantidad.Text != ""))
            {
                
                nuevoPedido.nombre = txtnombre.Text;
                nuevoPedido.precio = double.Parse(txtprecio.Text);
                nuevoPedido.cantidad = int.Parse(txtcantidad.Text);
                nuevoPedido.montoTotal = (double.Parse(txtprecio.Text) * int.Parse(txtcantidad.Text));
                listaPed.agregarPedido(nuevoPedido);
                actualizarGrillaPedidos();
                limpiar();
                lblErrorMessage.Visible = false;
            }
            else
            {
                msgError("Ingrese todos los campos correctamente.  \n     Inténtalo de nuevo");
                txtcantidad.Text = "";
                txtnombre.Focus();
            }
        }
        private void actualizarGrillaPedidos()
        {
            List<Pedido> pedidos = listaPed.getLista();
            dgvProductosPedidos.Rows.Clear();
            foreach (Pedido p in pedidos)
            {
                int indiceNuevaFila = dgvProductosPedidos.Rows.Add();
                DataGridViewRow filaNueva = dgvProductosPedidos.Rows[indiceNuevaFila];
                filaNueva.Cells[0].Value = p.nombre;
                filaNueva.Cells[1].Value = p.precio;
                filaNueva.Cells[2].Value = p.cantidad;
                filaNueva.Cells[3].Value = p.montoTotal;
            }
        }
        private void limpiar()
        {
            txtnombre.Text = "";
            txtprecio.Text = "";
            txtcantidad.Text = "";
            txtnombre.Focus();
        }
        private void msgError(string msg)
        {
            lblErrorMessage.Text = "     " + msg;
            lblErrorMessage.Visible = true;
        }

        private void btnCalcularTotalPago_Click(object sender, EventArgs e)
        {
            double totalPago = 0;
            foreach (DataGridViewRow row in dgvProductosPedidos.Rows)
            {
                totalPago += Convert.ToDouble(row.Cells["TOTAL"].Value);
            }
            lblTotalPagar.Text ="S/ "+ Convert.ToString(totalPago);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (posicionSeleccionada > -1)
            {
                listaPed.eliminarPedido(posicionSeleccionada);
                actualizarGrillaPedidos();
                limpiar();
                txtnombre.Focus();
            }
            else
            {
                MessageBox.Show("Seleccione un Producto");
            }
        }

        private void dgvProductosPedidos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvProductosPedidos.SelectedRows.Count > 0)
                {
                    DataGridViewRow filaSeleccionada = dgvProductosPedidos.SelectedRows[0];
                    posicionSeleccionada = filaSeleccionada.Index;
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnVenderPedidos_Click(object sender, EventArgs e)
        {
            string error = listaPed.guardarEnArchivoPedidos();
            if (error != "")
                MessageBox.Show(error);
        }

        private void btnCargarPedidos_Click(object sender, EventArgs e)
        {
            string error = listaPed.cargarDesdeArchivoPedidos();
            if (error != "")
                MessageBox.Show(error);
            actualizarGrillaPedidosVentasDia();
            lblErrorMessage.Visible = false;
        }
        private void actualizarGrillaPedidosVentasDia()
        {
            List<Pedido> pedidos = listaPed.getLista();
            dgvPedidos.Rows.Clear();
            foreach (Pedido p in pedidos)
            {
                int indiceNuevaFila = dgvPedidos.Rows.Add();
                DataGridViewRow filaNueva = dgvPedidos.Rows[indiceNuevaFila];
                filaNueva.Cells[0].Value = p.nombre;
                filaNueva.Cells[1].Value = p.precio;
                filaNueva.Cells[2].Value = p.cantidad;
                filaNueva.Cells[3].Value = p.montoTotal;
            }
        }
    }
}
