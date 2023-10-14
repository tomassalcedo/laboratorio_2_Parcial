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
    public partial class FrmAltaUsuario : Form
    {
        public FrmAltaUsuario()
        {
            InitializeComponent();
        }

        private void FrmAltaUsuario_Load(object sender, EventArgs e)
        {
            cbCategoria.Items.Add("Operario");
            cbCategoria.Items.Add("Supervisor");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Carga cancelada");
            this.Close();
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtBoxNombreUsuario.Text;
            string password = txtBoxPassword.Text;
            bool categoria = false;
            Usuario auxUsuario;

            if (Datos.BuscarUsuario(nombreUsuario, password) is null)
            {
                if (cbCategoria.SelectedItem == "Supervisor")
                {
                    categoria = true;
                }

                auxUsuario = new Usuario(nombreUsuario, password, categoria);
                Datos.usuariosEnSistema.Add(auxUsuario);
                MessageBox.Show($"Usuario registrado exitosamente\n{auxUsuario.MostrarUsuario()}");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("El nombre de usuario/contraseña ya existe");
            }
        }
    }
}
