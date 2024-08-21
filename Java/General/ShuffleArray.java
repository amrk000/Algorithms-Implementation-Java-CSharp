package org.example.Algo.General;

import java.util.Random;

//Array Shuffle Algorithm Implementation | From Repo: https://github.com/amrk000/Algorithms-Implementation-Java-CSharp
//by Amrk000 - No license or attribution required

//Shuffles given array
//>Runtime Complexity: O(n)
public final class ShuffleArray {
    //integer array shuffle function
    public static void shuffle(int[] array){
        for(int i=0; i< array.length-1; i++){
            int randIndex = new Random().nextInt(i+1, array.length); //pick random item after current position

            //swap random picked item value with the current position value
            int temp = array[randIndex];
            array[randIndex] = array[i];
            array[i] = temp;
        }
    }

    //generic array shuffle function
    public static <T> void shuffle(T[] array){
        for(int i=0; i< array.length-1; i++){
            int randIndex = new Random().nextInt(i+1, array.length); //pick random item after current position

            //swap random picked item value with the current position value
            T temp = array[randIndex];
            array[randIndex] = array[i];
            array[i] = temp;
        }
    }
}
