using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Palindrome Algorithm Implementation | From Repo: https://github.com/amrk000/Algorithms-Implementation-Java-CSharp
//by Amrk000 - No license or attribution required

//Algorithm that checks if given number is palindrome
//>Runtime Complexity: O(log(n))
public static class Palindrome
{
    //function that takes number as string
    public static bool CheckNumber(String number)
    {
        int left = 0; //left start
        int right = number.Length - 1; //right start

        //move left and right towards center
        while (left < right)
        {
            if (number[left] != number[right]) return false; //check each digit on both sides and return false if difference found
            left++; //move left to right
            right--; //move right to left
        }

        return true; //no differences found
    }

    //function that takes number as integer
    public static bool CheckNumber(int number)
    {
        String x = Convert.ToString(number); //convert number to string
        return CheckNumber(x);
    }
}