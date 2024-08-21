package org.example.Algo.Searching.BinaryTreeSearch;

import java.util.Comparator;

//Search In Binary Tree Algorithm Implementation | From Repo: https://github.com/amrk000/Algorithms-Implementation-Java-CSharp
//by Amrk000 - No license or attribution required

//Algorithm that turns array into binary tree and search in it
//>Runtime Complexity: Avg: O(log(n)) | Worst: O(n) [if tree is skewed]
public final class BinaryTreeSearch {
    public static boolean find(int[] array, int target){
        BinaryTree<Integer> binaryTree = new BinaryTree<>(Integer::compareTo);
        for(int number : array) binaryTree.add(number); //convert array to binary tree
        return binaryTree.contains(target); //search in binary tree
    }

    public static <T> boolean find(T[] array, T target, Comparator<T> comparator){
        BinaryTree<T> binaryTree = new BinaryTree<>(comparator);
        for(T number : array) binaryTree.add(number); //convert array to binary tree
        return binaryTree.contains(target); //search in binary tree
    }

}
