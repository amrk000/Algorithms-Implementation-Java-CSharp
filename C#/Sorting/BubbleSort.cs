using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Bubble Sort Algorithm Implementation | From Repo: https://github.com/amrk000/Algorithms-Implementation-Java-CSharp
//by Amrk000 - No license or attribution required

//Algorithm that sorts array using bubble approach
//>Runtime Complexity: O(n^2)
public static class BubbleSort
{

    //sort integer array
    public static void Sort(int[] array)
    {
        //swap every two elements until largest element is moved the end of array then repeats again from start
        for (int i = 0; i < array.Length - 1; i++)
        {

            bool swapped = false; //swap checker

            //loop from start until the bubbled elements in end of array which starts at (arrayEnd-i)
            for (int j = 0; j < array.Length - 1 - i; j++)
            {
                //if current bigger than next swap
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;

                    swapped = true; //swap happened
                }
            }

            if (!swapped) break; //stops algorithm loop as no item is swapped so all items are sorted

        }
    }

    //sort generic array
    public static void Sort<T>(T[] array, Comparer<T> comparer)
    {
        //swap every two elements until largest element is moved the end of array then repeats again from start
        for (int i = 0; i < array.Length - 1; i++)
        {

            bool swapped = false; //swap checker

            //loop from start until the bubbled elements in end of array which starts at (arrayEnd-i)
            for (int j = 0; j < array.Length - 1 - i; j++)
            {
                //if current bigger than next swap
                if (comparer.Compare(array[j], array[j + 1]) > 0)
                {
                    T temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;

                    swapped = true; //swap happened
                }
            }

            if (!swapped) break; //stops algorithm loop as no item is swapped so all items are sorted

        }
    }
}
