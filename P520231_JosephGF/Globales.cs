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


    }
}
