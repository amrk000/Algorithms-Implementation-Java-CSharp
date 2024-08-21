using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Binary Search Algorithm Implementation | From Repo: https://github.com/amrk000/Algorithms-Implementation-Java-CSharp
//by Amrk000 - No license or attribution required

//Algorithm that searches for an element in array using binary approach
//>Runtime Complexity: O(log(n))
public static class BinarySearch
{

    //function that searches in int array and returns element index
    public static int Find(int[] array, int target)
    {
        if (array.Length == 0) return -1; //return not found if array is empty

        int startIndex = 0; //start index at first element
        int endIndex = array.Length - 1; //end index at last element

        //loop until start and end meet (will meet at mid element)
        while (startIndex <= endIndex)
        {
            int midIndex = (startIndex + endIndex) / 2; //get mid index
            int midElement = array[midIndex]; //get mid value

            if (midElement == target) return midIndex; //if target found return mid index
            else if (target < midElement) endIndex = midIndex - 1; //if target < mid get left half of array and search in it
            else startIndex = midIndex + 1; //if target > mid get right half of array and search in it
        }

        return -1; //target not found
    }

    //function that searches in generic array and returns element index
    public static int Find<T>(T[] array, T target, Comparer<T> comparer)
    {
        if (array.Length == 0) return -1; //return not found if array is empty

        int startIndex = 0; //start index at first element
        int endIndex = array.Length - 1; //end index at last element

        //loop until start and end meet (will meet at mid element)
        while (startIndex <= endIndex)
        {
            int midIndex = (startIndex + endIndex) / 2; //get mid index
            T midElement = array[midIndex]; //get mid value

            if (midElement.Equals(target)) return midIndex; //if target found return mid index
            else if (comparer.Compare(target, midElement) < 0) endIndex = midIndex - 1; //if target < mid get left half of array and search in it
            else startIndex = midIndex + 1; //if target > mid get right half of array and search in it
        }

        return -1; //target not found
    }
}