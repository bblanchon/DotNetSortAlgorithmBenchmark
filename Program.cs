namespace DotNetSortAlgorithmBenchmark
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;

    class Program
    {
        static readonly Random random = new Random();

        static void Main()
        {
            int[] counts = { 1, 10, 100, 1000, 10000, 100000, 1000000, 10000000 };
            var csv = new CsvWriter(Console.Out);
            var algos = new ISortImplementation[]
            {
                new ArraySort(),
                new ListSort(), 
                new ArrayOrderBy(), 
                new ListOrderBy(), 
            };

            foreach (var count in counts)
            {
                csv.Append(count);

                foreach (var algo in algos)
                {
                    var micros = RunTest(count, algo) * 1000;
                    csv.Append(micros);
                }

                csv.AppendLine();
            }
        }

        static double RunTest(int collectionSize, ISortImplementation algo)
        {
            var iterationCount = 0;
            var minElapsedTime = TimeSpan.FromSeconds(2);
            var chrono = new Stopwatch();
            Debug.Assert(Stopwatch.IsHighResolution);

            algo.SetCollection(GenerateRandomInts(collectionSize));
            
            do
            {
                chrono.Start();
                algo.Sort();
                chrono.Stop();
                iterationCount++;
            }
            while (chrono.Elapsed < minElapsedTime);

            return chrono.Elapsed.TotalMilliseconds / iterationCount;
        }

        static IEnumerable<int> GenerateRandomInts(int count)
        {
            for (var i = 0; i < count; i++)
            {
                yield return random.Next();
            }
        }
    }
}
