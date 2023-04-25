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
    public partial class FrmProveedorGestion : Form
    {
        private Logica.Models.Proveedor MiProveedorLocal { get; set; }
        private DataTable ListaProveedores { get; set; }
        public FrmProveedorGestion()
        {
            InitializeComponent();
            MiProveedorLocal = new Logica.Models.Proveedor();
            ListaProveedores = new DataTable();
        }

        private void FrmProveedorGestion_Load(object sender, EventArgs e)
        {
            MdiParent = Globales.MiFormPrincipal;
            CargarListaTipoProveedores();
            CargarListaDeProveedoresExamen();
        }

        private void CargarListaDeProveedoresExamen() 
        {
            ListaProveedores = new DataTable();
            if (CboxVerActivos.Checked)
            {
                ListaProveedores = MiProveedorLocal.ListarActivos();
            }
            else 
            {
                ListaProveedores = MiProveedorLocal.ListarInactivos();
            }
            DgLista.DataSource = ListaProveedores;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void CargarListaTipoProveedores() 
        {
            Logica.Models.TipoProveedor MiTipo = new Logica.Models.TipoProveedor(); 
            DataTable dt = new DataTable();
            dt = MiTipo.Listar();
            if (dt != null && dt.Rows.Count > 0)
            {
                CbTipoProveedor.ValueMember = "ID";
                CbTipoProveedor.DisplayMember = "Descripcion";
                CbTipoProveedor.DataSource = dt;
                CbTipoProveedor.SelectedIndex = -1;
            }
        }

        private void DgLista_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DgLista.ClearSelection();
        }

        private void DgLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgLista.SelectedRows.Count ==1)
            {
                DataGridViewRow Mifila = DgLista.SelectedRows[0];
                int IdUsuario = Convert.ToInt32(Mifila.Cells["CProveedorID"].Value);
                MiProveedorLocal = new Logica.Models.Proveedor();
                MiProveedorLocal.ProveedorID = IdUsuario;
                MiProveedorLocal = MiProveedorLocal.ConsultarPorIDRetornaProveedor();

                if (MiProveedorLocal != null && MiProveedorLocal.ProveedorID > 0)
                {
                    TxtProveedorID.Text = Convert.ToString(MiProveedorLocal.ProveedorID);
                    TxtProveedorNombre.Text = MiProveedorLocal.ProveedorNombre;
                    TxtProveedorCedula.Text = MiProveedorLocal.ProveedorCedula;
                    TxtProveedorEmail.Text = MiProveedorLocal.ProveedorEmail;
                    TxtProveedorNotas.Text = MiProveedorLocal.ProveedorNotas;
                    TxtProveedorDireccion.Text = MiProveedorLocal.ProveedorDireccion;

                    CbTipoProveedor.SelectedValue = MiProveedorLocal.MiTipoProveedor.ProveedorTipoID;

                }
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void LimpiarFormulario() 
        {
            TxtProveedorID.Clear();
            TxtProveedorNombre.Clear();
            TxtProveedorCedula.Clear();
            TxtProveedorEmail.Clear();
            TxtProveedorNotas.Clear();
            TxtProveedorDireccion.Clear();
            CbTipoProveedor.SelectedIndex = -1;
        }

        private bool ValidarDatosDigitados()
        {
            bool r = false;

            if (!string.IsNullOrEmpty(TxtProveedorNombre.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtProveedorCedula.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtProveedorEmail.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtProveedorNotas.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtProveedorDireccion.Text.Trim()) &&
                CbTipoProveedor.SelectedIndex > -1 )
            {
                r = true;
            }
            else
            {
                if (string.IsNullOrEmpty(TxtProveedorNombre.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar un nombre para el proveedor", "Error de validacion", MessageBoxButtons.OK);
                    TxtProveedorNombre.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(TxtProveedorCedula.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar una cedula para el proveedor", "Error de validacion", MessageBoxButtons.OK);
                    TxtProveedorCedula.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(TxtProveedorEmail.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar un email para el proveedor", "Error de validacion", MessageBoxButtons.OK);
                    TxtProveedorEmail.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(TxtProveedorNotas.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar una nota para el proveedor", "Error de validacion", MessageBoxButtons.OK);
                    TxtProveedorNotas.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(TxtProveedorDireccion.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar una direccion para el proveedor", "Error de validacion", MessageBoxButtons.OK);
                    TxtProveedorDireccion.Focus();
                    return false;
                }
                if (CbTipoProveedor.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe elegir un tipo para el proveedor", "Error de validacion", MessageBoxButtons.OK);
                    TxtProveedorNombre.Focus();
                    return false;
                }
            }

            return r;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosDigitados())
            {
                bool CedulaOk;
                bool emailOk;

            
                MiProveedorLocal = new Logica.Models.Proveedor();

                MiProveedorLocal.ProveedorNombre = TxtProveedorNombre.Text.Trim();
                MiProveedorLocal.ProveedorCedula = TxtProveedorCedula.Text.Trim();
                MiProveedorLocal.ProveedorEmail = TxtProveedorEmail.Text.Trim();
                MiProveedorLocal.ProveedorDireccion = TxtProveedorDireccion.Text.Trim();
                MiProveedorLocal.ProveedorNotas = TxtProveedorNotas.Text.Trim();
                MiProveedorLocal.MiTipoProveedor.ProveedorTipoID = Convert.ToInt32(CbTipoProveedor.SelectedValue);

                CedulaOk = MiProveedorLocal.ConsultarPorCedula();
                //pasos 1.4 y 1.4.6
                emailOk = MiProveedorLocal.ConsultarPorEmail();
                //paso 1.5
                if (CedulaOk == false && emailOk == false)
                {
                    //se le puede agregar el usuario ya que no existe un usuario con la cedula y correo digitados
                    //se solicita al usuario confirmacion de si quiere agregar o no al usuario
                    string msg = string.Format("Esta seguro que desea agregar al proveedor {0}?",
                        MiProveedorLocal.ProveedorNombre);
                    DialogResult respuesta = MessageBox.Show(msg, "???", MessageBoxButtons.YesNo);

                    if (respuesta == DialogResult.Yes)
                    {
                        bool ok = MiProveedorLocal.Agregar();
                        if (ok)
                        {
                            MessageBox.Show("Proveedor guardado correctamente!", "Muy Bien!", MessageBoxButtons.OK);
                            LimpiarFormulario();
                            CargarListaDeProveedoresExamen();

                        }
                        else
                        {
                            MessageBox.Show("El proveedor no se pudo guardar!", "Se presento un problema!", MessageBoxButtons.OK);
                        }
                    }
                }
                else
                {
                    //indicar al usuario si falla alguna consulta
                    if (CedulaOk)
                    {
                        MessageBox.Show("Ya existe un proveedor con la cedula digitada", "Error de validacion", MessageBoxButtons.OK);
                        return;
                    }
                    if (emailOk)
                    {
                        MessageBox.Show("Ya existe un proveedor con el correo digitado", "Error de validacion", MessageBoxButtons.OK);
                        return;
                    }
                }
            }

        }









    }
}
