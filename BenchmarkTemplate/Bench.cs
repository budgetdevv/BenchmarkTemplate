using System.Runtime.CompilerServices;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
#if OS_IS_WINDOWS
using BenchmarkDotNet.Diagnostics.Windows.Configs;
#endif

namespace BenchmarkTemplate
{
    [MemoryDiagnoser]
    #if OS_IS_WINDOWS
    [NativeMemoryProfiler]
    [InliningDiagnoser(logFailuresOnly: true, filterByNamespace: true)]
    [DisassemblyDiagnoser(exportDiff: true, exportCombinedDisassemblyReport: true)]
    #endif
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
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