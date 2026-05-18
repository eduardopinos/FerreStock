using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
    public class Proveedor
    {
        public int id {  get; set; }
        public string nombre { get; set; }
        public float cuit { get; set; }
        public string direccion { get; set; }
        public string correo { get; set; }
        public long telefono { get; set; }
        public string categoria { get; set; }
        public string web { get; set; }
        public string catalogo { get; set; }
    }
}
