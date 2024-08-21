package org.example.Algo.Searching;

//Linear Search Algorithm Implementation | From Repo: https://github.com/amrk000/Algorithms-Implementation-Java-CSharp
//by Amrk000 - No license or attribution required

//Algorithm that searches for an element in array
//>Runtime Complexity: O(n)
public final class LinearSearch {
    //function that searches in int array and returns element index
    public static int find(int[] array, int target){
        if(array.length == 0) return -1; //return not found if array is empty

        //loop over array and return target index if found
        for(int i=0; i< array.length; i++){
            if(array[i] == target)
                return i;
        }

        return -1; //target not found
    }

    //function that searches in generic array and returns element index
    public static <T> int find(T[] array, T target){
        if(array.length == 0) return -1; //return not found if array is empty

        //loop over array and return target index if found
        for(int i=0; i< array.length; i++){
            if(array[i] == target)
                return i;
        }

        return -1; //target not found
    }

}
