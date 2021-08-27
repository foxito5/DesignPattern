using System.Collections.Generic;
using DP.Exercises.Core.Modelos;

namespace DP.Excercises.Structural.Decorator.PedidoExtra
{
    // Contrete of Component
    public class LineaPedido : ILineaPedido
    {
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public List<Producto> Extras { get; set; }


        public LineaPedido(Producto producto)
        {
            Descripcion = producto.Descripcion;
            Precio = producto.Precio;
        }
    }
}