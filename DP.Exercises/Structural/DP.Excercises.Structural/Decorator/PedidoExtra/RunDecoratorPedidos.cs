using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DP.Exercises.Core.Modelos;

namespace DP.Excercises.Structural.Decorator.PedidoExtra
{
    class RunDecoratorPedidos
    {
        static Producto Mocha = new Producto() { Descripcion = "Mochachino", Precio = 12.20M };
        static Producto MochaChoco = new Producto() { Descripcion = "Mochachino Chocolate", Precio = 15.5M };

        static Producto LecheEntera = new Producto() { Descripcion = "Leche Entera", Precio = 5M };
        static Producto LecheDescremada = new Producto() { Descripcion = "Leche Descremada", Precio = 7M };
        static Producto Saborizante = new Producto() { Descripcion = "Saborizante", Precio = 6.5M };


        static Producto Agrandado = new Producto() { Descripcion = "Agrandado", Precio = 10M };



        public static void Execute()
        {
            List<ILineaPedido> items = new List<ILineaPedido>();

            var linea = new LineaPedido(Mocha);

            ILineaPedido lineaExtra = new LineaPedidoExtraCharged(linea, LecheEntera);
            items.Add(lineaExtra);

            //var item2 = new LineaPedido(MochaChoco);
            //items.Add(new LineaPedidoExtraUncharged(new LineaPedidoExtraCharged(item2, Agrandado), LecheDescremada));


            var item3 = new LineaPedido(Mocha);
            var lineaExtra2 =

                 new LineaPedidoExtraCharged(
                     new LineaPedidoExtraCharged(
                         new LineaPedidoExtraUncharged(item3, Agrandado)
                 , LecheDescremada)
                     , Saborizante);

            items.Add(lineaExtra2);


            var i = 0;
            foreach (var item in items)
            {
                Console.WriteLine($" #{++i} {item.Descripcion}  {item.Precio} ");

                if (null != item?.Extras)
                    foreach (var extra in item?.Extras) Console.WriteLine($"**** {extra.Descripcion}  {extra.Precio}");
            }

            Console.WriteLine("Example decorator pedidos");
        }
    }
}
