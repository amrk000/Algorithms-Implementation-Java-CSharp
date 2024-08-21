package org.example.Algo.Sorting;

import java.util.Comparator;

//Selection Sort Algorithm Implementation | From Repo: https://github.com/amrk000/Algorithms-Implementation-Java-CSharp
//by Amrk000 - No license or attribution required

//Algorithm that sorts array using selection approach
//>Runtime Complexity: O(n^2)
public final class SelectionSort {
    //sort integer array
    public static void sort(int[] array){
        //loop over array elements
        for(int i=0; i< array.length-1; i++){
            int minIndex = i; //guess that minimum element in array index is i

            //loop all element after i to find the minimum element
            for(int j=i+1; j< array.length; j++){
                if(array[j] < array[minIndex]) minIndex = j; //if element found smaller than i holt its index
            }

            //swap minimum element with element at i
            int temp = array[minIndex];
            array[minIndex] = array[i];
            array[i] = temp;
        }
    }

    //sort generic array
    public static <T> void sort(T[] array, Comparator<T> comparator){
        //loop over array elements
        for(int i=0; i< array.length-1; i++){
            int minIndex = i; //guess that minimum element in array index is i

            //loop all element after i to find the minimum element
            for(int j=i+1; j< array.length; j++){
                if(comparator.compare(array[j], array[minIndex]) < 0) minIndex = j; //if element found smaller than i holt its index
            }

            //swap minimum element with element at i
            T temp = array[minIndex];
            array[minIndex] = array[i];
            array[i] = temp;
        }
    }
}
