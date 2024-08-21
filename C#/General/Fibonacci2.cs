using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Fibonacci Algorithm Implementation | From Repo: https://github.com/amrk000/Algorithms-Implementation-Java-CSharp
//by Amrk000 - No license or attribution required

//Integer numbers fibonacci sequence generator (Recursive)
//>Runtime Complexity: O(2^n)
public static class Fibonacci2
{
    //recursive function to calculates one item based on all previous numbers (works reversed from bound to 1)
    private static int Calculate(int n)
    {
        if (n <= 1) return n; //stop when n reaches 1
        int sum = Calculate(n - 1) + Calculate(n - 2); //calculate the 2 previous numbers
        return sum; //return result
    }

    //recursive function to loop to generate the sequence (works reversed from bound to 1)
    private static void Fibonacci(int numbersCount, List<int> numbers)
    {
        if (numbersCount <= 0) return; //stop when counter reaches 0
        numbers.Add(Calculate(numbersCount - 1)); //calculte next item and add to sequence
        Fibonacci(numbersCount - 1, numbers); //loop again
    }

    //calculate the sequence based on numbersCount
    public static List<int> GetSequence(int numbersCount)
    {
        List<int> numbers = new List<int>(); //array list to store sequence numbers
        Fibonacci(numbersCount, numbers); //call recursive algorithm
        numbers.Reverse(); //reverse sequence numbers
        return numbers;
    }
}