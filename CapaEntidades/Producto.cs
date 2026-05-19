using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
    public class Producto
    {
     
        public string producto { get; set; }
        public string categoria { get; set; }
        public string proveedor { get; set; }
        public int cantidad { get; set; }
        public decimal precio_de_compra { get; set; }
        public decimal precio_de_venta { get; set; }
        public string imagen { get; set; }
        



    }
}
