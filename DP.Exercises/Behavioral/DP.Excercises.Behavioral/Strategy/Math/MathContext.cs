namespace DP.Excercises.Behavioral.Strategy.Math
{
    internal class MathContext
    {
        private readonly int n1;
        private readonly int n2;
        private IMathOperation _mathOperation;

        public MathContext(int n1, int n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }

        public void SetMathOperation(IMathOperation mathOperation)
        {
            _mathOperation = mathOperation;
        }

        public void ExecuteOperation()
        {
            _mathOperation.Execute(n1, n2);
        }

    }
}