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
    public partial class FormReportes : Form
    {
        ListaCompras listaComp = new ListaCompras();
        ListaEgreso listaPag = new ListaEgreso();
        ListaPedidos listaPed = new ListaPedidos();

        public FormReportes()
        {
            InitializeComponent();
        }
        private void btnCerrarReportes_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnBuscarReportCompras_Click(object sender, EventArgs e)
        {
            string error = listaComp.cargarDesdeArchivoCompras();
            if (error != "")
                MessageBox.Show(error);
            actualizarGrillaCompras();
        }
        private void actualizarGrillaCompras()
        {
            List<Compra> compras = listaComp.getLista();
            dgvReportCompras.Rows.Clear();
            foreach (Compra p in compras)
            {
                int indiceNuevaFila = dgvReportCompras.Rows.Add();
                DataGridViewRow filaNueva = dgvReportCompras.Rows[indiceNuevaFila];
                filaNueva.Cells[0].Value = p.categoria;
                filaNueva.Cells[1].Value = p.descripcion;
                filaNueva.Cells[2].Value = p.marca;
                filaNueva.Cells[3].Value = p.precio;
                filaNueva.Cells[4].Value = p.unidades;
            }
        }

        private void btnBuscarReportPagos_Click(object sender, EventArgs e)
        {
            string error = listaPag.cargarDesdeArchivoPagos();
            if (error != "")
                MessageBox.Show(error);
            actualizarGrillaPagos();
        }
        private void actualizarGrillaPagos()
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

        private void btnBuscarReportPedidos_Click(object sender, EventArgs e)
        {
            string error = listaPed.cargarDesdeArchivoPedidos();
            if (error != "")
                MessageBox.Show(error);
            actualizarGrillaPedidosVentasDia();
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
