using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Quick Sort Algorithm Implementation | From Repo: https://github.com/amrk000/Algorithms-Implementation-Java-CSharp
//by Amrk000 - No license or attribution required

//Algorithm that sorts array using quicksort approach
//>Runtime Complexity: O(nlog(n))
public static class QuickSort
{
    //recursive sort function that split array around pivot into parts where all left items are smaller than pivot and all right items are bigger
    private static void quickSort(int[] array, int low, int high)
    {
        if (low >= high) return; //if low and high meet return
        int pivotIndex = partition(array, low, high); //get sorting pivot and make all left items smaller and all right items bigger
        quickSort(array, low, pivotIndex - 1); //repeat on left half of array
        quickSort(array, pivotIndex, high); //repeat on right half of array
    }

    //function that picks pivot and swap elements around it to make items on left are smaller and right are bigger
    private static int partition(int[] array, int low, int high)
    {
        int midIndex = (low + high) / 2; //mid index
        int pivot = array[midIndex]; //mid pivot value

        //loop that swaps items in left and right side until low meet high to make sure that left items smaller than pivot and right items bigger
        while (low <= high)
        {
            while (array[low] < pivot) low++; //as long as current left item is less than pivot move right
            while (array[high] > pivot) high--; //as long as current right item is bigger than pivot move left

            //here low found item bigger than pivot on left & high found item less than pivot on right
            //if low isn't bigger than high swap item at low with item at high
            if (low <= high)
            {
                int temp = array[low];
                array[low] = array[high];
                array[high] = temp;

                low++; //move low to right
                high--; //move high to left
            }
        }

        return low; //return low value when low and high meet at pivot
    }

    //int array sorting function
    public static void Sort(int[] array)
    {
        quickSort(array, 0, array.Length - 1);
    }


    //Generic sorting
    //recursive sort function that split array around pivot into parts where all left items are smaller than pivot and all right items are bigger
    private static void quickSort<T>(T[] array, int low, int high, Comparer<T> comparer)
    {
        if (low >= high) return; //if low and high meet return
        int pivotIndex = partition(array, low, high, comparer); //get sorting pivot and make all left items smaller and all right items bigger
        quickSort(array, low, pivotIndex - 1, comparer); //repeat on left half of array
        quickSort(array, pivotIndex, high, comparer); //repeat on right half of array
    }

    //function that picks pivot and swap elements around it to make items on left are smaller and right are bigger
    private static int partition<T>(T[] array, int low, int high, Comparer<T> comparer)
    {
        int midIndex = (low + high) / 2; //mid index
        T pivot = array[midIndex]; //mid pivot value

        //loop that swaps items in left and right side until low meet high to make sure that left items smaller than pivot and right items bigger
        while (low <= high)
        {
            while (comparer.Compare(array[low], pivot) < 0) low++; //as long as current left item is less than pivot move right
            while (comparer.Compare(array[high], pivot) > 0) high--; //as long as current right item is bigger than pivot move left

            //here low found item bigger than pivot on left & high found item less than pivot on right
            //if low isn't bigger than high swap item at low with item at high
            if (low <= high)
            {
                T temp = array[low];
                array[low] = array[high];
                array[high] = temp;

                low++; //move low to right
                high--; //move high to left
            }
        }

        return low; //return low value when low and high meet at pivot
    }

    //int array sorting function
    public static void Sort<T>(T[] array, Comparer<T> comparer)
    {
        quickSort(array, 0, array.Length - 1, comparer);
    }

}
