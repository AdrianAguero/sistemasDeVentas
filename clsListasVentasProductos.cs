using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemasDeVentas
{
    internal class clsListasVentasProductos
    {
        public static class clsListaVentas
        {
            //creo una lista de tipo clase donde voy a guardar las ventas realizadas
            public static List<clsVentas> ventas = new List<clsVentas>();

           

        }
        public static class clsListaProducos
        {
            public static List<clsProductos> Productos = new List<clsProductos>();
        }

    }
  
}
