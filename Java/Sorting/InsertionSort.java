package org.example.Algo.Sorting;

import java.util.Comparator;

//Insertion Sort Algorithm Implementation | From Repo: https://github.com/amrk000/Algorithms-Implementation-Java-CSharp
//by Amrk000 - No license or attribution required

//Algorithm that sorts array using insertion approach
//>Runtime Complexity: O(n^2)
public final class InsertionSort {
    //sort integer array
    public static void sort(int[] array) {
        //loop over array and work on the elements before current (starts at 1)
        for (int i = 1; i < array.length; i++) {
            int current = array[i]; //hold current value temporary
            int j = i; //get current index
            //loop backward from current index as long as selected value is less than item
            while(j > 0 && current < array[j-1]) {
                array[j] = array[j-1]; //shift elements right
                j--;
            }
            array[j] = current; //loop stopped so insert current at stop index
        }
    }

    //sort generic array
    public static <T> void sort(T[] array, Comparator<T> comparator) {
        //loop over array and work on the elements before current (starts at 1)
        for (int i = 1; i < array.length; i++) {
            T current = array[i]; //hold current value temporary
            int j = i; //get current index
            //loop backward from current index as long as selected value is less than item
            while(j > 0 && comparator.compare(current, array[j-1]) < 0) {
                array[j] = array[j-1]; //shift elements right
                j--;
            }
            array[j] = current; //loop stopped so insert current at stop index
        }
    }

}
