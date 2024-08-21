using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Fibonacci Algorithm Implementation | From Repo: https://github.com/amrk000/Algorithms-Implementation-Java-CSharp
//by Amrk000 - No license or attribution required

//Integer numbers fibonacci sequence generator (Iterative)
//>Runtime Complexity: O(n)
public static class Fibonacci
{
    public static List<int> GetSequence(int numbersCount)
    {
        List<int> numbers = new List<int>(); //array list to store sequence numbers
        numbers.Add(0); //add zero as first item

        int n1 = 0, n2 = 1, sum = 1; //n1: first item, n2: second item, n3: third item which equals n1 + n2
        for (int i = 0; i < numbersCount; i++)
        {
            numbers.Add(sum); //add sum of previous 2 numbers to sequence

            sum = n1 + n2; //calculate new sum
            n1 = n2; //move forward n1 to n2
            n2 = sum; // move forward n2 to sum
        }

        return numbers;
    }
}

