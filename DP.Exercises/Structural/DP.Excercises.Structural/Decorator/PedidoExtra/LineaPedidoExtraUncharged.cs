using DP.Exercises.Core.Modelos;

namespace DP.Excercises.Structural.Decorator.PedidoExtra
{
    public class LineaPedidoExtraUncharged : LineaPedidoExtraDecorator
    {
        public LineaPedidoExtraUncharged(ILineaPedido itemPedido, Producto productoExtra) : base(itemPedido, productoExtra)
        {
            this.ProductoExtra.Precio = 0;
            this.Aplicar();
        }
    }
}