using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class CustomLinkedList
    {
        Node head;
        public class Node
        {
            public int data;
            public Node next;

            public Node(int d) { data = d; }
        }

        public void DeleteBackHalf()
        {
            if(head == null && head.next == null)
            {
                head = null;
            }
            Node slow = head;
            Node fast = head;
            Node prev = null;
            while(fast != null && fast.next != null)
            {
                prev = slow.next;
                slow = slow.next;
                fast = fast.next.next;
            }
            prev.next = null;
        }
        public void DisplayContent()
        {
            Node current = head;
            while (current != null)
            {
                Console.Write(current.data + "->");
                current = current.next;
            }
        }
        public void DeleteKNodeFromEndOfList(int k)
        {

        }
        static void Main(string[] args)
        {
            CustomLinkedList list = new CustomLinkedList();
            Node firstNode = new Node(4);
            Node secondNode = new Node(5);
            Node thirdNode = new Node(10);
            Node fouthNode = new Node(7);
            Node fiftNode = new Node(16);

            list.head = firstNode;
            firstNode.next = secondNode;
            secondNode.next = thirdNode;
            thirdNode.next = fouthNode;
            fouthNode.next = fiftNode;
            list.DisplayContent();
            list.DeleteBackHalf();
            Console.WriteLine();
            list.DisplayContent();
        }
    }
}
