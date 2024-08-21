using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//MinHeap using array implementation | From Repo: https://github.com/amrk000/Data-Structures-Implementation-Java-CSharp
//by Amrk000 - No license or attribution required

//generic fixed MinHeap of type <T>
class MinHeap<T>
{
    private Node<T>[] array;
    private int size;

    //Node element that carry data and priority of element
    internal class Node<T>
    {
        internal int priority;
        internal T data;

        public Node(int priority, T data)
        {
            this.priority = priority;
            this.data = data;
        }
    }

    public MinHeap(int capacity)
    {
        size = 0;
        array = new Node<T>[capacity];
    }

    //return number of elements
    public int Size()
    {
        return size;
    }

    //return number of max elements that it can carry
    public int Capacity()
    {
        return array.Length;
    }

    //check if it's empty
    public bool isEmpty()
    {
        return Size() == 0;
    }

    //get node's parent index in array
    private int GetParentIndex(int nodeIndex)
    {
        return (nodeIndex - 1) / 2; //if heap elements starts at 1 it  will be: (nodeIndex)/2
    }

    //get node's left child index in array
    private int GetLeftChildIndex(int nodeIndex)
    {
        return (2 * nodeIndex) + 1; //if heap elements starts at 1 it  will be: (2*nodeIndex)
    }

    //get node's right child index in array
    private int GetRightChildIndex(int nodeIndex)
    {
        return (2 * nodeIndex) + 2; //if heap elements starts at 1 it  will be: (2*nodeIndex)+1
    }

    //bubble up the element as long as it's smaller than parent
    private void HeapifyUp(int index)
    {
        Node<T> temp = array[index]; //hold current element value

        while (index > 0 && temp.priority < array[GetParentIndex(index)].priority)
        {
            array[index] = array[GetParentIndex(index)]; //move parent's value down to current element
            index = GetParentIndex(index); //go up
        }

        array[index] = temp; //set current position value to element value
    }

    //bubble down the element as long as it's bigger than children
    private void HeapifyDown(int index)
    {
        Node<T> temp = array[index]; //hold current element value
        int targetChildIndex;

        while (index < size / 2)
        {
            //calculate diff between the children and parent priority
            int leftDiff = temp.priority - array[GetLeftChildIndex(index)].priority;
            int rightDiff = temp.priority - array[GetRightChildIndex(index)].priority;

            //diffs == 0 or less which means that both children are bigger than parent  break
            if (leftDiff <= 0 && rightDiff <= 0) break;

            //get target child index
            if (leftDiff > rightDiff) targetChildIndex = GetLeftChildIndex(index);
            else targetChildIndex = GetRightChildIndex(index);

            //move child value up to current element
            array[index] = array[targetChildIndex];
            index = targetChildIndex; //go down
        }

        array[index] = temp; //set current position value to element value
    }

    //add element to heap
    public void Add(int priority, T element)
    {
        if (Size() == Capacity()) throw new IndexOutOfRangeException("Heap is full - capacity:" + Capacity());

        Node<T> node = new Node<T>(priority, element);
        int elementIndex = size;
        array[size++] = node;
        HeapifyUp(elementIndex); //move up node
    }

    //delete min value (at root) and return data
    public T Remove()
    {
        if (isEmpty()) return default;

        Node<T> min = array[0];
        array[0] = array[size - 1]; //swap min value node with last node in heap
        size--;
        HeapifyDown(0); //move down node to a suitable position
        return (T)min.data;
    }

    //check the front of heap
    public T PeekFront()
    {
        if (isEmpty()) return default;
        return (T)array[0].data;
    }

    //delete all elements
    public void clear()
    {
        size = 0;
        array = new Node<T>[Capacity()];
        GC.Collect(); // activate garbage collector to delete old array
    }
}
