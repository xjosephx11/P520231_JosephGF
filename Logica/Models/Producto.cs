﻿using Logica.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Producto
    {
        public int ProductoID { get; set; }
        public string ProductoNombre { get; set; }
        public string ProductoCodigoBarras { get; set; }
        public decimal CantidadStock { get; set; }
        public decimal CostoUnitario { get; set; }
        public decimal PrecioVentaUnitario { get; set; }
        public bool Activo { get; set; }



        public bool Agregar()
        {
            throw new System.Exception("Not implemented");
        }
        public bool Editar()
        {
            throw new System.Exception("Not implemented");
        }
        public bool Eliminar()
        {
            throw new System.Exception("Not implemented");
        }
        public bool ConsultarPorCodigoDeBarras(ref string codigoBarras)
        {
            throw new System.Exception("Not implemented");
        }
        public DataTable ListarActivos()
        {
            throw new System.Exception("Not implemented");
        }
        public DataTable ListarInactivos()
        {
            throw new System.Exception("Not implemented");
        }

        //nueva funcion para mostrar la lista de  items en la ventana
        //de busquedade productos
        public DataTable ListarEnBusqueda()
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();
            R = MiCnn.EjecutarSELECT("SPProductoBusquedaListar");
            //Conexion MiCnn = new Conexion();

            //R = MiCnn.EjecutarSELECT("SPProductoBusquedaListar");

            return R;
        }

        public CategoriaProducto MiCategoria { get; set; }

        public Producto()
        {
            MiCategoria = new CategoriaProducto();
        }
    }
}
