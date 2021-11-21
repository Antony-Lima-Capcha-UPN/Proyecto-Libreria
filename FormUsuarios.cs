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
    public partial class FormUsuarios : Form
    {
        ListaUsuario lista = new ListaUsuario();
        int posicionSeleccionada = -1;

        public FormUsuarios()
        {
            InitializeComponent();
            actualizarGrilla();
        }

        private void btnCerrarUsuarios_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuarioNuevo.Text;
            string contraseña = txtContraseñaNueva.Text;
            Usuario user = new Usuario();

            if ((txtUsuarioNuevo.Text != "") && (txtContraseñaNueva.Text != ""))
            {
                user.usuario = usuario;
                user.contraseña = contraseña;
                lista.agregarUsuario(user);
                actualizarGrilla();
                limpiar();
                lblErrorMessage.Visible = false;
            }
            else
            {
                msgError("Ingrese usuario y contraseña nuevo a registrar.  \n     Inténtalo de nuevo");
                txtContraseñaNueva.Text = "";
                txtUsuarioNuevo.Focus();
            }
        }
        private void msgError(string msg)
        {
            lblErrorMessage.Text = "     " + msg;
            lblErrorMessage.Visible = true;
        }
        private void actualizarGrilla()
        {
            List<Usuario> listaAux = lista.getLista();
            dgvUsuarios.Rows.Clear();
            foreach (Usuario user in listaAux)
            {
                int filanueva = dgvUsuarios.Rows.Add();
                dgvUsuarios.Rows[filanueva].Cells[0].Value = user.usuario;
                dgvUsuarios.Rows[filanueva].Cells[1].Value = user.contraseña;

            }

        }
        private void limpiar()
        {
            txtUsuarioNuevo.Text = "";
            txtContraseñaNueva.Text = "";
            txtUsuarioNuevo.Focus();
        }

        private void btnGuardarUsuarios_Click(object sender, EventArgs e)
        {
            lista.guardarEnArchivo();
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (posicionSeleccionada > -1)
            {
                lista.eliminarUsuario(posicionSeleccionada);
                actualizarGrilla(); 
                limpiar();
                txtUsuarioNuevo.Focus();
            }
            else
            {
                MessageBox.Show("Seleccione un Usuario");
            }
        }

        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvUsuarios.SelectedRows.Count > 0)
                {
                    DataGridViewRow filaSeleccionada = dgvUsuarios.SelectedRows[0];
                    posicionSeleccionada = filaSeleccionada.Index;
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            posicionSeleccionada = dgvUsuarios.CurrentRow.Index;
            txtUsuarioNuevo.Text = dgvUsuarios[0, posicionSeleccionada].Value.ToString();
            txtContraseñaNueva.Text = dgvUsuarios[1, posicionSeleccionada].Value.ToString();
            txtUsuarioNuevo.Focus();
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            string usuario, contraseña;
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                
                usuario = txtUsuarioNuevo.Text;
                contraseña = txtContraseñaNueva.Text;
                dgvUsuarios[0, posicionSeleccionada].Value = txtUsuarioNuevo.Text;
                dgvUsuarios[1, posicionSeleccionada].Value = txtContraseñaNueva.Text;
                limpiar();
                txtUsuarioNuevo.Focus();
            }
            else
                MessageBox.Show("Debe seleccionar fila");
        }

        private void btnCargarUsuario_Click(object sender, EventArgs e)
        {
            string error = lista.cargarDesdeArchivo();
            if (error != "")
                MessageBox.Show(error);
            actualizarGrilla();
            lblErrorMessage.Visible = false;
        }
    }
}
