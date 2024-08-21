using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Merge Sort Algorithm Implementation | From Repo: https://github.com/amrk000/Algorithms-Implementation-Java-CSharp
//by Amrk000 - No license or attribution required

//Algorithm that sorts array using merge approach
//>Runtime Complexity: O(nlog(n))
public static class MergeSort
{
    //recursive sort function that keep splitting array by half until reaching sub array of one item
    private static void mergeSort(int[] array, int low, int high)
    {
        if (low >= high) return; //if low and high meet return
        int mid = (high + low) / 2; //mid index
        mergeSort(array, low, mid); //repeat on left half of array
        mergeSort(array, mid + 1, high); //repeat on right half of array
        merge(array, low, high, mid); //apply merge & sort algorithm
    }

    //function that merges & sorts sub arrays
    private static void merge(int[] array, int low, int high, int mid)
    {
        int i = low; //set iterator starts from low (array left half start)
        int j = mid + 1;  //set iterator starts from mid + 1  (array right half start)
        int[] tempArray = new int[high - low + 1]; //create temp array that used to sort the merged arrays

        int k = 0; //temp array index iterator
        //loop i over left sub array and j over right sub array (the array that merged & holds to sub arrays in recursion)
        while (i <= mid && j <= high)
        {
            if (array[i] <= array[j]) tempArray[k] = array[i++]; //if item at i smaller than item at j or equal add i to temp array then increase i
            else tempArray[k] = array[j++];  //if item at j smaller than item at i add i to temp array then increase j
            k++; //increase temp array index iterator
        }

        while (i <= mid) tempArray[k++] = array[i++]; //add all remaining items in left array in temp array

        while (j <= high) tempArray[k++] = array[j++]; //add all remaining items in right array in temp array

        //copy temp array to merged array starting from low index so it become sorted
        i = low;
        for (int r = 0; r < tempArray.Length; r++) array[i++] = tempArray[r];

    }

    //int array sorting function
    public static void Sort(int[] array)
    {
        mergeSort(array, 0, array.Length - 1);
    }


    //Generic sorting
    //recursive sort function that keep splitting array by half until reaching sub array of one item
    private static void mergeSort<T>(T[] array, int low, int high, Comparer<T> comparer)
    {
        if (low >= high) return; //if low and high meet return
        int mid = (high + low) / 2; //mid index
        mergeSort(array, low, mid, comparer); //repeat on left half of array
        mergeSort(array, mid + 1, high, comparer); //repeat on right half of array
        merge(array, low, high, mid, comparer); //apply merge & sort algorithm
    }

    //function that merges & sorts sub arrays
    private static void merge<T>(T[] array, int low, int high, int mid, Comparer<T> comparer)
    {
        int i = low; //set iterator starts from low (array left half start)
        int j = mid + 1;  //set iterator starts from mid + 1  (array right half start)
        T[] tempArray = new T[high - low + 1]; //create temp array that used to sort the merged arrays

        int k = 0; //temp array index iterator
        //loop i over left sub array and j over right sub array (the array that merged & holds to sub arrays in recursion)
        while (i <= mid && j <= high)
        {
            if (comparer.Compare(array[i], array[j]) <= 0) tempArray[k] = array[i++]; //if item at i smaller than item at j or equal add i to temp array then increase i
            else tempArray[k] = array[j++];  //if item at j smaller than item at i add i to temp array then increase j
            k++; //increase temp array index iterator
        }

        while (i <= mid) tempArray[k++] = array[i++]; //add all remaining items in left array in temp array

        while (j <= high) tempArray[k++] = array[j++]; //add all remaining items in right array in temp array

        //copy temp array to merged array starting from low index so it become sorted
        i = low;
        for (int r = 0; r < tempArray.Length; r++) array[i++] = tempArray[r];

    }

    //int array sorting function
    public static void sort<T>(T[] array, Comparer<T> comparer)
    {
        mergeSort(array, 0, array.Length - 1, comparer);
    }
}
