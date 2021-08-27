using System.Collections.Generic;
using DP.Exercises.Core.Modelos;

namespace DP.Excercises.Structural.Decorator.PedidoExtra
{
    public abstract class LineaPedidoExtraDecorator : ILineaPedido
    {

        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public List<Producto> Extras { get; set; } 

        protected Producto ProductoExtra;
        private ILineaPedido ItemPedido { get; set; }

        public LineaPedidoExtraDecorator(ILineaPedido itemPedido, Producto productoExtra)
        {
            ItemPedido = itemPedido;
            ProductoExtra = productoExtra;
            Descripcion = itemPedido.Descripcion;
            Precio = itemPedido.Precio;
            Extras = itemPedido.Extras ??  new List<Producto>() ;
        }

        internal void Aplicar()
        {
            Precio += ProductoExtra.Precio;
            Extras.Add(ProductoExtra);
        }
    }
}