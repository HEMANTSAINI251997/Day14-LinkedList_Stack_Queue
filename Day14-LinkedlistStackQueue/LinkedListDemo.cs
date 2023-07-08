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
            foreach(var item in ints)
            {
                Console.WriteLine("ELEMEMTS = " + item);
            }
        }
    }
}
