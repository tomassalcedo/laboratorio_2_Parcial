using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmConfiguracion : Form, IConfiguraciones
    {
        Usuario user;


        public FrmConfiguracion(Usuario user)
        {
            InitializeComponent();
            this.user = user;
        }


        private void FrmConfiguracion_Load(object sender, EventArgs e)
        {

            AplicarConfiguraciones();
            CargarFuentes();
            CargarColores();
        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Configuracion configuracion = new Configuracion();
            string colorSeleccionado = cmbColores.SelectedItem.ToString();
            configuracion.ColorFondo = Color.FromName(colorSeleccionado);
            configuracion.Fuente = cmbFuentes.SelectedItem.ToString();
            Archivos<Configuracion>.GuardarConfiguracion(configuracion, "configuracion");
            this.DialogResult = DialogResult.OK;
        }



        private void CargarFuentes()
        {
            InstalledFontCollection installedFontCollection = new InstalledFontCollection();
            FontFamily[] fontFamilies = installedFontCollection.Families;

            foreach (FontFamily font in fontFamilies)
            {
                cmbFuentes.Items.Add(font.Name);
            }
            cmbFuentes.SelectedItem = "Bahnschrift";
        }

        private void CargarColores()
        {
            KnownColor[] colores = (KnownColor[])Enum.GetValues(typeof(KnownColor));

            foreach (KnownColor item in colores)
            {
                Color color = Color.FromKnownColor(item);
                if (!color.IsSystemColor)
                {
                    cmbColores.Items.Add(item);
                }
            }
            cmbColores.SelectedIndex = 4;
        }





        public void AplicarConfiguraciones()
        {
            Configuracion config = Archivos<Configuracion>.LeerConfiguracion("configuracion");
            FontFamily fontFamily = new FontFamily(config.Fuente);
            Font font = new Font(fontFamily, this.Font.Size, FontStyle.Regular);
            this.Font = font;
            this.BackColor = config.ColorFondo;
        }



        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
