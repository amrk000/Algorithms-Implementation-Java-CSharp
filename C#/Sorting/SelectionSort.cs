using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Selection Sort Algorithm Implementation | From Repo: https://github.com/amrk000/Algorithms-Implementation-Java-CSharp
//by Amrk000 - No license or attribution required

//Algorithm that sorts array using selection approach
//>Runtime Complexity: O(n^2)
public static class SelectionSort
{
    //sort integer array
    public static void sort(int[] array)
    {
        //loop over array elements
        for (int i = 0; i < array.Length - 1; i++)
        {
            int minIndex = i; //guess that minimum element in array index is i

            //loop all element after i to find the minimum element
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[minIndex]) minIndex = j; //if element found smaller than i holt its index
            }

            //swap minimum element with element at i
            int temp = array[minIndex];
            array[minIndex] = array[i];
            array[i] = temp;
        }
    }

    //sort generic array
    public static void Sort<T>(T[] array, Comparer<T> comparer)
    {
        //loop over array elements
        for (int i = 0; i < array.Length - 1; i++)
        {
            int minIndex = i; //guess that minimum element in array index is i

            //loop all element after i to find the minimum element
            for (int j = i + 1; j < array.Length; j++)
            {
                if (comparer.Compare(array[j], array[minIndex]) < 0) minIndex = j; //if element found smaller than i holt its index
            }

            //swap minimum element with element at i
            T temp = array[minIndex];
            array[minIndex] = array[i];
            array[i] = temp;
        }
    }
}
