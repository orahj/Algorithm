using System;
using System.Collections.Generic;

namespace CyclicLinkedList
{
    class CustomLinkedList
    {
        public Node head;
        public class Node
        {
            public int data;
            public Node next;

            public Node(int d) 
            {
                data = d;
                next = null;
            }
        }

        public Boolean HasCycle()
        {
            HashSet<Node> nodes = new HashSet<Node>();
            Node current = head;
            while(current != null)
            {
                if (nodes.Contains(current))
                {
                    return true;
                }
                else
                {
                    nodes.Add(current);
                }
                current = current.next;
            }

            return false;
        }
        static void Main(string[] args)
        {
            CustomLinkedList noCycleList = new CustomLinkedList();
            Node firstNode = new Node(2);
            Node secondNode = new Node(3);
            Node thirdNode = new Node(4);
            Node fouthNode = new Node(5);
            Node fiftNode = new Node(6);

            noCycleList.head = firstNode;
            firstNode.next = secondNode;
            secondNode.next = thirdNode;
            thirdNode.next = fouthNode;
            fouthNode.next = fiftNode;

            Console.WriteLine(noCycleList.HasCycle());
            Console.WriteLine();

            CustomLinkedList cycleLinkedList = new CustomLinkedList();
            cycleLinkedList.head = firstNode;
            thirdNode.next = secondNode;

            Console.WriteLine(cycleLinkedList.HasCycle());
        }
    }
}
