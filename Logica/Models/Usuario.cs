﻿using Logica.Services;
using System;
using System.Data;

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

            //pasos 1.6.1 y 1.6.2
            Conexion MiCnn = new Conexion();
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Correo",this.UsuarioCorreo));
            //todo. encrriptar la contrasenia
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Contrasennia", this.UsuarioContrasenia));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Nombre", this.UsuarioNombre));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Cedula", this.UsuarioCedula));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Telefono", this.UsuarioTelefono));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Direccion", this.UsuarioDireccion));
            //normalmente los foreign keys tienen que ver con composiciones , en este caso
            //tenemos qie extraer el valor del objeto compuesto MilRolTipo
            MiCnn.ListaDeParametros.Add(new SqlParameter("@IdRol", this.MiRolTipo.UsuarioRolID));


            //pasos 1.6.3 y 1.6.4
            int resultado = MiCnn.EjecutarInsertUpdateDelete("SPUsuarioAgregar");
            //paso 1.6.5
            if (resultado > 0) 
            {
                R = true;
            }

            return R;
        }

        public bool Editar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Correo", this.UsuarioCorreo));
            //todo. encrriptar la contrasenia
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Contrasennia", this.UsuarioContrasenia));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Nombre", this.UsuarioNombre));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Cedula", this.UsuarioCedula));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Telefono", this.UsuarioTelefono));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Direccion", this.UsuarioDireccion));
            //normalmente los foreign keys tienen que ver con composiciones , en este caso
            //tenemos qie extraer el valor del objeto compuesto MilRolTipo
            MiCnn.ListaDeParametros.Add(new SqlParameter("@IdRol", this.MiRolTipo.UsuarioRolID));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.UsuarioID));


            int resultado = MiCnn.EjecutarInsertUpdateDelete("SPUsuarioModificar");
            
            if (resultado > 0)
            {
                R = true;
            }

            return R;
        }

        public bool Eliminar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();


            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.UsuarioID));
            int respuesta = MiCnn.EjecutarInsertUpdateDelete("SPUsuarioDesactivar");

            if (respuesta > 0)
            {
                R = true;
            }

            return R;
        }

        public bool ConsultarPorID()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.UsuarioID));

            //necesito un datatable para capturar la info del usuario
            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSELECT("SPUsuarioConsultarPorID");

            if (dt != null && dt.Rows.Count > 0)
            {
                
                R = true;

            }

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

            //paso 1.3.1 y 1.3.2
            Conexion MiCnn = new Conexion();
            //agregamos el parametro de cedula
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Cedula", this.UsuarioCedula));
            DataTable consulta = new DataTable();
            //paso 1.3.3 y 1.3.4
            consulta = MiCnn.EjecutarSELECT("SPUsuarioConsultarPorCedula");
            //paso 1.3.5
            if (consulta != null && consulta.Rows.Count > 0)//si consulta no es nulo, que tenga 1 o mas filas
            {
                R = true;
            }


            return R;
        }

        public bool ConsultarPorEmail()
        {
            bool R = false;

            //paso 1.4.1 y 1.4.2
            Conexion MiCnn = new Conexion();
            //agregamos el parametro de correo
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Correo", this.UsuarioCorreo));
            DataTable consulta = new DataTable();
            //paso 1.4.3 y 1.4.4
            consulta = MiCnn.EjecutarSELECT("SPUsuarioConsultarPorEmail");
            //paso 1.4.5
            if (consulta != null && consulta.Rows.Count > 0)//si consulta no es nulo, que tenga 1 o mas filas
            {
                R = true;
            }

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
