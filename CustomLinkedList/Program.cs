using System;

namespace CustomLinkedList
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
            Node previous = null;
            while (fast != null && fast.next != null)
            {
                previous = slow;
                slow = slow.next;
                fast = fast.next.next;
            }

            previous.next = null;
        }

        public void DeleteKNodeFromEnd(int k)
        {
            if(head == null && k < 0)
            {
                return;
            }
            Node first = head;
            Node second = head;

            //move the second node to the Kth node
            for(int i = 0; i < k; i++)
            {
                second = second.next;
                if(second.next == null)
                {
                    if(i == k - 1)
                    {
                        head = head.next;
                    }
                    return;
                }
            }

            while(second.next != null)
            {
                first = first.next;
                second = second.next;
            }

            first.next = first.next.next;
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

            //list.DisplayContent();
            //list.DeleteBackHalf();
            //Console.WriteLine();
            //list.DisplayContent();

            //deleting element @k
            list.DisplayContent();
            list.DeleteKNodeFromEnd(3);
            Console.WriteLine();
            list.DisplayContent();
        }
    }
}
