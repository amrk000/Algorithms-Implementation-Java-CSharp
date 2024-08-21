using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Palindrome Algorithm Implementation | From Repo: https://github.com/amrk000/Algorithms-Implementation-Java-CSharp
//by Amrk000 - No license or attribution required

//Algorithm that checks if given number is palindrome
//>Runtime Complexity: O(n)
public static class Palindrome2
{
    public static bool CheckNumber(int number)
    {
        int x = number, reverse = 0; //get temp value of number, create reverse variable

        //loop to reverse x value in reverse variable mathematically
        while (x != 0)
        {
            reverse = reverse * 10 + x % 10; //shift reverse value left by multiplying by 10 then add right most digit of x
            x = x / 10; //remove right most digit from x
        }

        return number == reverse; //check iv revers equals original number
    }
}