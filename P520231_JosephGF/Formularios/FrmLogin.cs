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
            //validar que se haya digitado un usuario y contrasenia

            if (!string.IsNullOrEmpty(TxtEmail.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtContrasenia.Text.Trim()))
            {
                string usuario = TxtEmail.Text.Trim();
                string contrasennia = TxtContrasenia.Text.Trim();

                //tratar de validar que los datos digitados sean correctos
                //en caso de que la validacion sea correcta, aplicamos los valores al usuario global
                Globales.MiUsuarioGlobal = Globales.MiUsuarioGlobal.
                    ValidarUsuario(usuario, contrasennia);

                if (Globales.MiUsuarioGlobal.UsuarioID > 0)
                {
                    //si la validacion es correcta, el id deberia tener un valor mayor a 0
                    Globales.MiFormPrincipal.Show();

                    this.Hide();
                }
                else 
                {
                    MessageBox.Show("Usuario o contraseña incorrecto," +
                        " porfavor intentelo otra vez.", "Error de validacion",
                        MessageBoxButtons.OK);
                    TxtContrasenia.Focus();
                    TxtContrasenia.SelectAll();
                }
            }
            else 
            {
                MessageBox.Show("Faltan datos requeridos","Error de validacion",
                    MessageBoxButtons.OK);
            }
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            //al presionar cierta combinacion de teclas el boton de ingreso directo aparece
            if (e.Shift & e.KeyCode == Keys.A)
            {
                //si presionamos shift = tab = a
                BtnIngresoDirecto.Visible = true;
            }
        }

        private void BtnIngresoDirecto_Click(object sender, EventArgs e)
        {
            Globales.MiFormPrincipal.Show();

            this.Hide();
        }
    }
}
