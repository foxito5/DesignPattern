using System;
using System.Collections.Generic;
using DP.Exercises.Core.Modelos;

namespace DP.Excercises.Structural.Decorator.PedidoExtra
{

    // Component
    public interface ILineaPedido
    {
        public String Descripcion { get; set; }
        public decimal Precio { get; set; }
        public List<Producto> Extras { get; set; }
    }
}