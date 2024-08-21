package org.example.Algo.Searching.BinaryTreeSearch;

import java.util.ArrayList;
import java.util.Comparator;

//Binary Tree implementation | From Repo: https://github.com/amrk000/Data-Structures-Implementation-Java-CSharp
//by Amrk000 - No license or attribution required

//generic BinaryTree of type <T>
public class BinaryTree<T> {
    private Node<T> root;
    private int size;
    private Comparator<T> comparator; //comparator that used to compare generic data

    public BinaryTree(Comparator<T> comparator) {
        root = null;
        size = 0;
        this.comparator = comparator;
    }

    //Node element that carry data and references to next children in tree chain
    private static class Node<T> {
        private T data;
        private Node<T> leftChild;
        private Node<T> rightChild;

        public Node(T data) {
            this.data = data;
            this.leftChild = null;
            this.rightChild = null;
        }
    }

    //return number of elements
    public int size() {
        return size;
    }

    //check if it's empty
    public boolean isEmpty() {
        return size == 0;
    }

    //calculate node height recursively (height is the count of edges)
    private int calcHeight(Node<T> node){
        if(node == null) return -1;
        return 1 + Math.max(calcHeight(node.leftChild), calcHeight(node.rightChild));
    }

    //returns tree height by counting edges from root to the deepest leaf
    public int height(){
        return calcHeight(root);
    }

    //add new element to tree recursively
    private Node<T> recursiveAddition(Node<T> currentNode, Node<T> newNode) {
        //if child is null last call in stack returns the newNode to be added to tree
        if (currentNode == null) return newNode; //addition condition

        if (comparator.compare(newNode.data, currentNode.data) < 0) {
            currentNode.leftChild = recursiveAddition(currentNode.leftChild, newNode); //move to left child
        } else if (comparator.compare(newNode.data, currentNode.data) > 0) {
            currentNode.rightChild = recursiveAddition(currentNode.rightChild, newNode); //move to right child
        } else {
            //if key of new element equals key in of node in tree throw exception and it won't be added
            throw new RuntimeException("There is already an item with Value: " + currentNode.data);
        }

        return currentNode;
    }

    //add new element
    public void add (T element){
        root = recursiveAddition(root, new Node<>(element));
        size++;
    }

    //get the deepest node in left side in subtree to replace the node that will be removed while deleting data
    private Node<T> getDeepestLeftNode(Node<T> node) {
        return node.leftChild == null ? node : getDeepestLeftNode(node.leftChild);
    }

    //remove element from tree recursively
    private Node<T> recursiveRemoval(Node<T> currentNode, T target) {

        if (currentNode == null) return null; //reached null child of leaf stop

        if (comparator.compare(target, currentNode.data) < 0) {
            currentNode.leftChild = recursiveRemoval(currentNode.leftChild, target); //move to left child
        } else if (comparator.compare(target, currentNode.data) > 0) {
            currentNode.rightChild = recursiveRemoval(currentNode.rightChild, target); //move to right child
        } else {
            //found target node
            if (currentNode.leftChild == null && currentNode.rightChild == null) {
                return null; //Case 1: sets current node to null if it's a leaf without children
            }
            else if (currentNode.rightChild == null) {
                return currentNode.leftChild; //Case 2: sets current node to left child if it has no right child
            }
            else if (currentNode.leftChild == null) {
                return currentNode.rightChild; //Case 3: sets current node to right child if it has no left child
            }

            //Case 4 (node has 2 children): replace the node value with the value of smallest child in right subtree
            Node<T> smallestNode = getDeepestLeftNode(currentNode.rightChild);
            currentNode.data = smallestNode.data;

            //remove the smallest child node in right subtree
            currentNode.rightChild = recursiveRemoval(currentNode.rightChild, smallestNode.data);

            //Note: Case 4 another approach is to replace node value with the value of biggest child in left subtree
        }

        return currentNode;
    }

    //delete node by its key
    public void remove(T element){
        root = recursiveRemoval(root, element);
        size--;
    }

    //Depth First Search (DFS) Traversals: inorder, preorder, postorder

    //traverse the tree inorder (Sorted order) recursively and return list of elements
    private void traverseInOrder(Node<T> node, ArrayList<T> output) {
        if (node != null) {
            traverseInOrder(node.leftChild, output);
            output.add(node.data);
            traverseInOrder(node.rightChild, output);
        }
    }

    //return list of elements inorder (sorted)
    public ArrayList<T> getInorderList(){
        ArrayList<T> output = new ArrayList<>();
        traverseInOrder(root, output);
        return output;
    }

    //traverse the tree preorder recursively and return list of elements
    private void traversePreorder(Node<T> node, ArrayList<T> output) {
        if (node != null) {
            output.add(node.data);
            traversePreorder(node.leftChild, output);
            traversePreorder(node.rightChild, output);
        }
    }

    //return list of elements preorder
    public ArrayList<T> getPreorderList(){
        ArrayList<T> output = new ArrayList<>();
        traversePreorder(root, output);
        return output;
    }

    //traverse the tree postorder recursively and return list of elements
    private void traversePostorder(Node<T> node, ArrayList<T> output) {
        if (node != null) {
            traversePostorder(node.leftChild, output);
            traversePostorder(node.rightChild, output);
            output.add(node.data);
        }
    }

    //return list of elements postorder
    public ArrayList<T> getPostorderList(){
        ArrayList<T> output = new ArrayList<>();
        traversePostorder(root, output);
        return output;
    }

    //Breadth First Search (BFS) Traversal: LevelOrder
    //traverse the tree LevelOrder and return list of elements
    private void traverseLevelOrder(ArrayList<T> output){
        if(root == null ) return;

        ArrayList<Node<T>> nodes = new ArrayList<>(); //levels queue
        nodes.add(root);

        while(!nodes.isEmpty()){
            Node<T> node = nodes.removeFirst();
            output.add(node.data);

            if(node.leftChild != null) nodes.add(node.leftChild);

            if(node.rightChild != null) nodes.add(node.rightChild);
        }
    }

    //return list of elements LevelOrder
    public ArrayList<T> getLevelorderList(){
        ArrayList<T> output = new ArrayList<>();
        traverseLevelOrder(output);
        return output;
    }

    //Depth First Search (DFS)
    private Node<T> search(Node<T> node, T target) {
        if(node == null) return null; //reached null child of leaf stop

        if (comparator.compare(target, node.data) < 0) return search(node.leftChild, target); //if target key is less than current move left
        else if(comparator.compare(target, node.data) > 0) return search(node.rightChild, target); //else if target key is bigger than current move right

        //else return current node which has key that equals target key
        return node;
    }

    //get data by element
    public T find(T element){
        Node<T> node = search(root, element);
        if(node==null) return null;
        return node.data;
    }

    //check if tree contain element
    public boolean contains(T element){
        return find(element) != null;
    }

    //clear all elements
    public void clear(){
        size = 0;
        root = null;
        System.gc(); // activate garbage collector to delete old array
    }

}
