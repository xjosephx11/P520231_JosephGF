using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P520231_JosephGF
{
    public static class Globales
    {
        //estas propiedades al pertenecer a una clase static se auto instancian
        //y se puede obtener aceso a ellas en la globalidad de la palicacion.
        public static Form MiFormPrincipal = new Formularios.FrmMDI();

        public static Formularios.FrmUsuariosGestion MiFormGestionUsuarios
            = new Formularios.FrmUsuariosGestion();

        public static Logica.Models.Usuario MiUsuarioGlobal = new Logica.Models.Usuario();

        public static Formularios.FrmRegistroCompra MiFormRegistroCompra = new Formularios.FrmRegistroCompra();

        public static Formularios.FrmProveedorGestion MiFromGestionProveedor
            = new Formularios.FrmProveedorGestion();

    }
}
