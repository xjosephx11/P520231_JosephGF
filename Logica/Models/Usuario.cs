using Logica.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace Logica.Models
{
    public class Usuario
    {
        public int UsuarioID { get; set; }
        public string UsuarioCorreo { get; set; }
        public string UsuarioContrasenia { get; set; }
        public string UsuarioNombre { get; set; }

        public string UsuarioCedula { get; set; }

        public string UsuarioTelefono { get; set; }

        public string UsuarioDireccion { get; set; }
        public bool Activo { get; set; }


        public Usuario_Rol MiRolTipo { get; set; }

        //normalmente cuando tenemos propiedades compuestas con tipos
        //que hemos programado nosotros, debemos instanciar dichas propiedades
        //ya que son objetos. para esto recomiendo hacerlo en el constructor
        //de la clase

        //constructor
        public Usuario()
        {
            //al crear una nueva instancia de la clase Usuario, se ejecuta
            //el codigo de este constructor y tambien crea una nueva instancia
            //de la clase usuario_rol para el objeto MiRolTipo.
            MiRolTipo = new Usuario_Rol();

        }

        //funciones y metodos
        public bool Agregar()
        {
            //cuando la funcion devuelve un booleano me gusta inicializar la variable
            //de retorno en false(tiende a negativo el resultado de la funcion)
            //solo si la operacion (en este caso insert) sale correcta
            //se cambia el valor de R a true.
            bool R = false;

            //aqui va el codigo funcional que invoca a un procedimiento almacenado
            //que contiene el DML insert

            return R;
        }

        public bool Editar()
        {
            bool R = false;

            return R;
        }

        public bool Eliminar()
        {
            bool R = false;

            return R;
        }

        public bool ConsultarPorID()
        {
            bool R = false;

            return R;
        }

        public Usuario ConsultarPorIDRetornaUsuario()
        {
            Usuario R = new Usuario();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.UsuarioID));

            //necesito un datatable para capturar la info del usuario
            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSELECT("SPUsuarioConsultarPorID");

            if (dt != null && dt.Rows.Count > 0)
            {
                //  esta consulta deberia tener solo un  registro 
                //se  crea un onjeto de tipo datrow para capturar la info
                //contenida en index 0 del datatable (dt)
                DataRow dr = dt.Rows[0];

                R.UsuarioID = Convert.ToInt32(dr["UsuarioID"]);
                R.UsuarioNombre = Convert.ToString(dr["UsuarioNombre"]);
                R.UsuarioCedula = Convert.ToString(dr["UsuarioCedula"]);
                R.UsuarioCorreo = Convert.ToString(dr["UsuarioCorreo"]);
                R.UsuarioTelefono = Convert.ToString(dr["UsuarioTelefono"]);
                R.UsuarioDireccion = Convert.ToString(dr["UsuarioDireccion"]);

                R.UsuarioContrasenia = string.Empty;
                

                //composiciones
                R.MiRolTipo.UsuarioRolID = Convert.ToInt32(dr["UsuarioRolID"]);
                R.MiRolTipo.UsuarioRolDescripcion = Convert.ToString(dr["UsuarioRolDescripcion"]);


            }

            return R;
        }

        public bool ConsultarPorCedula()
        {
            bool R = false;

            return R;
        }

        public bool ConsultarPorEmail()
        {
            bool R = false;

            return R;
        }

        public DataTable ListarActivos()
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();
            //en este caso como el sp tiene un parametro, debemos por lo tanto ddefinir
            //ese parametro, en la listade parametros del  objeto de conexion
            MiCnn.ListaDeParametros.Add(new SqlParameter("@VerActivos", true));

            R = MiCnn.EjecutarSELECT("SPUsuariosListar");

            return R;
        }

        public DataTable ListarInactivos()
        {
            DataTable R = new DataTable();

            return R;
        }

        public Usuario ValidarUsuario(string pEmail, string pContrasenia)
        {
            Usuario R = new Usuario();

            return R;

        }
    }
}
