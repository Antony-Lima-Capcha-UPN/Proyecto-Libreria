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
    public partial class FormPagos : Form
    {
        ListaEgreso listaPag = new ListaEgreso();
        int posicionSeleccionada = -1;

        public FormPagos()
        {
            InitializeComponent();
        }
        
        private void actualizarGrilla()
        {

            List<PagarProductos> productos = listaPag.getLista();
            dgvPagos.Rows.Clear();
            foreach (PagarProductos p in productos)
            {
                int indiceNuevaFila = dgvPagos.Rows.Add();
                DataGridViewRow filaNueva = dgvPagos.Rows[indiceNuevaFila];
                filaNueva.Cells[0].Value = p.nombreEmpresa;
                filaNueva.Cells[1].Value = p.tipoProducto;
                filaNueva.Cells[2].Value = p.cantidad.ToString();
                filaNueva.Cells[3].Value = p.monto;
                filaNueva.Cells[4].Value = p.FechaPago.ToString();
            }

        }
        private void msgError(string msg)
        {
            lblErrorMessage.Text = "     " + msg;
            lblErrorMessage.Visible = true;
        }

        private void btnCerrarPago_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarPago_Click(object sender, EventArgs e)
        {
            string error = listaPag.guardarEnArchivoPagos();
            if (error != "")
                MessageBox.Show(error);
        }

        private void btnAgregarPago_Click(object sender, EventArgs e)
        {
            PagarProductos nuevoPago = new PagarProductos();
            if ((txtNombreEmpresa.Text != "") && (txtTipoProd.Text != "") && (txtCantidad.Text != "") && (txtMonto.Text != "") && (dtpFechaPago.Text != ""))
            {
                nuevoPago.nombreEmpresa = txtNombreEmpresa.Text;
                nuevoPago.tipoProducto = txtTipoProd.Text;
                nuevoPago.cantidad = int.Parse(txtCantidad.Text);
                nuevoPago.monto = double.Parse(txtMonto.Text);
                nuevoPago.FechaPago = DateTime.Parse(dtpFechaPago.Text);
                listaPag.agregarPago(nuevoPago);
                actualizarGrilla();
                limpiar();
                lblErrorMessage.Visible = false;
            }
            else
            {
                msgError("Ingrese todos los campos correctamente.  \n     Inténtalo de nuevo");
                dtpFechaPago.Text = "";
                txtNombreEmpresa.Focus();
            }
        }
        private void limpiar()
        {
            txtNombreEmpresa.Text = "";
            txtTipoProd.Text = "";
            txtCantidad.Text = "";
            txtMonto.Text = "";
            dtpFechaPago.Text = "";            
            txtNombreEmpresa.Focus();
        }

        private void btnCargarPago_Click(object sender, EventArgs e)
        {
            string error = listaPag.cargarDesdeArchivoPagos();
            if (error != "")
                MessageBox.Show(error);
            actualizarGrilla();
            lblErrorMessage.Visible = false;
        }

        private void btnEliminarPago_Click(object sender, EventArgs e)
        {
            if (posicionSeleccionada > -1)
            {
                listaPag.eliminarPago(posicionSeleccionada);
                actualizarGrilla();
                limpiar();
                txtNombreEmpresa.Focus();
            }
            else
            {
                MessageBox.Show("Seleccione un Producto");
            }
        }

        private void dgvPagos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvPagos.SelectedRows.Count > 0)
                {
                    DataGridViewRow filaSeleccionada = dgvPagos.SelectedRows[0];
                    posicionSeleccionada = filaSeleccionada.Index;
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
    
}
