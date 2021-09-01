using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Excercises.Behavioral.Strategy.MathFunc
{
    class RunStrategyMathFunc
    {

        public static void Execute()
        {
            // Strategy usando funciones en lugar de clases
            var ctx = new MathFuncContext(10, 20);
            
            Action<int, int> Suma = (x, y) => Console.WriteLine($" La suma de {x} y {y} el total es:{x + y}")  ;
            Action<int, int> Resta = (x, y) => Console.WriteLine($" La Resta de {x} y {y} el total es:{x - y}")  ;
            Action<int, int> Multiplicacion = (x, y) => Console.WriteLine($" La Multiplicacion de {x} y {y} el total es:{x * y}")  ;

            ctx.ExecuteOperation(Suma);
            ctx.ExecuteOperation(Resta);
            ctx.ExecuteOperation(Multiplicacion);

        }
    }
}
