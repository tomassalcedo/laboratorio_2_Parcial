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
    public partial class FrmEditarUsuario : Form
    {
        Usuario user;

        public FrmEditarUsuario(Usuario user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void FrmEditarUsuario_Load(object sender, EventArgs e)
        {
            dgvUsuario.Rows.Add(user.NombreUsuario, user.Password, user.EsAdmin);
            cbCamposAEditar.Items.Add("Nombre de usuario");
            cbCamposAEditar.Items.Add("Contraseña");
            cbCamposAEditar.Items.Add("Categoria");
            cbCategoria.Items.Add("Supervisor");
            cbCategoria.Items.Add("Operario");
            lblNombre.Visible = false;
            txtNombreUsuario.Visible = false;
            lblPass.Visible = false;
            txtPassword.Visible = false;
            lblCategoria.Visible = false;
            cbCategoria.Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            switch (cbCamposAEditar.SelectedItem.ToString())
            {
                case "Nombre de usuario":
                    user.NombreUsuario = txtNombreUsuario.Text;
                    break;

                case "Contraseña":
                    user.Password = txtPassword.Text;
                    break;

                case "Categoria":
                    if (cbCategoria.SelectedItem.ToString() == "Supervisor")
                    {
                        user.EsAdmin = true;
                        break;
                    }
                    else
                    {
                        user.EsAdmin = false;
                        break;
                    }



            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cbCamposAEditar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string campo = cbCamposAEditar.SelectedItem.ToString();
            if (campo == "Nombre de usuario")
            {
                lblNombre.Visible = true;
                txtNombreUsuario.Visible = true;
                lblPass.Visible = false;
                txtPassword.Visible = false;
                lblCategoria.Visible = false;
                cbCategoria.Visible = false;
            }
            else if (campo == "Contraseña")
            {
                lblPass.Visible = true;
                txtPassword.Visible = true;
                lblNombre.Visible = false;
                txtNombreUsuario.Visible = false;
            }
            else if (campo == "Categoria")
            {
                lblCategoria.Visible = true;
                cbCategoria.Visible = true;
                lblNombre.Visible = false;
                txtNombreUsuario.Visible = false;
                lblPass.Visible = false;
                txtPassword.Visible = false;
            }
        }
    }
}
