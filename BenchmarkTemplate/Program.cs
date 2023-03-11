using BenchmarkDotNet.Running;

namespace BenchmarkTemplate
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            BenchmarkRunner.Run<Bench>();

            while (true) { }
        }
    }
}