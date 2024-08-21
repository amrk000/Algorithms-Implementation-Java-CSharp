using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Heap Sort Algorithm Implementation | From Repo: https://github.com/amrk000/Algorithms-Implementation-Java-CSharp
//by Amrk000 - No license or attribution required

//Algorithm that sorts array using min heap
//>Runtime Complexity: O(nlog(n))
public static class HeapSort
{
    //sort integer array
    public static void Sort(int[] array)
    {
        MinHeap<int> minHeap = new MinHeap<int>(array.Length);
        foreach (int number in array) minHeap.Add(number, number); //add array elements to heap (priority, value)
        for (int i = 0; i < array.Length; i++) array[i] = minHeap.Remove(); //pop out elements from heap to get them sorted
    }

    //sort string array
    public static void Sort(String[] array)
    {
        MinHeap<String> minHeap = new MinHeap<String>(array.Length);

        foreach (String element in array)
        {
            int stringPriority = element[0]; //get string priority by getting ascii code of first character
            minHeap.Add(stringPriority, element); //add array elements to heap (priority, value)
        }
        for (int i = 0; i < array.Length; i++) array[i] = minHeap.Remove(); //pop out elements from heap to get them sorted
    }
}
