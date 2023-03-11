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
    }
}
