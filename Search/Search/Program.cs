using System;
using System.Collections.Generic;
using System.Linq;

namespace Search
{
    class Program
    {
        static void Main(String[] args)
        {
            var binarySearch = new BinarySearch();
            binarySearch.Example();

            var indexedSequentialSearch = new IndexedSequentialSearch();
            indexedSequentialSearch.Example();

            var sequentialSearch = new SequentialSearch();
            sequentialSearch.Example();

        }

    }
}
