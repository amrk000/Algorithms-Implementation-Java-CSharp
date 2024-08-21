using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Prime Numbers Algorithm Implementation | From Repo: https://github.com/amrk000/Algorithms-Implementation-Java-CSharp
//by Amrk000 - No license or attribution required

//Algorithm that checks if given number is Prime & print sequence of Primes
//>Runtime Complexity: O(sqrt(n))
public static class PrimeNumbers
{
    //check if number is prime
    public static bool CheckNumber(int number)
    {
        if (number < 2) return false; //return false if number less than 2
        for (int i = 2; i <= Math.Sqrt(number); i++) //check all numbers before square root of checked number (instead of checking all the numbers before it so big O reduced from n to sqrt n)
            if (number % i == 0) return false; //if number divides the checked number then it's not prime
        return true; //no number that divides the checked number found so it's prime
    }

    //returns sequence of prime numbers in range
    public static List<int> GetNumbers(int from, int to)
    {
        List<int> numbers = new List<int>(); //list to store numbers
        for (int i = from; i <= to; i++)
            if (CheckNumber(i)) numbers.Add(i); //loop teh range to add to list
        return numbers; //return the list
    }

    //returns sequence of prime numbers from 2 to bound
    public static List<int> getNumbers(int toBound)
    {
        return GetNumbers(2, toBound);
    }
}