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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            //cierra la app
            Application.Exit();
        }

        private void TxtContrasenia_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnVerContrasenia_MouseDown(object sender, MouseEventArgs e)
        {
            TxtContrasenia.UseSystemPasswordChar= false;
        }

        private void BtnVerContrasenia_MouseUp(object sender, MouseEventArgs e)
        {
            TxtContrasenia.UseSystemPasswordChar = true;    
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            //todo: se debe validar el usuario

            Globales.MiFormPrincipal.Show();

            this.Hide();
        }
    }
}
