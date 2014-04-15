namespace DotNetSortAlgorithmBenchmark
{
    using System.Collections.Generic;
    using System.Linq;

    class ListSort : ISortImplementation
    {
        List<int> list;

        public void SetCollection(IEnumerable<int> collection)
        {
            list = collection.ToList();
        }

        public void Sort()
        {
            list.Sort();
        }
    }
}