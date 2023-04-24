using Logica.Models;
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
    public partial class FrmRegistroCompra : Form
    {
        public Compra MiCompraLocal { get; set; }

        public DataTable ListaProductos { get; set; }




        public FrmRegistroCompra()
        {
            InitializeComponent();

            MiCompraLocal = new Compra();
            ListaProductos = new DataTable();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnProveedorBuscar_Click(object sender, EventArgs e)
        {
            //se abre un nuevo formulario de busqueda de proveedor
            //este formulario no es necesario definirlo en los globales (aunque es posible)
            Form FormBusquedaProveedor = new FrmProveedorBuscar();

            DialogResult  respuesta = FormBusquedaProveedor.ShowDialog();

            if (respuesta == DialogResult.OK)
            {
                //las composisiones a proveedor para extraer el valor del nombre del proveedor
                TxtProveedorNombre.Text = MiCompraLocal.MiProveedor.ProveedorNombre;

            }
        }

        private void TxtProveedorNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void CboxCompraTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void FrmRegistroCompra_Load(object sender, EventArgs e)
        {
            MdiParent = Globales.MiFormPrincipal;
            CargarTiposDeCompra();
            LimpiarForm();

        }

        private void CargarTiposDeCompra() 
        {
            DataTable dtTiposCompra = new DataTable();

            dtTiposCompra = MiCompraLocal.MiTipoCompra.Listar();

            CboxCompraTipo.ValueMember = "ID";
            CboxCompraTipo.DisplayMember = "Descripcion";

            CboxCompraTipo.DataSource = dtTiposCompra;

            CboxCompraTipo.SelectedIndex = -1;

        }

        private void LimpiarForm() 
        {
            TxtProveedorNombre.Clear();
            TxtNotas.Clear();
            TxtTotal.Text = "0";
            TxtTotalCantidad.Text = "0";
            CboxCompraTipo.SelectedIndex = -1;

            ListaProductos = new DataTable();

            ListaProductos = MiCompraLocal.CargarEsquemaDetalle();
            DgvLista.DataSource = ListaProductos;
        }

        private void BtnProductoAgregar_Click(object sender, EventArgs e)
        {
            Form MiFormBusquedaItem = new FrmCompraAgregarProducto();

            DialogResult respuesta = MiFormBusquedaItem.ShowDialog();

            if (respuesta == DialogResult.OK)
            {
                DgvLista.DataSource = ListaProductos;
                Totalizar();
            }
        }


        private void Totalizar() 
        {
            if (ListaProductos.Rows.Count > 0)
            {
                decimal totalItems = 0;
                decimal monto = 0;

                foreach (DataRow row in ListaProductos.Rows)
                {
                    totalItems += Convert.ToDecimal(row["Cantidad"]);
                    monto += Convert.ToDecimal(row["PrecioVentaUnitario"]) * Convert.ToDecimal(row["Cantidad"]);

                }

                TxtTotalCantidad.Text = totalItems.ToString();

                TxtTotal.Text = string.Format("{0:C2}",monto);
            }
        }

        private void BtnCrearCompra_Click(object sender, EventArgs e)
        {
            if (ValidarCompra())
            {
                MiCompraLocal.MiTipoCompra.CompraTipoID = Convert.ToInt32(CboxCompraTipo.SelectedValue);
                MiCompraLocal.CompraNotas = TxtNotas.Text.Trim();
                MiCompraLocal.MiUsuario.UsuarioID = 2;
                TrasladoDetalleListaVisualAObjetoCompra();
                if (MiCompraLocal.Agregar())
                {
                    MessageBox.Show("Compra realizada correctamente", "Muy bien!",MessageBoxButtons.OK);
                    //crear un reporte de la compra
                    LimpiarForm();
                    
                }
            }
        }

        private void TrasladoDetalleListaVisualAObjetoCompra() 
        {
            foreach (DataRow fila in ListaProductos.Rows)
            {
                CompraDetalle nuevoDetalle = new CompraDetalle();
                nuevoDetalle.MiProducto.ProductoID = Convert.ToInt32(fila["ProductoID"]);
                nuevoDetalle.Cantidad = Convert.ToDecimal(fila["Cantidad"]);
                nuevoDetalle.PrecioUnitario = Convert.ToDecimal(fila["PrecioVentaUnitario"]);

                MiCompraLocal.ListaDetalles.Add(nuevoDetalle);
                
            }
        }

        private bool ValidarCompra() 
        {
            bool r = false;

            if (!string.IsNullOrEmpty(TxtProveedorNombre.Text.Trim()) &&
                CboxCompraTipo.SelectedIndex >= 0 &&
                ListaProductos.Rows.Count > 0)
            {
                r = true;
            }
            else 
            {
                if (string.IsNullOrEmpty(TxtProveedorNombre.Text.Trim()))
                {
                    MessageBox.Show("Se debe seleccionar un proveedor", "Error  de validacion", MessageBoxButtons.OK);
                    return false;
                }
                if (CboxCompraTipo.SelectedIndex == -1)
                {
                    MessageBox.Show("Se debe seleccionar un tipo de compra", "Error  de validacion", MessageBoxButtons.OK);
                    return false;
                }
                if (ListaProductos.Rows.Count == 0)
                {
                    MessageBox.Show("Debe haber almenos una fila en el detalle", "Error  de validacion", MessageBoxButtons.OK);
                    return false;
                }

            }

            return r;
        }
    }
}
