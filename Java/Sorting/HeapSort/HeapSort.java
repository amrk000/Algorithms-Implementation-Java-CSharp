package org.example.Algo.Sorting.HeapSort;

//Heap Sort Algorithm Implementation | From Repo: https://github.com/amrk000/Algorithms-Implementation-Java-CSharp
//by Amrk000 - No license or attribution required

//Algorithm that sorts array using min heap
//>Runtime Complexity: O(nlog(n))
public final class HeapSort {
    //sort integer array
    public static void sort(int[] array){
        MinHeap<Integer> minHeap = new MinHeap<>(array.length);
        for(int number: array) minHeap.add(number, number); //add array elements to heap (priority, value)
        for(int i=0; i< array.length; i++) array[i] = minHeap.remove(); //pop out elements from heap to get them sorted
    }

    //sort string array
    public static void sort(String[] array){
        MinHeap<String> minHeap = new MinHeap<>(array.length);

        for(String element: array){
            int stringPriority = element.charAt(0); //get string priority by getting ascii code of first character
            minHeap.add(stringPriority, element); //add array elements to heap (priority, value)
        }
        for(int i=0; i< array.length; i++) array[i] = minHeap.remove(); //pop out elements from heap to get them sorted
    }
}
