package org.example.Algo.Searching.AVLTreeSearch;

import org.example.Algo.Searching.BinaryTreeSearch.BinaryTree;

import java.util.Comparator;

//Search In AVL Tree Algorithm Implementation | From Repo: https://github.com/amrk000/Algorithms-Implementation-Java-CSharp
//by Amrk000 - No license or attribution required

//Algorithm that turns array into AVL tree and search in it
//>Runtime Complexity: Avg: O(log(n)) | Worst: O(log(n))
public final class AVLTreeSearch {
    public static boolean find(int[] array, int target){
        AVLTree<Integer> AVLTree = new AVLTree<>(Integer::compareTo);
        for(int number : array) AVLTree.add(number); //convert array to avl tree
        return AVLTree.contains(target); //search in avl tree
    }

    public static <T> boolean find(T[] array, T target, Comparator<T> comparator){
        AVLTree<T> AVLTree = new AVLTree<>(comparator);
        for(T number : array) AVLTree.add(number); //convert array to avl tree
        return AVLTree.contains(target); //search in avl tree
    }

}
