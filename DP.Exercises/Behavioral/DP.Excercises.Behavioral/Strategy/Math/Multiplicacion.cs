namespace DP.Excercises.Behavioral.Strategy.Math
{
    internal class Multiplicacion : IMathOperation
    {
        public void Execute(int n1, int n2)
        {
            System.Console.WriteLine($"multiplicacion de {n1} con {n2} es {n1 * n2}");
        }
    }
}