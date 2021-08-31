using System;

namespace DP.Excercises.Behavioral.Strategy.Math
{
    public class RunStrategyMath
    {
        public static void Execute()
        {
            MathContext ctx = new MathContext(10,20) ;

            ctx.SetMathOperation(new Suma());
            ctx.ExecuteOperation();

            ctx.SetMathOperation(new Resta());
            ctx.ExecuteOperation();

            ctx.SetMathOperation(new Division());
            ctx.ExecuteOperation();
            
            ctx.SetMathOperation(new Multiplicacion());
            ctx.ExecuteOperation();

        }
    }
}