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
    public partial class FrmUsuarios : Form, IConfiguraciones
    {
        Usuario user;


        public FrmUsuarios(Usuario user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            AplicarConfiguraciones();
            
            dgvUsuarios.DataSource = UsuarioDao.Leer();
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
                int id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                auxUsuario = UsuarioDao.Leer(id);
                DialogResult resultado = MessageBox.Show(auxUsuario.ToString() + "\n¿Desea eliminar el usuario del sistema?", "Eliminar Usuario", MessageBoxButtons.OKCancel);
                if (resultado == DialogResult.OK)
                {
                    UsuarioDao.Eliminar(auxUsuario.Id);
                }

                dgvUsuarios.DataSource = null;
                dgvUsuarios.DataSource = UsuarioDao.Leer();

            }
            else
            {
                MessageBox.Show("Seleccione un usuario para eliminar");
            }
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            FrmAltaUsuario frmAlta = new FrmAltaUsuario(user);
            frmAlta.ShowDialog();

            if (frmAlta.DialogResult == DialogResult.OK)
            {
                dgvUsuarios.DataSource = null;
                dgvUsuarios.DataSource = UsuarioDao.Leer();

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                Usuario auxUsuario;
                DataGridViewRow selectedRow = dgvUsuarios.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                auxUsuario = UsuarioDao.Leer(id);
                FrmEditarUsuario frmEditarUsuario = new FrmEditarUsuario(auxUsuario);
                frmEditarUsuario.ShowDialog();
                if (frmEditarUsuario.DialogResult == DialogResult.OK)
                {
                    dgvUsuarios.DataSource = null;
                    dgvUsuarios.DataSource = UsuarioDao.Leer();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un usuario");
            }
        }

        private void btnSerializarUsuarios_Click(object sender, EventArgs e)
        {
            List<Usuario> usuarios = UsuarioDao.Leer();

            try
            {
                 Archivos<List<Usuario>>.EscribirXmlAsync(usuarios,"UsuariosAsync");
            }
            catch (MiExcepcion ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show($"Usuarios serializados exitosamente.\nRuta: {Environment.SpecialFolder.Desktop}");
        }




        public void AplicarConfiguraciones()
        {
            Configuracion config = Archivos<Configuracion>.LeerConfiguracion("configuracion");
            FontFamily fontFamily = new FontFamily(config.Fuente);
            Font font = new Font(fontFamily, this.Font.Size, FontStyle.Regular);
            this.Font = font;
            this.BackColor = config.ColorFondo;

            lblUsuario.Text = LogicaNegocio.ConsuntarCategoria(user);
        }


    }
}
