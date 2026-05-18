using System;
using System.Collections.Generic;
using System.Text;


namespace CapaComun
{
    public class Proveedor
    {
        public string Nombre { get; set; }
        public int cuit { get; set; }
        public string direccion { get; set; }
        public string correo { get; set; }
        public int telefono_fijo { get; set; }
        public int telefono_celular { get; set; }
        public string categoria { get; set; }
        public string web { get; set; }
        public string catalogo { get; set; }
    }
}
