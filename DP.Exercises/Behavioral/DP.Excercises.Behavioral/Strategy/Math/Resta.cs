namespace DP.Excercises.Behavioral.Strategy.Math
{
    internal class Resta : IMathOperation
    {
        public void Execute(int n1, int n2)
        {
            System.Console.WriteLine($"Resta de {n1} con {n2} es {n1 - n2}");
        }
    }
}