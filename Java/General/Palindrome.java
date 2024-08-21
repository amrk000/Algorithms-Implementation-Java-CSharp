package org.example.Algo.General;

//Palindrome Algorithm Implementation | From Repo: https://github.com/amrk000/Algorithms-Implementation-Java-CSharp
//by Amrk000 - No license or attribution required

//Algorithm that checks if given number is palindrome
//>Runtime Complexity: O(log(n))
public final class Palindrome {
    //function that takes number as string
    public static boolean checkNumber(String number){
        int left = 0; //left start
        int right = number.length()-1; //right start

        //move left and right towards center
        while(left < right){
            if(number.charAt(left) != number.charAt(right)) return false; //check each digit on both sides and return false if difference found
            left++; //move left to right
            right--; //move right to left
        }

        return true; //no differences found
    }

    //function that takes number as integer
    public static boolean checkNumber(int number){
        String x = String.valueOf(number); //convert number to string
        return checkNumber(x);
    }
}
