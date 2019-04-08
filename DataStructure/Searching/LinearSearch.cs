using System;
using System.Collections.Generic;
using System.Text;

namespace Searching
{
    public class LinearSearch
    {
        public static int Search(int[] arr, int item)
        {
            for (var i = 0; i < arr.Length; i++)
            {
                if (arr[i] == item)
                    return i;
            }
            return -1;
        }
    }
}

// Time complexity of Linear search algorithm is O(n)


/*
 *  Complexity of algorithm
 *
    Complexity	    Best Case	    Average Case	    Worst Case
    Time	        O(1)	        O(n)	            O(n)
    Space			                                    O(1)

 * */
