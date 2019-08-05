using System;
using System.Diagnostics;
using System.Text;

namespace StringVsStringbuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Benchmark(DoStringBuilder, 100000);
            Benchmark(DoString, 100000);
            Console.WriteLine("---");
            Benchmark(DoStringBuilder, 110000);
            Benchmark(DoString, 110000);
            Console.WriteLine("---");
            Benchmark(DoStringBuilder, 120000);
            Benchmark(DoString, 120000);
            Console.WriteLine("---");
            Benchmark(DoStringBuilder, 130000);
            Benchmark(DoString, 130000);
            Console.WriteLine("---");
            Benchmark(DoStringBuilder, 140000);
            Benchmark(DoString, 140000);
            Console.WriteLine("---");
            Benchmark(DoStringBuilder, 150000);
            Benchmark(DoString, 150000);
            Console.WriteLine("---");
            Benchmark(DoStringBuilder, 200000);
            Benchmark(DoString, 200000);
            Console.WriteLine("---");
            Benchmark(DoStringBuilder, 300000);
            Benchmark(DoString, 300000);
            Console.ReadKey();
        }

        private static void Benchmark(Action<int> action, int loop)
        {
            var sw = Stopwatch.StartNew();
            action(loop);
            sw.Stop();
            Console.WriteLine($"{action.Method.Name} ran {loop} times and took {sw.ElapsedTicks} ticks");
        }

        private static void DoString(int loop)
        {
            string str = "a";
            for (var i = 0; i < loop; i++)
            {
                str += "a";
            }
        }

        private static void DoStringBuilder(int loop)
        {
            var sb = new StringBuilder("a");
            for (var i = 0; i < loop; i++)
            {
                sb.Append("a");
            }
        }
    }
}
