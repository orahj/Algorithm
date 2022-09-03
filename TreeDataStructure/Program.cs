using System;

namespace TreeDataStructure
{
    class Program
    {
        public class Node
        {
            public Node Left { get; set; }
            public Node Right { get; set; }
            public int Data { get; set; }
        }

        static class BinarySearchTree
        {
            public static bool Contains(Node root, int value)
            {
                if (root == null)
                {
                    return false;
                }
                else if(value < root.Data)
                {
                    return Contains(root.Left, value);
                }
                else if(value > root.Data)
                {
                    return Contains(root.Right, value);
                }
                else
                {
                    return true;
                }
            }
            public static Node Insert(Node root, int value)
            {
                if(root == null)
                {
                    root = new Node();
                    root.Data = value;
                }
                else if (root.Data > value)
                {
                    //inser left
                    root.Left = Insert(root.Left, value);
                }
                else
                {
                    //inser right
                    root.Right = Insert(root.Right, value);
                }

                return root;
            }
        }
        class BinaryTree
        {
            public static void PreOrderTraversal(Node root)
            {
                if (root == null)
                {
                    return;
                }

                Console.Write(root.Data + " ");

                PreOrderTraversal(root.Left);
                PreOrderTraversal(root.Right);
            }
            public static void InOrderTraversal(Node root)
            {
                if (root == null)
                {
                    return;
                }
                InOrderTraversal(root.Left);
                Console.Write(root.Data + " ");
                InOrderTraversal(root.Right);
            }
            public static void PostOrderTraversal(Node root)
            {
                if (root == null)
                {
                    return;
                }
                PostOrderTraversal(root.Left);
                PostOrderTraversal(root.Right);
                Console.Write(root.Data + " ");
            }
        }
        static void Main(string[] args)
        {
            //The tree Data structure is useful for non-linear data. A tree is a
            //collection of node where each node might be lnked one, two or more nodes
            //A tree needs to have a collection of nodes that connected in someway by a list.
            Node rootNode = new Node();
            rootNode.Data = 4;
            BinarySearchTree.Insert(rootNode, 3);
            BinarySearchTree.Insert(rootNode, 5);
            BinarySearchTree.Insert(rootNode, 2);
            BinarySearchTree.Insert(rootNode, 5);
            BinarySearchTree.Insert(rootNode, 7);
            BinarySearchTree.Insert(rootNode, 1);

            Console.WriteLine(BinarySearchTree.Contains(rootNode,1));
            Console.WriteLine(BinarySearchTree.Contains(rootNode, 5));
            Console.WriteLine(BinarySearchTree.Contains(rootNode, 4));
            Console.WriteLine(BinarySearchTree.Contains(rootNode, 7));
            Console.WriteLine(BinarySearchTree.Contains(rootNode, 5));

            Console.WriteLine(BinarySearchTree.Contains(rootNode, 11));
            Console.WriteLine(BinarySearchTree.Contains(rootNode, 72));
            Console.WriteLine(BinarySearchTree.Contains(rootNode, 25));

            //way to traverse a data in the binary tree: Preorder,Inorder and Postorder

            //       4
            //   1       3
            //8     9  6

            //Node rtNode = new Node();
            //rtNode.Data = 4;

            //Node nodeOne = new Node();
            //nodeOne.Data = 1;

            //Node nodeThree = new Node();
            //nodeThree.Data = 3;

            //Node nodeEight = new Node();
            //nodeEight.Data = 8;

            //Node nodeNine = new Node();
            //nodeNine.Data = 9;

            //Node nodeSix = new Node();
            //nodeSix.Data = 6;
            //rtNode.Left = nodeOne;
            //rtNode.Right = nodeThree;
            //nodeOne.Left = nodeEight;
            //nodeOne.Right = nodeNine;
            //nodeThree.Left = nodeSix;

            //BinaryTree.PreOrderTraversal(rtNode);

        }


    }
}
