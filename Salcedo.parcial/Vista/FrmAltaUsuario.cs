using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmAltaUsuario : Form, IConfiguraciones
    {
        Usuario usuario;
        public FrmAltaUsuario(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void FrmAltaUsuario_Load(object sender, EventArgs e)
        {
            AplicarConfiguraciones();

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
            Usuario auxUsuario = LogicaNegocio.BuscarUsuario(nombreUsuario, password);

            if (auxUsuario is null)
            {
                if (cbCategoria.SelectedItem.ToString() == "Supervisor")
                {
                    categoria = true;
                }

                auxUsuario = new Usuario(0, nombreUsuario, password, categoria);
                UsuarioDao.Guardar(auxUsuario);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("El nombre de usuario ya se encuentra registrado");
            }
        }






        public void AplicarConfiguraciones()
        {
            Configuracion config = Archivos<Configuracion>.LeerConfiguracion("configuracion");
            FontFamily fontFamily = new FontFamily(config.Fuente);
            Font font = new Font(fontFamily, this.Font.Size, FontStyle.Regular);
            this.Font = font;
            this.BackColor = config.ColorFondo;

            cbCategoria.Items.Add("Operario");
            cbCategoria.Items.Add("Supervisor");
            lblUsuario.Text = LogicaNegocio.ConsuntarCategoria(usuario);
        }





    }
}
