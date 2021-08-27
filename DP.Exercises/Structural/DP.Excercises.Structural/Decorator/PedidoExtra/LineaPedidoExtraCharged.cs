using DP.Exercises.Core.Modelos;

namespace DP.Excercises.Structural.Decorator.PedidoExtra
{
    public class LineaPedidoExtraCharged : LineaPedidoExtraDecorator
    {
        public LineaPedidoExtraCharged(ILineaPedido itemPedido, Producto productoExtra) : base(itemPedido, productoExtra)
        {
            this.Aplicar();
        }
    }
}