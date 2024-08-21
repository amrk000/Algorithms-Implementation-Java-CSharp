package org.example.Algo.General;

import java.util.ArrayList;

//Prime Numbers Algorithm Implementation | From Repo: https://github.com/amrk000/Algorithms-Implementation-Java-CSharp
//by Amrk000 - No license or attribution required

//Algorithm that checks if given number is Prime & print sequence of Primes
//>Runtime Complexity: O(sqrt(n))
public final class PrimeNumbers {
    //check if number is prime
    public static boolean checkNumber(int number){
        if(number < 2) return false; //return false if number less than 2
        for(int i = 2; i <= Math.sqrt(number); i++) //check all numbers before square root of checked number (instead of checking all the numbers before it so big O reduced from n to sqrt n)
            if(number % i == 0) return false; //if number divides the checked number then it's not prime
        return true; //no number that divides the checked number found so it's prime
    }

    //returns sequence of prime numbers in range
    public static ArrayList<Integer> getNumbers(int from, int to){
        ArrayList<Integer> numbers = new ArrayList<>(); //list to store numbers
        for(int i = from; i <= to; i++)
            if(checkNumber(i)) numbers.add(i); //loop teh range to add to list
        return numbers; //return the list
    }

    //returns sequence of prime numbers from 2 to bound
    public static ArrayList<Integer> getNumbers(int toBound){
        return getNumbers(2, toBound);
    }
}
