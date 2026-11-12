using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickSort
{
    
    public static class QuickSort
    {

        public static int OperationCount = 0;
        public static int SwapCount = 0;
        public static void Sort<T>(T[] array) where T : IComparable
        {
            
        }

        public static void Swap<T>(T[] array, int first, int second)
        {
            SwapCount++;
            T temp = array[first];
            array[first] = array[second];
            array[second] = temp;
        }

    }
}

