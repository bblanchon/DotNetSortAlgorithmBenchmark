namespace DotNetSortAlgorithmBenchmark
{
    using System.Collections.Generic;
    using System.Linq;

    class ListOrderBy : ISortImplementation
    {
        List<int> list;

        public void SetCollection(IEnumerable<int> collection)
        {
            list = collection.ToList();
        }

        public void Sort()
        {
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            list.OrderBy(x => x).Count();
        }
    }
}