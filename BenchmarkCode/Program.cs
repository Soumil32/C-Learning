using System.Text;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using MoreTypeExtensions;

namespace BenchmarkCode
{
    [MemoryDiagnoser()]
    [RankColumn]
    public class CodeToBenchmark
    {
        List<int> intList = new List<int>() {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        static void Main()
        {
            var summary = BenchmarkRunner.Run<CodeToBenchmark>();
        }

        [Benchmark]
        public void ForEach()
        {
            foreach (int integer in intList)
            {
                Console.WriteLine(integer);
            }
        }
        
        [Benchmark]
        public void ForEachWithExtension()
        {
            intList.ForEach(p => Console.WriteLine(p));
        }
    }
}