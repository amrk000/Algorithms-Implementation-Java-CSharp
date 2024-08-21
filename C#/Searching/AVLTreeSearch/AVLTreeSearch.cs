using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Search In AVL Tree Algorithm Implementation | From Repo: https://github.com/amrk000/Algorithms-Implementation-Java-CSharp
//by Amrk000 - No license or attribution required

//Algorithm that turns array into AVL tree and search in it
//>Runtime Complexity: Avg: O(log(n)) | Worst: O(log(n))
public static class AVLTreeSearch
{
    public static bool Find(int[] array, int target)
    {
        AVLTree<int> AVLTree = new AVLTree<int>(Comparer<int>.Default);
        foreach (int number in array) AVLTree.Add(number); //convert array to avl tree
        return AVLTree.Contains(target); //search in avl tree
    }

    public static bool Find<T>(T[] array, T target, Comparer<T> comparer)
    {
        AVLTree<T> AVLTree = new AVLTree<T>(comparer);
        foreach (T number in array) AVLTree.Add(number); //convert array to avl tree
        return AVLTree.Contains(target); //search in avl tree
    }

}