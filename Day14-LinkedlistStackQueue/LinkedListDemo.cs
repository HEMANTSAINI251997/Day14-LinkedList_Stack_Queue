using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_LinkedlistStackQueue
{
    public class LinkedListDemo
    {
        public void CheckLinkedList()
        {
            LinkedList<int> ints = new LinkedList<int>();
            ints.AddLast(30);
            ints.AddLast(56);
            ints.AddFirst(70);
            foreach (var item in ints)
            {
                Console.WriteLine("ELEMEMTS = " + item);
            }
        }

        public Node head;
        public void Add(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
        }
        public void Display()
        {
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is Empty");
                return;
            }

            while (temp != null)
            {
                Console.WriteLine("ELEMENT = " + temp.data);
                temp = temp.next;
            }


        }
    }
}
