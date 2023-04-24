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
    public class Compra
    {
        public int CompraID { get; set; }
        public DateTime CompraFecha { get; set; }
        public int CompraNumero { get; set; }
        public string CompraNotas { get; set; }
        public bool Activo { get; set; }

        //composiciones simples
        public Usuario MiUsuario { get; set; }
        public Proveedor MiProveedor { get; set; }
        public TipoCompra MiTipoCompra { get; set; }

        //compsosicion en lista o complejas
        public List<CompraDetalle> ListaDetalles { get; set; }

        //constructor
        public Compra() 
        {
            MiUsuario = new Usuario();
            MiProveedor = new Proveedor();
            MiTipoCompra = new TipoCompra();
            ListaDetalles = new List<CompraDetalle>();

        }

        //funciones
        public DataTable CargarEsquemaDetalle() 
        {
            DataTable r = new DataTable();

            Conexion MiCnn = new Conexion();

            r = MiCnn.EjecutarSELECT("SPCompraDetalleEsquema", true);

            r.PrimaryKey = null;

            return r;
        }

        public bool Agregar() 
        {
            bool r = false;
            Conexion Micnn = new Conexion();
            Micnn.ListaDeParametros.Add(new SqlParameter("IDPRoveedor",this.MiProveedor.ProveedorID));
            Micnn.ListaDeParametros.Add(new SqlParameter("IDTIpoCompra", this.MiTipoCompra.CompraTipoID));
            Micnn.ListaDeParametros.Add(new SqlParameter("IDUsuario", this.MiUsuario.UsuarioID));
            Micnn.ListaDeParametros.Add(new SqlParameter("@Notas", this.CompraNotas));

            Object retorno = Micnn.EjecutarSELECTEscalar("SPCompraAgregar");

            int Idcreada;

            if (retorno != null)
            {
                try
                {
                    Idcreada = Convert.ToInt32(retorno.ToString());
                    this.CompraID = Idcreada;
                    foreach (CompraDetalle item in this.ListaDetalles)
                    {
                        Conexion MiCnnDetalle = new Conexion();
                        MiCnnDetalle.ListaDeParametros.Add(new SqlParameter("@IDCompra", Idcreada));
                        MiCnnDetalle.ListaDeParametros.Add(new SqlParameter("@IDProducto", item.MiProducto.ProductoID));
                        MiCnnDetalle.ListaDeParametros.Add(new SqlParameter("@Cantidad", item.Cantidad));
                        MiCnnDetalle.ListaDeParametros.Add(new SqlParameter("@Precio", item.PrecioUnitario));

                        MiCnnDetalle.EjecutarInsertUpdateDelete("SPCompraDetalleAgregar");

                    }
                    r = true;
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return r;
        }







    }
}
