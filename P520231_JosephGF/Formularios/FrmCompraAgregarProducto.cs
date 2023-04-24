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
    public partial class FrmCompraAgregarProducto : Form
    {
        DataTable ListaProductos { get; set; }
        Producto MiProductoLocal { get; set; }

        public FrmCompraAgregarProducto()
        {
            InitializeComponent();
            ListaProductos = new DataTable();
            MiProductoLocal = new Producto();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (DvgLista.SelectedRows.Count == 1)
            {
                DataGridViewRow row = DvgLista.SelectedRows[0];

                int idproducto = Convert.ToInt32(row.Cells["CProductoID"].Value);
                string NombreProducto = Convert.ToString(row.Cells["CProductoNombre"].Value);
                string codigoBarras = Convert.ToString(row.Cells["CProductoCodigoBarras"].Value);
                decimal precio = Convert.ToDecimal(row.Cells["CPrecioVentaUnitario"].Value);
                decimal cantidad = NumUDCantidad.Value;

                DataRow MiFila = Globales.MiFormRegistroCompra.ListaProductos.NewRow();

                MiFila["ProductoID"] = idproducto;
                MiFila["Cantidad"] = cantidad;
                MiFila["PrecioVentaUnitario"] = precio;
                MiFila["ProductoNombre"] = NombreProducto;
                MiFila["ProductoCodigoBarras"] = codigoBarras;

                Globales.MiFormRegistroCompra.ListaProductos.Rows.Add(MiFila);
                DialogResult = DialogResult.OK;

            }

            
        }

        private void FrmCompraAgregarProducto_Load(object sender, EventArgs e)
        {
            LlenarLista();
        }

        private void LlenarLista() 
        {
            ListaProductos = new DataTable();
            ListaProductos = MiProductoLocal.ListarEnBusqueda();

            DvgLista.DataSource = ListaProductos;
            DvgLista.ClearSelection();

        }



    }
}
