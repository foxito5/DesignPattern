namespace DP.Excercises.Behavioral.Strategy.Math
{
    internal class Division : IMathOperation
    {
        public void Execute(int n1, int n2)
        {
            System.Console.WriteLine($"Division de {n1} con {n2} es {n1/n2}" );
        }
    }
}