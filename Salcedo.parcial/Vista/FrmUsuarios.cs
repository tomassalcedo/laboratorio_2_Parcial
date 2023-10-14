using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = Datos.usuariosEnSistema;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                Usuario auxUsuario;
                DataGridViewRow selectedRow = dgvUsuarios.SelectedRows[0];
                string nombreUsuario = selectedRow.Cells["NombreUsuario"].Value.ToString();
                string password = selectedRow.Cells["Password"].Value.ToString();
                auxUsuario = Datos.BuscarUsuario(nombreUsuario, password);
                Datos.usuariosEnSistema.Remove(auxUsuario);
                dgvUsuarios.DataSource = null;
                dgvUsuarios.DataSource = Datos.usuariosEnSistema;
            }
            else
            {
                MessageBox.Show("Seleccione un usuario");
            }
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            FrmAltaUsuario frmAltaUsuario = new FrmAltaUsuario();
            frmAltaUsuario.ShowDialog();
            if (frmAltaUsuario.DialogResult == DialogResult.OK)
            {
                dgvUsuarios.DataSource = null;
                dgvUsuarios.DataSource = Datos.usuariosEnSistema;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                Usuario auxUsuario;
                DataGridViewRow selectedRow = dgvUsuarios.SelectedRows[0];
                string nombreUsuario = selectedRow.Cells["NombreUsuario"].Value.ToString();
                string password = selectedRow.Cells["Password"].Value.ToString();
                auxUsuario = Datos.BuscarUsuario(nombreUsuario, password);
                FrmEditarUsuario frmEditarUsuario = new FrmEditarUsuario(auxUsuario);
                frmEditarUsuario.ShowDialog();
                if (frmEditarUsuario.DialogResult == DialogResult.OK)
                {
                    dgvUsuarios.DataSource = null;
                    dgvUsuarios.DataSource = Datos.usuariosEnSistema;
                }
            }
            else
            {
                MessageBox.Show("Seleccione un usuario");
            }




        }
    }
}
