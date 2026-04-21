using System;
using System.Collections.Generic;
using System.Text;

namespace CapaNegocio
{
     public class Producto
    {
        public int Id { get; set; }
        public string producto { get; set; }
        public string categoria { get; set; }
        public string proveedor { get; set; }
        public string imagen { get; set; }
        public int cantidad { get; set; }
        public decimal precio_de_compra { get; set; }
        public decimal precio_de_venta { get; set; }


    }
}
