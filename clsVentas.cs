using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemasDeVentas
{
    public class clsVentas
    {
        public string Vendedor { get; set; }

        public string Producto { get; set; }

        public double Precio { get; set; }

        public int Cantidad { get; set; }

        public double Total { get; set; }
    }

    public class clsProductos
    {
        public string Producto { get; set; }
        public double Precio { get; set; }

    }
}
