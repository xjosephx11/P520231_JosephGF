using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P520231_JosephGF.Formularios
{
    public partial class FrmMDI : Form
    {
        public FrmMDI()
        {
            InitializeComponent();
        }

        private void FrmMDI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void FrmMDI_Load(object sender, EventArgs e)
        {
            //mostrar el usuario logueado

            string InfoUsuario = string.Format("{0}-{1}({2})",
                Globales.MiUsuarioGlobal.UsuarioNombre,
                Globales.MiUsuarioGlobal.UsuarioCorreo,
                Globales.MiUsuarioGlobal.MiRolTipo.UsuarioRolDescripcion);
            LblUsuario.Text = InfoUsuario;

            switch (Globales.MiUsuarioGlobal.MiRolTipo.UsuarioRolID)
            {
                case 1:
                    //seria admin, no se oculta nada
                    break;
                case 2:
                    //serua usuario normal, se deben ocultar algunas opciones de menu
                    gestionDeUsuariosToolStripMenuItem.Visible = false;
                    rolesDeUsuarioToolStripMenuItem.Visible = false;
                    tipoDeProveedorToolStripMenuItem.Visible = false;
                    tipoDeCompraToolStripMenuItem.Visible = false;
                    break;
            }

        }

        private void MnuReportes_Click(object sender, EventArgs e)
        {

        }

        private void MnuProcesos_Click(object sender, EventArgs e)
        {

        }

        private void MnuGestiones_Click(object sender, EventArgs e)
        {

        }

        private void gestionDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //control para que el formulario de gestion de usuarios se muestre
            //solo una vez

            if (!Globales.MiFormGestionUsuarios.Visible)
            {
                Globales.MiFormGestionUsuarios = new FrmUsuariosGestion();

                Globales.MiFormGestionUsuarios.Show();
            }

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void registroDeComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Globales.MiFormRegistroCompra.Visible)
            {
                Globales.MiFormRegistroCompra = new FrmRegistroCompra();

                Globales.MiFormRegistroCompra.Show();
            }
        }
    }
}
