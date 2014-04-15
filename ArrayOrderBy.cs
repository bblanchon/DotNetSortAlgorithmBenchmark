namespace DotNetSortAlgorithmBenchmark
{
    using System.Collections.Generic;
    using System.Linq;

    class ArrayOrderBy : ISortImplementation
    {
        int[] array;

        public void SetCollection(IEnumerable<int> collection)
        {
            array = collection.ToArray();
        }

        public void Sort()
        {
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            array.OrderBy(x => x).Count();
        }
    }
}