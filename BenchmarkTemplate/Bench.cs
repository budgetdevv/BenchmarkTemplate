using System.Runtime.CompilerServices;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace BenchmarkTemplate
{
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [DisassemblyDiagnoser(exportDiff: true, exportCombinedDisassemblyReport: true)]
    public class Bench
    {
        [ModuleInitializer]
        public static void RunCctor()
        {
            RuntimeHelpers.RunClassConstructor(typeof(Bench).TypeHandle);
        }

        static Bench()
        {
            
        }

        [Benchmark]
        public void Foo()
        {
            
        }
    }
}