namespace DotNetSortAlgorithmBenchmark
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class ArraySort : ISortImplementation
    {
        int[] array;

        public void SetCollection(IEnumerable<int> collection)
        {
            array = collection.ToArray();
        }

        public void Sort()
        {
            Array.Sort(array);
        }
    }
}