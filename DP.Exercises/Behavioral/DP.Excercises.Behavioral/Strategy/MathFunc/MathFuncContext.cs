using System;

namespace DP.Excercises.Behavioral.Strategy.MathFunc
{
    internal class MathFuncContext
    {
        private int v1;
        private int v2;

        public MathFuncContext(int v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        internal void ExecuteOperation(Action<int, int> operacion)
        {
            operacion(v1, v2);
        }
    }
}