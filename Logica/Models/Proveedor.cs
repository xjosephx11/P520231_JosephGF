using Logica.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Proveedor
    {
        public int ProveedorID { get; set; }
        public string ProveedorNombre { get; set; }
        public string ProveedorCedula { get; set; }
        public string ProveedorEmail { get; set; }
        public string ProveedorDireccion { get; set; }
        public string ProveedorNotas { get; set; }
        public bool Activo { get; set; }


        public bool Agregar()
        {
            bool R = false;

            Conexion Micnn = new Conexion();
            Micnn.ListaDeParametros.Add(new SqlParameter("@Nombre",this.ProveedorNombre));
            Micnn.ListaDeParametros.Add(new SqlParameter("@Cedula", this.ProveedorCedula));
            Micnn.ListaDeParametros.Add(new SqlParameter("@Email", this.ProveedorEmail));
            Micnn.ListaDeParametros.Add(new SqlParameter("@Direccion", this.ProveedorDireccion));
            Micnn.ListaDeParametros.Add(new SqlParameter("@Notas", this.ProveedorNotas));
            Micnn.ListaDeParametros.Add(new SqlParameter("@TipoID", this.MiTipoProveedor.ProveedorTipoID));

            int resultado = Micnn.EjecutarInsertUpdateDelete("SPProveedorAgregar");
            if (resultado > 0) 
            {
                R = true;
            }

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

        public bool ConsultarPorCedula()
        {
            bool R = false;

            Conexion Micnn = new Conexion();
            Micnn.ListaDeParametros.Add(new SqlParameter("@Cedula", this.ProveedorCedula));
            DataTable consulta = new DataTable();
            consulta = Micnn.EjecutarSELECT("SPProveedorConsultarPorCedula");

            if (consulta != null && consulta.Rows.Count > 0)
            {
                R = true;
            }
            return R;
        }

        public bool ConsultarPorEmail()
        {
            bool R = false;
            Conexion Micnn = new Conexion();
            Micnn.ListaDeParametros.Add(new SqlParameter("@Email", this.ProveedorEmail));
            DataTable consulta = new DataTable();
            consulta = Micnn.EjecutarSELECT("SPProveedorConsultarPorEmail");

            if (consulta != null && consulta.Rows.Count > 0)
            {
                R = true;
            }
            return R;
        }

        public bool ConsultarPorID() 
        {
            bool R = false;

            return R;
        }

        public Proveedor ConsultarPorIDRetornaProveedor()
        {
            Proveedor r = new Proveedor();

            Conexion Micnn = new Conexion();
            Micnn.ListaDeParametros.Add(new SqlParameter("@ID",this.ProveedorID));

            DataTable dt = new DataTable();
            dt = Micnn.EjecutarSELECT("SPProveedorConsultarPorID");

            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                r.ProveedorID = Convert.ToInt32(dr["ProveedorID"]);
                r.ProveedorNombre = Convert.ToString(dr["ProveedorNombre"]);
                r.ProveedorCedula = Convert.ToString(dr["ProveedorCedula"]);
                r.ProveedorEmail = Convert.ToString(dr["ProveedorEmail"]);
                r.ProveedorNotas = Convert.ToString(dr["ProveedorNotas"]);
                r.ProveedorDireccion = Convert.ToString(dr["ProveedorDireccion"]);

                r.MiTipoProveedor.ProveedorTipoID = Convert.ToInt32(dr["ProveedorTipoID"]);
                r.MiTipoProveedor.ProveedorTipoDescripcion = Convert.ToString(dr["ProveedorTipoDescripcion"]);

            }

            return r;
        }

        public DataTable ListarActivos()
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();
            MiCnn.ListaDeParametros.Add(new SqlParameter("@VerActivos", true));
            R = MiCnn.EjecutarSELECT("SPProveedorListarExamen");
            return R;
        }

        public DataTable ListarInactivos()
        {
            DataTable R = new DataTable();

            

            return R;
        }

        public DataTable Listar(bool verActivos = true, string  FiltroBusqueda = "") 
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@VerActivos", verActivos));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@FiltroBusqueda", FiltroBusqueda));

            R = MiCnn.EjecutarSELECT("SPProveedorListar");

            return R;
        }


        public TipoProveedor MiTipoProveedor { get; set; }
       

        public Proveedor()
        {
            MiTipoProveedor = new TipoProveedor();
        }


    }
}
