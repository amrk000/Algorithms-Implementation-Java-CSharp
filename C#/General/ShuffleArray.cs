using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Array Shuffle Algorithm Implementation | From Repo: https://github.com/amrk000/Algorithms-Implementation-Java-CSharp
//by Amrk000 - No license or attribution required

//Shuffles given array
//>Runtime Complexity: O(n)
public static class ShuffleArray
{
    //integer array shuffle function
    public static void Shuffle(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            int randIndex = new Random().Next(i + 1, array.Length); //pick random item after current position

            //swap random picked item value with the current position value
            int temp = array[randIndex];
            array[randIndex] = array[i];
            array[i] = temp;
        }
    }

    //generic array shuffle function
    public static void Shuffle<T>(T[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            int randIndex = new Random().Next(i + 1, array.Length); //pick random item after current position

            //swap random picked item value with the current position value
            T temp = array[randIndex];
            array[randIndex] = array[i];
            array[i] = temp;
        }
    }
}