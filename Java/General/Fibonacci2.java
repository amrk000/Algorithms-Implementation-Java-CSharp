package org.example.Algo.General;

import java.util.ArrayList;
import java.util.Collections;

//Fibonacci Algorithm Implementation | From Repo: https://github.com/amrk000/Algorithms-Implementation-Java-CSharp
//by Amrk000 - No license or attribution required

//Integer numbers fibonacci sequence generator (Recursive)
//>Runtime Complexity: O(2^n)
public final class Fibonacci2 {
    //recursive function to calculates one item based on all previous numbers (works reversed from bound to 1)
    private static int calculate(int n){
        if (n <= 1) return n; //stop when n reaches 1
        int sum = calculate(n-1) + calculate(n-2); //calculate the 2 previous numbers
        return sum; //return result
    }

    //recursive function to loop to generate the sequence (works reversed from bound to 1)
    private static void fibonacci(int numbersCount, ArrayList<Integer> numbers){
        if(numbersCount <= 0) return; //stop when counter reaches 0
        numbers.add(calculate(numbersCount-1)); //calculte next item and add to sequence
        fibonacci(numbersCount-1, numbers); //loop again
    }

    //calculate the sequence based on numbersCount
    public static ArrayList<Integer> getSequence(int numbersCount){
        ArrayList<Integer> numbers = new ArrayList<>(); //array list to store sequence numbers
        fibonacci(numbersCount, numbers); //call recursive algorithm
        Collections.reverse(numbers); //reverse sequence numbers
        return numbers;
    }
}
