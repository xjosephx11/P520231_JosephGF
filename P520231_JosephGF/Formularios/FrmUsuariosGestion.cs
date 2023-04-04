using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P520231_JosephGF.Formularios
{
    public partial class FrmUsuariosGestion : Form
    {
        //por orden es mejor  crear objetos locales que permitan
        //la gestion del tema que estamos tratando.
        //usar objetos individuales en las funciones puede provocar desorden
        //y complicar mas la lectura del codigo fuente.


        //objeto local para usuario
        private Logica.Models.Usuario MiUsuarioLocal { get; set; }

        //lista local de usuarios quese  visualizan en el datagridview
        private DataTable ListaUsuarios { get; set; }



        //constructor
        public FrmUsuariosGestion()
        {
            InitializeComponent();

            MiUsuarioLocal = new Logica.Models.Usuario();
            ListaUsuarios = new DataTable();
        }

        private void FrmUsuariosGestion_Load(object sender, EventArgs e)
        {
            //definimos el padre mdi
            MdiParent = Globales.MiFormPrincipal;

            CargarListaRoles();

            CargarListaDeUsuarios();

            ActivarAgregar();

        }

        private void CargarListaDeUsuarios()
        {
            //resetear la lista de usuarios haciendo re instancia del objeto
            ListaUsuarios = new DataTable();

            //si en el cuadro de teo de busqueda hay 3 o mas caracteres se filtra la lista
            string FiltroBusqueda = "";
            if (!string.IsNullOrEmpty(TxtBuscar.Text.Trim()) && TxtBuscar.Text.Count() >= 3)
            {
                FiltroBusqueda = TxtBuscar.Text.Trim(); 
            }
            if (CboxVerActivos.Checked)
            {
                //enel cuadro de texto de busqueda hay mas de 3 o mas caracteres, se filtra la lista

                ListaUsuarios = MiUsuarioLocal.ListarActivos(FiltroBusqueda);
            }
            else 
            {
                ListaUsuarios = MiUsuarioLocal.ListarInactivos(FiltroBusqueda);
            }

            DgLista.DataSource = ListaUsuarios;
            

        }



        private void CargarListaRoles() { 
            //creamos un objeto llamado mi rol de tipo rol
            Logica.Models.Usuario_Rol MiRol = new Logica.Models.Usuario_Rol();
            
            DataTable dt = new DataTable();
            dt = MiRol.Listar();

            if (dt != null && dt.Rows.Count > 0 )
            {
                CbRolesUsuario.ValueMember = "ID";
                CbRolesUsuario.DisplayMember= "Descripcion";
                CbRolesUsuario.DataSource= dt;  
                CbRolesUsuario.SelectedIndex= -1;

            }
        }

        private void DgLista_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DgLista.ClearSelection();
        }

        private void DgLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //cuando seleccionemos una fila del datagrid se debe cargar la info de dicho usuario
            //en el usuario local y luego dibujar esa info en los controles graficos.

            if (DgLista.SelectedRows.Count == 1)
            {
                LimpiarFormulario();
                //de la coleecion de filas seleccionadas (que en este caso es solo una)
                ////seleccionamos la fila en indice 0, osea la primera
                DataGridViewRow MiFila = DgLista.SelectedRows[0];

                //lo que necesito es el valor del id del usuario para realizar la consulta 
                //y traer todos los datos para llenar el objeto de usuario local

                int IdUsuario = Convert.ToInt32(MiFila.Cells["CUsuarioID"].Value);

                //para no asumir riesgos se re instancia el usuario local
                MiUsuarioLocal = new Logica.Models.Usuario();

                //ahora le agregamos el valor obtenido por la fila al id del usuario local
                MiUsuarioLocal.UsuarioID = IdUsuario;

                //una vez que tengo el objeto local con el valor del id , puedo ir a consultar
                //el usuario por ese id y llenar el resto de atributos.

                MiUsuarioLocal = MiUsuarioLocal.ConsultarPorIDRetornaUsuario();

                //validamos que el usuario local tenga datos

                if (MiUsuarioLocal != null && MiUsuarioLocal.UsuarioID > 0)
                {
                    //si cargamos correctamente el usuario local llenamos los controles

                    TxtUsuarioID.Text = Convert.ToString(MiUsuarioLocal.UsuarioID);

                    TxtUsuarioNombre.Text = MiUsuarioLocal.UsuarioNombre;

                    TxtUsuarioCedula.Text = MiUsuarioLocal.UsuarioCedula;

                    TxtUsuarioTelefono.Text = MiUsuarioLocal.UsuarioTelefono;

                    TxtUsuarioCorreo.Text = MiUsuarioLocal.UsuarioCorreo;

                    TxtUsuarioDireccion.Text = MiUsuarioLocal.UsuarioDireccion;

                    //con los combobox

                    CbRolesUsuario.SelectedValue = MiUsuarioLocal.MiRolTipo.UsuarioRolID;

                    ActivarEditarYEliminar();


                }

            }

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            DgLista.ClearSelection(); //esto es para deseleccionar la info
            ActivarAgregar();
        }

        private void ActivarAgregar() { 
            BtnAgregar.Enabled = true;
            BtnModificar.Enabled = false;
            BtnEliminar.Enabled = false;
        }

        private void ActivarEditarYEliminar() {
            BtnAgregar.Enabled = false;
            BtnModificar.Enabled = true;
            BtnEliminar.Enabled = true;
        }
        private void LimpiarFormulario() { 
            TxtUsuarioID.Clear();
            TxtUsuarioNombre.Clear();
            TxtUsuarioCedula.Clear();
            TxtUsuarioTelefono.Clear();
            TxtUsuarioCorreo.Clear();
            TxtUsuarioContrasennia.Clear();

            CbRolesUsuario.SelectedIndex = -1; //asi se limpia un combobox

            TxtUsuarioDireccion.Clear();
        }

        private bool validarDatosDigitados(bool omitirPassword = false) {
            //evalua que se hayan digitado los campos de texto en el formulario
            bool R = false;

            if (!string.IsNullOrEmpty(TxtUsuarioNombre.Text.Trim()) && 
                !string.IsNullOrEmpty(TxtUsuarioCedula.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtUsuarioTelefono.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtUsuarioCorreo.Text.Trim()) &&
                CbRolesUsuario.SelectedIndex > -1)
            {

                if (omitirPassword)
                {
                    //(para editar) si el password se omite, entonces ya paso la evaluacion, a este punto retorna true
                    R = true;
                }
                else 
                {
                    //(para agregar) en el caso que haya que evaluar la contrasenia se debe agregar otra condicion logica
                    if (!string.IsNullOrEmpty(TxtUsuarioContrasennia.Text.Trim()))
                    {
                        R = true;
                    }
                    else
                    {
                        //en el caso en el que haga falta la contrasenia, se le indica al usuario
                        MessageBox.Show("Debe digitar una contraseña para el usuario", "Error de validacion", MessageBoxButtons.OK);
                        TxtUsuarioContrasennia.Focus();
                        return false;
                    }

                }

            }
            else 
            {
                //que pasa cuando algo falta?
                if (string.IsNullOrEmpty(TxtUsuarioNombre.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar un nombre para el usuario", "Error de validacion", MessageBoxButtons.OK);
                    TxtUsuarioNombre.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(TxtUsuarioCedula.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar la cedula para el usuario", "Error de validacion", MessageBoxButtons.OK);
                    TxtUsuarioCedula.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(TxtUsuarioTelefono.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar un telefono para el usuario", "Error de validacion", MessageBoxButtons.OK);
                    TxtUsuarioTelefono.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(TxtUsuarioCorreo.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar un correo para el usuario", "Error de validacion", MessageBoxButtons.OK);
                    TxtUsuarioCorreo.Focus();
                    return false;
                }
               
                if (CbRolesUsuario.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un rol para el usuario", "Error de validacion", MessageBoxButtons.OK);
                    CbRolesUsuario.Focus();
                    return false;
                }

            }

            return R;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (validarDatosDigitados())
            {
                //ests variables almacenan el resultado de las consultas  por correo y y cedula
                bool CedulaOk;
                bool emailOk;

                //pasos 1.1 y 1.2
                MiUsuarioLocal = new Logica.Models.Usuario();

                //llenar los valores de los atributos con los datos digitados en el form
                MiUsuarioLocal.UsuarioNombre = TxtUsuarioNombre.Text.Trim();
                MiUsuarioLocal.UsuarioCedula = TxtUsuarioCedula.Text.Trim();
                MiUsuarioLocal.UsuarioTelefono = TxtUsuarioTelefono.Text.Trim();
                MiUsuarioLocal.UsuarioCorreo = TxtUsuarioCorreo.Text.Trim();
                MiUsuarioLocal.UsuarioContrasenia = TxtUsuarioContrasennia.Text.Trim();
                //composicion del rol
                MiUsuarioLocal.MiRolTipo.UsuarioRolID = Convert.ToInt32(CbRolesUsuario.SelectedValue);
                MiUsuarioLocal.UsuarioDireccion = TxtUsuarioDireccion.Text.Trim();

                //realizar las consultas por email y por cedula
                //pasos 1.3 y 1.3.6
                CedulaOk = MiUsuarioLocal.ConsultarPorCedula();
                //pasos 1.4 y 1.4.6
                emailOk = MiUsuarioLocal.ConsultarPorEmail();
                //paso 1.5
                if (CedulaOk == false && emailOk == false)
                {
                    //se le puede agregar el usuario ya que no existe un usuario con la cedula y correo digitados
                    //se solicita al usuario confirmacion de si quiere agregar o no al usuario
                    string msg = string.Format("Esta seguro que desea agregar al usuario {0}?",
                        MiUsuarioLocal.UsuarioNombre);
                    DialogResult respuesta = MessageBox.Show(msg, "???", MessageBoxButtons.YesNo);

                    if (respuesta == DialogResult.Yes)
                    {
                        bool ok = MiUsuarioLocal.Agregar();
                        if (ok)
                        {
                            MessageBox.Show("Usuario guardado correctamente!", "Muy Bien!", MessageBoxButtons.OK);
                            LimpiarFormulario();
                            CargarListaDeUsuarios();

                        }
                        else
                        {
                            MessageBox.Show("El Usuario no se pudo guardar!", "Se presento un problema!", MessageBoxButtons.OK);
                        }
                    }
                }
                else 
                {
                    //indicar al usuario si falla alguna consulta
                    if (CedulaOk)
                    {
                        MessageBox.Show("Ya existe un usuario con la cedula digitada", "Error de validacion", MessageBoxButtons.OK);
                        return;
                    }
                    if (emailOk)
                    {
                        MessageBox.Show("Ya existe un usuario con el correo digitado", "Error de validacion", MessageBoxButtons.OK);
                        return;
                    }
                }

            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {

            if (validarDatosDigitados(true))
            {
                //no es necesario capturar el id dese el cuadro de texto ya que al consultarlo
                //cuando seleccionamos el usuario del datagrid, 
                //ya tenemos ldatos en el id. este id no puede ser modificado
                //los demas atributos si.
                MiUsuarioLocal.UsuarioNombre = TxtUsuarioNombre.Text.Trim();
                MiUsuarioLocal.UsuarioCedula = TxtUsuarioCedula.Text.Trim();
                MiUsuarioLocal.UsuarioTelefono = TxtUsuarioTelefono.Text.Trim();
                MiUsuarioLocal.UsuarioCorreo = TxtUsuarioCorreo.Text.Trim();    
               
                //como el cuadro de teto de la contrasenia tiene un caracter en blanco
                //ouedo asignar sin problema el valor dl cuadro de texto al atributo en el sp
                //se evalua si tiene o no datos.
                MiUsuarioLocal.UsuarioContrasenia = TxtUsuarioContrasennia.Text.Trim();

                MiUsuarioLocal.MiRolTipo.UsuarioRolID = Convert.ToInt32(CbRolesUsuario.SelectedValue);

                MiUsuarioLocal.UsuarioDireccion = TxtUsuarioDireccion.Text.Trim();

                //segun el diagrama de casos de uso expajdido y la secuencia normal
                //para el crud (editar) es habitual consultar por el id el otem que se va a modificar
                //para asegurarse en el lapso de tiempo que se selecciono el usuario y se modificaron los datos en pantalla
                //aun exista el registro en la base de datos. (existe una posibilidad de que ya no exista debido a que
                //en entornos donde hayan muchos usuarios trabajando en el sistema algun otro este modificando el mismo
                //registro) esto se llama concurrencia

                if (MiUsuarioLocal.ConsultarPorID())
                {
                    DialogResult respuesta = MessageBox.Show("¿esta seguro de modificar el usuario?", "???", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

                    if (respuesta == DialogResult.Yes)
                    {
                        if (MiUsuarioLocal.Editar())
                        {
                            MessageBox.Show("El usuario ha sido modificado correctamente", "Muy bien!", MessageBoxButtons.OK);
                            LimpiarFormulario();
                            CargarListaDeUsuarios();

                        }
                    }
                }

            }

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (MiUsuarioLocal.UsuarioID > 0 && MiUsuarioLocal.ConsultarPorID())
            {
                //tomando en cuenta que puedo estar viendo 2 usuarios activos o inactivos 
                //este boton podria servir tanto para activar como para desactivar los usuarios
                //el checkbox de la parte superiordel form me sirve para identificar esta accion

                if (CboxVerActivos.Checked)
                {
                    //desactivar usuario
                    DialogResult r = MessageBox.Show("esta seguro de eliminar al usuario?", "???", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (r == DialogResult.Yes)
                    {
                        if (MiUsuarioLocal.Eliminar())
                        {
                            MessageBox.Show("El usuaro ha sido eliminado correctamente.", "!!!", MessageBoxButtons.OK);
                            LimpiarFormulario();
                            CargarListaDeUsuarios();
                        }
                    }
                }
                else
                {
                    //activar usuario
                }
            }
        }

        private void TxtUsuarioNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e,true);
        }

        private void TxtUsuarioCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresNumeros(e,true);
        }

        private void TxtUsuarioTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e);
        }

        private void TxtUsuarioCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e, false);
        }

        private void TxtUsuarioContrasennia_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresNumeros(e);
        }

        private void TxtUsuarioDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e, true);
        }

        private void TxtUsuarioCorreo_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtUsuarioCorreo.Text.Trim()))
            {
                if (!Validaciones.ValidarEmail(TxtUsuarioCorreo.Text.Trim()))
                {
                    MessageBox.Show("El formato del correo electronico es incorrecto",
                        "Error de validacion", MessageBoxButtons.OK);
                    TxtUsuarioCorreo.Focus();
                }
            }
        }

        private void TxtUsuarioCorreo_Enter(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtUsuarioCorreo.Text.Trim()))
            {

                TxtUsuarioCorreo.SelectAll();
            }
        }

        private void CboxVerActivos_CheckedChanged(object sender, EventArgs e)
        {
            CargarListaDeUsuarios();

            if (CboxVerActivos.Checked)
            {
                BtnEliminar.Text = "ELIMINAR";
            }
            else 
            {
                BtnEliminar.Text = "ACTIVAR";
            }
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {

            CargarListaDeUsuarios();

        }
    }
}
