namespace DotNetSortAlgorithmBenchmark
{
    using System.Collections.Generic;

    interface ISortImplementation
    {
        void SetCollection(IEnumerable<int> collection);
        void Sort();
    }
}