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
    public partial class FrmLogin : Form
    {
        Usuario user;

        public FrmLogin()
        {
            // Datos.HardCodearUsuarios();
            InitializeComponent();
        }


        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.Text = "Login -Salcedo Play-";
            this.txtBoxPassword.UseSystemPasswordChar = true;
        }


        private void btnRellenar_Click(object sender, EventArgs e)
        {
            this.txtBoxUsuario.Text = "devthomas12";
            this.txtBoxPassword.Text = "sistemas123";

        }

        private void chkBoxMostrarPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxMostrarPass.CheckState == CheckState.Checked)
            {
                this.txtBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                this.txtBoxPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtBoxUsuario.Text;
            string password = txtBoxPassword.Text;
            user = Datos.VerificarPassword(Datos.usuariosEnSistema, password, nombreUsuario);

            if (user is not null)
            {
                this.Hide();
                FrmMenuPrincipal frmMenuPrincipal = new FrmMenuPrincipal(user);

                if (frmMenuPrincipal.ShowDialog() == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Usuario/Contraseña invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRellenarOperario_Click(object sender, EventArgs e)
        {
            this.txtBoxUsuario.Text = "JuanCarlos";
            this.txtBoxPassword.Text = "10peso";
        }
    }
}
